using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Runtime.InteropServices;

using System.Data.OleDb;

using Facturacion.Configuracion;
using Facturacion.Excepciones;
using XTANGO_GV;


namespace Facturacion.Datos
{
    public static class xTangoProcesos {
        public const int cosa = 1;
    }
    class xTangoAdapter
    {
        HardLockServer.LogOnClass _tangoLogOn;

        #region properties
        public HardLockServer.LogOnClass tangoLogOn { get { return _tangoLogOn; } }
        #endregion

        private static xTangoAdapter singleton;

        public static xTangoAdapter getInstance()
        {
            if (singleton == null)
                singleton = new xTangoAdapter();
            return singleton;
        }

        /// <summary>
        /// Autentica el usuario en tango. 
        /// </summary>
        /// <param name="llaveTango"></param>
        /// <param name="usuarioTango"></param>
        /// <param name="passwordTango"></param>
        /// <param name="nombreEmpresa"></param>
        /// <returns>HardLockServer.LogOnClass con inormacion de autenticacion</returns>
        public HardLockServer.LogOnClass TangoLogin(
            string llaveTango,
            string usuarioTango,
            string passwordTango,
            string nombreEmpresa)
        {
            string strError = "";
            string appName = "";
            try
            {
                appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            }
            catch { }

            _tangoLogOn = new HardLockServer.LogOnClass();

            bool logonOk = false;
            try
            {
                logonOk = _tangoLogOn.LogServerUserEx(
                                llaveTango,
                                usuarioTango,
                                passwordTango,
                                nombreEmpresa,
                                appName,
                                ref strError
                                );
            }
            catch (COMException ex) {
                throw new Excepciones.XTangoException("Error en ingreso a tango: " + ex.Message);
            }
            if (!logonOk)
            {
                _tangoLogOn.DropInterface();
                _tangoLogOn = null;
                throw new Excepciones.XTangoException("Error en ingreso a tango: " + strError);
            }
            else
                return _tangoLogOn;
        }

        public void TangoLogoff () {
            _tangoLogOn.DropInterface();
            _tangoLogOn = null;
        }
    }

    class xTangoFacturaData {
        public ADODB.Recordset rsFacEncabezado { get; set; }
        public ADODB.Recordset rsFacRenglones { get; set; }
        public ADODB.Recordset rsFacImpuestos { get; set; }
        public ADODB.Recordset rsFacCuotas { get; set; }
        public ADODB.Recordset rsFonEncabezado { get; set; }
        public ADODB.Recordset rsFonRenglones { get; set; }
    }

    class xTangoComprobantes : xTangoAdapter
    {
        /// <summary>
        /// Crea las estructuras necesarias para la facturacion
        /// </summary>
        /// <returns></returns>
        public bool makeEstructuras(out xTangoFacturaData data) {
            // ------------------------------- INI TEST ------------------------------------//
            XTANGO_GV.Comprobantes objComprob;
            objComprob = (XTANGO_GV.Comprobantes) Activator.CreateInstance
                (Type.GetTypeFromProgID("XTango_GV.Comprobantes"));

            bool resultado = false;
            data = new xTangoFacturaData();

            object Struct = null;
            resultado = objComprob.Make_FacEncabezado(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FacEncabezado");
            }
            data.rsFacEncabezado = (ADODB.Recordset)Struct;

            //Renglones
            resultado = objComprob.Make_FacRenglones(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FacRenglones");
            }
            data.rsFacRenglones = (ADODB.Recordset)Struct;

            //Impuestos
            resultado = objComprob.Make_FacImpuestos(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FacImpuestos");
            }
            data.rsFacImpuestos = (ADODB.Recordset)Struct;

            //Cuotas
            resultado = objComprob.Make_FacCuotas(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FacCuotas");
            }
            data.rsFacCuotas = (ADODB.Recordset)Struct;

            //Fondos Encabezados
            resultado = objComprob.Make_FondosEncabezado(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FondosEncabezado");
            }
            data.rsFonEncabezado = (ADODB.Recordset)Struct;

            //Fondos Renglones
            resultado = objComprob.Make_FondosRenglones(tangoLogOn, ref Struct);
            if (!resultado)
            {
                throw new XTangoException("Fallo el metodo Make_FondosRenglones");
            }
            data.rsFonRenglones = (ADODB.Recordset)Struct;
            resultado = true;
            return resultado;
        }
        public bool addFacturas(bool defectos, bool contado, xTangoFacturaData data, out ADODB.Recordset adoReporte) {
            // Clase para el alta de comprobantes.
            XTANGO_GV.Comprobantes xComprobantes;
            xComprobantes = (XTANGO_GV.Comprobantes)Activator.CreateInstance
                (Type.GetTypeFromProgID("XTango_GV.Comprobantes"));

            bool resultado = false;
            object reporte = null;

            if (contado) {
                resultado = xComprobantes.Add_FacturaContado(tangoLogOn, data.rsFacEncabezado as object, data.rsFacRenglones as object, data.rsFacImpuestos as object, data.rsFonEncabezado as object, data.rsFonRenglones as object, defectos, ref reporte);
            }
            else {
                resultado = xComprobantes.Add_FacturaCtaCorriente(tangoLogOn, data.rsFacEncabezado as object, data.rsFacRenglones as object, data.rsFacImpuestos as object, data.rsFacCuotas as object, defectos, reporte);
            }
            // if (!resultado) { throw new XTangoException("Fallo al agregar facturas"); }

            adoReporte = (ADODB.Recordset)reporte;
            return resultado;
        }
    }        

}
