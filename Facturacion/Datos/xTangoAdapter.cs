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

        private ADODB.Recordset _rsFacEncabezado;
        private ADODB.Recordset _rsFacRenglones = null;
        private ADODB.Recordset _rsFacImpuestos = null;
        private ADODB.Recordset _rsFacCuotas = null;
        private ADODB.Recordset _rsFonEncabezado = null;
        private ADODB.Recordset _rsFonRenglones = null;
        private DataTable _dtFacEncabezado;
        private DataTable _dtFacRenglones;
        private DataTable _dtFacImpuestos;
        private DataTable _dtFacCuotas;
        private DataTable _dtFonEncabezado;
        private DataTable _dtFonRenglones;

        public ADODB.Recordset rsFacEncabezado
        {
            get { return _rsFacEncabezado; }
            set
            {
                _rsFacEncabezado = value;
                _dtFacEncabezado = Commons.ADODB_a_ADO(_rsFacEncabezado);
            }
        }

        public ADODB.Recordset rsFacRenglones
        {
            get { return _rsFacRenglones; }
            set
            {
                _rsFacRenglones = value;
                _dtFacRenglones = Commons.ADODB_a_ADO(_rsFacRenglones); 
            }
        }
        public ADODB.Recordset rsFacImpuestos
        {
            get { return _rsFacImpuestos; }
            set
            {
                _rsFacImpuestos = value;
                _dtFacImpuestos = Commons.ADODB_a_ADO(_rsFacImpuestos);

            }
        }
        public ADODB.Recordset rsFacCuotas
        {
            get { return _rsFacCuotas; }
            set
            {
                _rsFacCuotas = value;
                _dtFacCuotas = Commons.ADODB_a_ADO(_rsFacCuotas);
            }
        }
        public ADODB.Recordset rsFonEncabezado
        {
            get { return _rsFonEncabezado; }
            set
            {
                _rsFonEncabezado = value;
                _dtFonEncabezado = Commons.ADODB_a_ADO(_rsFonEncabezado);
            }
        }
        public ADODB.Recordset rsFonRenglones
        {
            get
            {
                return _rsFonRenglones;
            }
            set
            {
                _rsFonRenglones = value;
                _dtFonRenglones = Commons.ADODB_a_ADO(_rsFonRenglones);
            }
        }

        public DataTable dtFacEncabezado
        {
            get { return _dtFacEncabezado; }
            set
            {
                _dtFacEncabezado = value;
                Commons.Update_ADODB_from_ADO(_dtFacEncabezado, ref _rsFacEncabezado);
            }
        }
        public DataTable dtFacRenglones
        {
            get { return _dtFacRenglones; }
            set
            {
                _dtFacRenglones = value;
                Commons.Update_ADODB_from_ADO(_dtFacRenglones, ref _rsFacRenglones);
            }
        }
        public DataTable dtFacImpuestos
        {
            get { return _dtFacImpuestos; }
            set
            {
                _dtFacImpuestos = value;
                Commons.Update_ADODB_from_ADO(_dtFacImpuestos, ref _rsFacImpuestos);
            }
        }
        public DataTable dtFacCuotas
        {
            get { return _dtFacCuotas; }
            set
            {
                _dtFacCuotas = value;
                Commons.Update_ADODB_from_ADO(_dtFacCuotas, ref _rsFacCuotas);
            }
        }
        public DataTable dtFonEncabezado
        {
            get { return _dtFonEncabezado; }
            set
            {
                _dtFonEncabezado = value;
                Commons.Update_ADODB_from_ADO(_dtFonEncabezado, ref _rsFonEncabezado);
            }
        }
        public DataTable dtFonRenglones
        {
            get { return _dtFonRenglones; }
            set
            {
                _dtFonRenglones = value;
                Commons.Update_ADODB_from_ADO(_dtFonRenglones, ref _rsFonRenglones);
            }
        }
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
