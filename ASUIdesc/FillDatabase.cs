using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASUIdesc
{
    class FillDatabase
    {
        private string path;
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        string excelConnectionString;

        virtual public void FillData(string path)
        {
        this.path = path;
        string extension = System.IO.Path.GetExtension(path);
        switch (extension)
        {
            case ".xls":
                excelConnectionString = string.Format(Excel03ConString, path, "YES");
                break;
            case ".xlsx":
                excelConnectionString = string.Format(Excel07ConString, path, "YES");
                break;
        }

            // Create Connection to Excel Workbook
            using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
            {
                connection.Open();

                DataTable dbSchema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dbSchema == null || dbSchema.Rows.Count < 1)
                {
                    throw new Exception("Error: Could not determine the name of the first worksheet.");
                }
                string firstSheetName = dbSchema.Rows[0]["TABLE_NAME"].ToString();

                OleDbCommand command = new OleDbCommand("Select * FROM [" + firstSheetName + "]", connection);

             
                // Create DbDataReader to Data Worksheet
                using (DbDataReader dr = command.ExecuteReader())
                {
                    // SQL Server Connection String
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\tim\documents\visual studio 2013\Projects\ASUIdesc\ASUIdesc\Database.mdf;Integrated Security=True");


                    // Bulk Copy to SQL Server
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                    {
                        con.Open();
                        // Первый столбец xls файла во второй таблицы SQL Server и так далее.
                        // Нумерация начинается с нуля.
                        bulkCopy.ColumnMappings.Add(0, 1);
                        bulkCopy.ColumnMappings.Add(1, 2);
                        bulkCopy.ColumnMappings.Add(2, 3);
                        bulkCopy.ColumnMappings.Add(3, 4);
                        bulkCopy.ColumnMappings.Add(4, 5);
                        bulkCopy.ColumnMappings.Add(5, 6);
                        bulkCopy.ColumnMappings.Add(6, 7);
                        bulkCopy.ColumnMappings.Add(7, 8);
                        bulkCopy.ColumnMappings.Add(8, 9);
                        bulkCopy.ColumnMappings.Add(9, 10);
                        bulkCopy.ColumnMappings.Add(10, 11);
                        bulkCopy.ColumnMappings.Add(11, 12);
                        bulkCopy.ColumnMappings.Add(12, 13);
                        bulkCopy.ColumnMappings.Add(13, 14);
                        bulkCopy.ColumnMappings.Add(14, 15);
                        bulkCopy.ColumnMappings.Add(15, 16);
                        bulkCopy.ColumnMappings.Add(16, 17);
                        bulkCopy.ColumnMappings.Add(17, 18);
                        bulkCopy.ColumnMappings.Add(18, 19);
                        bulkCopy.ColumnMappings.Add(19, 20);
                        bulkCopy.ColumnMappings.Add(20, 21);
                        bulkCopy.ColumnMappings.Add(21, 22);
                        bulkCopy.ColumnMappings.Add(22, 23);
                        bulkCopy.ColumnMappings.Add(23, 24);
                        bulkCopy.ColumnMappings.Add(24, 25);
                        bulkCopy.ColumnMappings.Add(25, 26);
                        bulkCopy.ColumnMappings.Add(26, 27);
                        bulkCopy.ColumnMappings.Add(27, 28);
                        bulkCopy.ColumnMappings.Add(28, 29);
                        bulkCopy.ColumnMappings.Add(29, 30);
                        bulkCopy.ColumnMappings.Add(30, 31);
                        bulkCopy.ColumnMappings.Add(31, 32);
                        bulkCopy.ColumnMappings.Add(32, 33);
                        bulkCopy.ColumnMappings.Add(33, 34);
                        bulkCopy.ColumnMappings.Add(34, 35);
                        bulkCopy.ColumnMappings.Add(35, 36);
                        bulkCopy.ColumnMappings.Add(36, 37);
                        bulkCopy.ColumnMappings.Add(37, 38);
                        bulkCopy.ColumnMappings.Add(38, 39);
                        bulkCopy.ColumnMappings.Add(39, 40);
                        bulkCopy.ColumnMappings.Add(40, 41);
                        bulkCopy.ColumnMappings.Add(41, 42);
                        bulkCopy.ColumnMappings.Add(42, 43);
                        bulkCopy.ColumnMappings.Add(43, 44);
                        bulkCopy.ColumnMappings.Add(44, 45);
                        bulkCopy.ColumnMappings.Add(45, 46);
                        bulkCopy.ColumnMappings.Add(46, 47);
                        bulkCopy.ColumnMappings.Add(47, 48);
                        bulkCopy.ColumnMappings.Add(48, 49);
                        bulkCopy.ColumnMappings.Add(49, 50);
                        bulkCopy.ColumnMappings.Add(50, 51);
                        bulkCopy.ColumnMappings.Add(51, 52);
                        bulkCopy.ColumnMappings.Add(52, 53);
                        bulkCopy.ColumnMappings.Add(53, 54);
                        bulkCopy.ColumnMappings.Add(54, 55);
                        bulkCopy.ColumnMappings.Add(55, 56);
                        bulkCopy.ColumnMappings.Add(56, 57);
                        bulkCopy.ColumnMappings.Add(57, 58);
                        bulkCopy.ColumnMappings.Add(58, 59);
                        bulkCopy.ColumnMappings.Add(59, 60);
                        bulkCopy.ColumnMappings.Add(60, 61);
                        bulkCopy.ColumnMappings.Add(61, 62);
                        bulkCopy.ColumnMappings.Add(62, 63);
                        bulkCopy.ColumnMappings.Add(63, 64);
                        bulkCopy.ColumnMappings.Add(64, 65);
                        bulkCopy.ColumnMappings.Add(65, 66);
                        bulkCopy.ColumnMappings.Add(66, 67);
                        bulkCopy.ColumnMappings.Add(67, 68);
                        bulkCopy.ColumnMappings.Add(68, 69);
                        bulkCopy.ColumnMappings.Add(69, 70);
                        bulkCopy.ColumnMappings.Add(70, 71);
                        bulkCopy.ColumnMappings.Add(71, 72);
                        bulkCopy.ColumnMappings.Add(72, 73);
                        bulkCopy.ColumnMappings.Add(73, 74);
                        bulkCopy.ColumnMappings.Add(74, 75);
                        bulkCopy.ColumnMappings.Add(75, 76);
                        bulkCopy.ColumnMappings.Add(76, 77);
                        bulkCopy.ColumnMappings.Add(77, 78);
                        bulkCopy.DestinationTableName = "ppr";
                        bulkCopy.WriteToServer(dr);

                        MessageBox.Show("ППР успешно загружен");
                    }
                    dr.Close();
                    dr.Dispose();
                    //displayIncidents();
                } 
               
            }

        }
    }
}
