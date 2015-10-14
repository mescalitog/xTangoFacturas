using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.IO;

using Facturacion.Datos;
using Facturacion.Excepciones;
using Facturacion.Presentacion;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        #region constants
        private const string mainpath = @".\Estructuras\";
        private const string STR_FacEnc = "FacEnc_Str.xml";
        private const string STR_FacRen = "FacRen_Str.xml";
        private const string STR_FacImp = "FacImp_Str.xml";
        private const string STR_FacCuo = "FacCuo_Str.xml";
        private const string STR_FonEnc = "FonEnc_Str.xml";
        private const string STR_FonRen = "FonRen_Str.xml";

        private const string DEF_FacEnc = "FacEnc.xml";
        private const string DEF_FacRen = "FacRen.xml";
        private const string DEF_FacImp = "FacImp.xml";
        private const string DEF_FacCuo = "FacCuo.xml";
        private const string DEF_FonEnc = "FonEnc.xml";
        private const string DEF_FonRen = "FonRen.xml";
        private const string DEF_Result = "Result.xml";
        #endregion
        #region privates
        xTangoComprobantes xComprobantes = null;
        xTangoFacturaData facturaData = null;
        bool dataTouched = false;

        /// <summary>
        /// Inicializacion de la aplicacion
        /// </summary>
        private void initApp()
        {
            panelFacturas.Enabled = false;
            //Crea el path a las estructuras
            (new FileInfo(mainpath)).Directory.Create();
        }
        /// <summary>
        /// Asigna los datatable a las grillas
        /// </summary>
        private void fillDataGrids()
        {
            DGrFacEnc.ADODBDataSource = facturaData.rsFacEncabezado;
            DGrFacRen.ADODBDataSource = facturaData.rsFacRenglones;
            DGrFacImp.ADODBDataSource = facturaData.rsFacImpuestos;
            DGrFacCuo.ADODBDataSource = facturaData.rsFacCuotas;
            DGrFonEnc.ADODBDataSource = facturaData.rsFonEncabezado;
            DGrFonRen.ADODBDataSource = facturaData.rsFonRenglones;
        }

        /// <summary>
        /// Cambia el estado de los controles y carga o crea las estructuras
        /// </summary>
        private void changeStates()
        {

            panelFacturas.Enabled = !panelFacturas.Enabled;
            if (panelFacturas.Enabled)
            {
                if (!loadEstructuras())
                {
                    makeEstructuras();
                    saveEstructuras();
                    SSTabFacturas.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Autentica en Tango
        /// Crea xComprobantes si no existe
        /// </summary>
        private void logueoATango() {

            if (xComprobantes == null) { 
                xComprobantes = new xTangoComprobantes();
            };

            if (xComprobantes.tangoLogOn != null) {
                xComprobantes.TangoLogoff();
                changeStates();
            }
            try {

                xComprobantes.TangoLogin(TxtKeyNumber.Text, TxtUser.Text, TxtPswd.Text, TxtCompany.Text);
                changeStates();
                }
            catch (XTangoException ex) {
                MessageBox.Show("Ocurrio el error: " + ex.Message, "Facturacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }    
        }

        /// <summary>
        /// Crea las estructuras
        /// </summary>
        private void makeEstructuras() {
            try
            {
                xComprobantes.makeEstructuras(out facturaData);
                fillDataGrids();
            }
            catch (XTangoException ex)
            {
                MessageBox.Show("Ocurrio el error: " + ex.Message + "\n\r al generar las estructuras", "Facturacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally {
            }  
        }

        /// <summary>
        /// Carga datos por default
        /// </summary>
        private void loadDatos()
        {
            facturaData = new xTangoFacturaData();
            facturaData.rsFacEncabezado = Commons.loadADORecordset(mainpath + DEF_FacEnc);
            facturaData.rsFacRenglones = Commons.loadADORecordset(mainpath + DEF_FacRen);
            facturaData.rsFacImpuestos = Commons.loadADORecordset(mainpath + DEF_FacImp);
            facturaData.rsFacCuotas = Commons.loadADORecordset(mainpath + DEF_FacCuo);
            facturaData.rsFonEncabezado = Commons.loadADORecordset(mainpath + DEF_FonEnc);
            facturaData.rsFonRenglones = Commons.loadADORecordset(mainpath + DEF_FonRen);
            dataTouched = false;
            fillDataGrids();
            SSTabFacturas.SelectedIndex = 0;
        }

        /// <summary>
        /// Graba los datos por default a archivos xml.
        /// </summary>
        private void saveDatos()
        {
            if (dataTouched)
            {
                facturaData.rsFacEncabezado = DGrFacEnc.ADODBDataSource;
                facturaData.rsFacRenglones = DGrFacRen.ADODBDataSource;
                facturaData.rsFacImpuestos = DGrFacImp.ADODBDataSource;
                facturaData.rsFacCuotas = DGrFacCuo.ADODBDataSource;
                facturaData.rsFonEncabezado = DGrFonEnc.ADODBDataSource;
                facturaData.rsFonRenglones = DGrFonRen.ADODBDataSource;
            }
            try
            {
                Commons.saveADORecordset(facturaData.rsFacEncabezado, mainpath + DEF_FacEnc);
                Commons.saveADORecordset(facturaData.rsFacRenglones, mainpath + DEF_FacRen);
                Commons.saveADORecordset(facturaData.rsFacImpuestos, mainpath + DEF_FacImp);
                Commons.saveADORecordset(facturaData.rsFacCuotas, mainpath + DEF_FacCuo);
                Commons.saveADORecordset(facturaData.rsFonEncabezado, mainpath + DEF_FonEnc);
                Commons.saveADORecordset(facturaData.rsFonRenglones, mainpath + DEF_FonRen);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error: " + ex.Message + " al grabar estructuras", "Facturacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        /// <summary>
        /// Graba las estructuras en archivos xml
        /// </summary>
        private void saveEstructuras()
        {
            try
            {
                Commons.saveADORecordset(facturaData.rsFacEncabezado, mainpath + STR_FacEnc);
                Commons.saveADORecordset(facturaData.rsFacRenglones, mainpath + STR_FacRen);
                Commons.saveADORecordset(facturaData.rsFacImpuestos, mainpath + STR_FacImp);
                Commons.saveADORecordset(facturaData.rsFacCuotas, mainpath + STR_FacCuo);
                Commons.saveADORecordset(facturaData.rsFonEncabezado, mainpath + STR_FonEnc);
                Commons.saveADORecordset(facturaData.rsFonRenglones, mainpath + STR_FonRen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el error: " + ex.Message + " al grabar estructuras", "Facturacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        /// <summary>
        /// Carga las estructuras desde archivos xml
        /// </summary>
        /// <returns>true si las estructuras se cargaron correctamente</returns>
        private bool loadEstructuras()
        {
            facturaData = new xTangoFacturaData();
            bool resultado = false;
            try
            {

                facturaData.rsFacEncabezado = Commons.loadADORecordset(mainpath + STR_FacEnc);
                facturaData.rsFacRenglones = Commons.loadADORecordset(mainpath + STR_FacRen);
                facturaData.rsFacImpuestos = Commons.loadADORecordset(mainpath + STR_FacImp);
                facturaData.rsFacCuotas = Commons.loadADORecordset(mainpath + STR_FacCuo);
                facturaData.rsFonEncabezado = Commons.loadADORecordset(mainpath + STR_FonEnc);
                facturaData.rsFonRenglones = Commons.loadADORecordset(mainpath + STR_FonRen);

                fillDataGrids();
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                SSTabFacturas.SelectedIndex = 0;
            }
            return resultado;
        }

        /// <summary>
        /// Agrega las facturas 
        /// </summary>
        /// <param name="Defectos">Toma los valores por default del cliente</param>
        /// <param name="Contado">La factura es una factura de contado</param>
        private bool Add_Facturas(bool Defectos, bool Contado) {
            bool r = false;
            try
            {
                if (dataTouched)
                {
                    facturaData.rsFacEncabezado = DGrFacEnc.ADODBDataSource;
                    facturaData.rsFacRenglones = DGrFacRen.ADODBDataSource;
                    facturaData.rsFacImpuestos = DGrFacImp.ADODBDataSource;
                    facturaData.rsFacCuotas = DGrFacCuo.ADODBDataSource;
                    facturaData.rsFonEncabezado = DGrFonEnc.ADODBDataSource;
                    facturaData.rsFonRenglones = DGrFonRen.ADODBDataSource;
                }

                ADODB.Recordset report = null;
                r = xComprobantes.addFacturas(Defectos, Contado, facturaData, out report);

                if (report != null)
                {
                    DGrResult.DataSource = Commons.ADODB_a_ADO(report);
                }
            }
            finally
            { }
            return r;
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }


        private void CmdLogueo_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                logueoATango();
            }
            finally {
                Cursor.Current = currentCursor;
            }
        }

        private void CmdLoadData_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                loadDatos();
            }
            finally
            {
                Cursor.Current = currentCursor;
            } 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initApp();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (xComprobantes != null) {
                xComprobantes.TangoLogoff();
                xComprobantes = null;
            }
            Close();
        }

        private void CmdIngFacturas_Click_1(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                bool r = Add_Facturas(ChkDefectos.Checked, ChkContado.Checked);
                if (!r)
                {
                    MessageBox.Show("Los comprobantes NO se agregaron", "Facturacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                SSTabFacturas.SelectedIndex = 6;
            }
            finally
            {
                Cursor.Current = currentCursor;
            }
        }

        private void CmdSaveData_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                saveDatos();
            }
            finally
            {
                Cursor.Current = currentCursor;
            }
        }

        private void CmdMake_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                makeEstructuras();
                SSTabFacturas.SelectedIndex = 0;
            }
            finally {
                Cursor.Current = currentCursor;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGrResult.RowCount == 0)
            {
                MessageBox.Show("Exportacion de Resultados \n\r no hay resultados para exportar", "Facturacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                SSTabFacturas.SelectedIndex = 6;
            }
            else { 
                DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog and get result.
                if (result == DialogResult.OK) // Test result.
                {
                    Commons.saveDataTable(DGrResult.DataSource as DataTable, saveFileDialog1.FileName.ToString());
                }

            }

        }

        private void DataChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataTouched = true;
        }
        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new fAbout().ShowDialog();            
        }


    }
}
