using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Officce
{
   public class ClsOfficce
    {
        private static OleDbConnection conn;
        private static OleDbDataAdapter MyDataAdapter;
        private static DataTable dt1;

        public static DataTable ImportarExcel(String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.*";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt1 = new DataTable();
                MyDataAdapter.Fill(dt1);

                return dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt1 = null;
            }
        }

    }
}
