using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Facturacion.Datos
{
    public static class Commons
    {
        public static DataTable ADODB_a_ADO(ADODB.Recordset adoRs)
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

        public static void Update_ADODB_from_ADO(DataTable inTable, ref ADODB.Recordset adoRs)
        {
            // ADODB.Recordset result = adoRs.Clone(ADODB.LockTypeEnum.adLockOptimistic);
            ADODB.Fields adoFields = adoRs.Fields;
            System.Data.DataColumnCollection inColumns = inTable.Columns;
            //Delete
            adoRs.MoveFirst();
            while (!adoRs.EOF)
            {
                adoRs.Delete();
                adoRs.MoveNext();

            }
            //Add
            foreach (DataRow dr in inTable.Rows)
            {
                adoRs.AddNew(System.Reflection.Missing.Value,
                                System.Reflection.Missing.Value);

                for (int columnIndex = 0; columnIndex < inColumns.Count; columnIndex++)
                {
                    adoFields[columnIndex].Value = dr[columnIndex];
                }
            }
        }
        public static void saveADORecordset(object record, string filepath)
        {
            File.Delete(filepath);
            ((ADODB.Recordset)record).Save(filepath, ADODB.PersistFormatEnum.adPersistXML);
        }
        public static ADODB.Recordset loadADORecordset(string filepath)
        {
            ADODB.Recordset record = new ADODB.Recordset();
            const int adCmdFile = 256;
            ((ADODB.Recordset)record).Open(filepath, "Provider=MSPersist;", ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, adCmdFile);
            return record;
        }
        public static void saveDataTable(DataTable data, string filePath)
        {
            // Create the FileStream to write with.
            System.IO.FileStream myFileStream = new System.IO.FileStream
               (filePath, System.IO.FileMode.Create);
            // Create an XmlTextWriter with the fileStream.
            System.Xml.XmlTextWriter myXmlWriter =
               new System.Xml.XmlTextWriter(myFileStream, System.Text.Encoding.Unicode);
            // Write to the file with the WriteXml method.
            try
            {
                data.WriteXml(myXmlWriter);
            }
            finally
            {
                myXmlWriter.Close();
            }
        }

        private static ADODB.DataTypeEnum TranslateType(Type columnType)
        {
            switch (columnType.UnderlyingSystemType.ToString())
            {
                case "System.Boolean":
                    return ADODB.DataTypeEnum.adBoolean;

                case "System.Byte":
                    return ADODB.DataTypeEnum.adUnsignedTinyInt;

                case "System.Char":
                    return ADODB.DataTypeEnum.adChar;

                case "System.DateTime":
                    return ADODB.DataTypeEnum.adDate;

                case "System.Decimal":
                    return ADODB.DataTypeEnum.adCurrency;

                case "System.Double":
                    return ADODB.DataTypeEnum.adDouble;

                case "System.Int16":
                    return ADODB.DataTypeEnum.adSmallInt;

                case "System.Int32":
                    return ADODB.DataTypeEnum.adInteger;

                case "System.Int64":
                    return ADODB.DataTypeEnum.adBigInt;

                case "System.SByte":
                    return ADODB.DataTypeEnum.adTinyInt;

                case "System.Single":
                    return ADODB.DataTypeEnum.adSingle;

                case "System.UInt16":
                    return ADODB.DataTypeEnum.adUnsignedSmallInt;

                case "System.UInt32":
                    return ADODB.DataTypeEnum.adUnsignedInt;

                case "System.UInt64":
                    return ADODB.DataTypeEnum.adUnsignedBigInt;

                case "System.String":
                default:
                    return ADODB.DataTypeEnum.adVarChar;
            }
        }
    }
}
