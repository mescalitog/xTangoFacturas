using ADODB;
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

namespace Facturacion
{
    public partial class ADODBDataGridView : System.Windows.Forms.DataGridView
    {
        #region privates
        ADODB.Recordset _adoRs;
        private DataTable ADODBRecordset_to_ADODataTable(ADODB.Recordset adoRs)
        {
            string tableName = "adoTable";
            try
            {
                tableName = adoRs.Properties["Unique Table"].Value.ToString();
            }
            catch
            {
                // No existe el nombre de la tabla. 
            }
            tableName = (tableName == "") ? "adoTable" : tableName;
            ADODB.Recordset dummyrs = adoRs.Clone(ADODB.LockTypeEnum.adLockReadOnly);
            OleDbDataAdapter myDA = new OleDbDataAdapter();
            DataSet myDS = new DataSet();
            myDA.Fill(myDS, dummyrs, tableName);
            dummyrs = null;
            return myDS.Tables[0];
        }

        private void UpdateADODBRecordset_from_ADODataTable(DataTable inTable, ref ADODB.Recordset adoRs)
        {
            ADODB.Fields adoFields = adoRs.Fields;
            System.Data.DataColumnCollection inColumns = inTable.Columns;
            //Delete
            if (adoRs.RecordCount > 0) { 
                adoRs.MoveFirst(); 
            }
            while (!adoRs.EOF)
            {
                adoRs.Delete();
                adoRs.MoveNext();

            }
            //Add
            foreach (DataRow dr in inTable.Rows)
            {
                // Proceso las que no estan borradas
                if (dr.RowState != DataRowState.Deleted)
                {
                    adoRs.AddNew(System.Reflection.Missing.Value,
                                    System.Reflection.Missing.Value);

                    for (int columnIndex = 0; columnIndex < inColumns.Count; columnIndex++)
                    {
                        adoFields[columnIndex].Value = dr[columnIndex];
                    }
                }
            }
        }

        #endregion
        public ADODBDataGridView()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        // Region Properties
        /// <summary>
        /// DatasSource como ADODB.Recordset
        /// </summary>
        public ADODB.Recordset ADODBDataSource
        {
            get
            {
                if (_adoRs != null)
                {
                    DataTable dt = (DataTable)this.DataSource;
                    UpdateADODBRecordset_from_ADODataTable(dt, ref _adoRs);
                    return _adoRs;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._adoRs = value;
                if (this._adoRs != null)
                {
                    this.DataSource = ADODBRecordset_to_ADODataTable(this._adoRs);
                }
            }
        }
    }
}
