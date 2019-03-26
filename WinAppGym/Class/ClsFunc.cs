using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections;
using System.Net;
using System.Web;
using System.Collections.Generic;
using Clases;


namespace Clases
{
    public class ClsFuncNet
    {
        #region Variables

       private CookieContainer miCookie = new CookieContainer();

        #endregion variables

        #region Combo

        public static void CargaCombo(ref System.Windows.Forms.ComboBox xcombo, string ncadena)
        {
            xcombo.Items.Clear();
            DataTable Dtx;
            Dtx = ClsFuncGym.ConsultarTabla(ncadena, ClsFuncGym.VGCnxSql);
            if (Dtx.Rows.Count > 0)
            {
                int loopTo = xcombo.Items.Count - 1;
                for (int j = 0; j <= loopTo; j++)
                {
                    xcombo.Items.Add(Dtx.Rows[j][0] + "-" + Dtx.Rows[j][1]);
                }
                xcombo.SelectedIndex = 0;
            }
        }
        public static string BuscaCombo(ComboBox xcombo, string xcampo)
        {
            string functionReturnValue = null;
            int J = 0; string xbusca = null;
            int vNp;

            for (J = 0; J <= xcombo.Items.Count - 1; J++)
            {
                xcombo.SelectedIndex = J;
                vNp = xcombo.Text.IndexOf("-");
                if (vNp > 0)
                {
                    xbusca = ClsFuncNet.Izquierda(xcombo.Text, vNp);
                }
                else
                {
                    xbusca = xcombo.Text;
                }

                if (xcampo == xbusca)
                {
                    functionReturnValue = xcombo.Text;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            return functionReturnValue;
        }
        public static string ObtenerDatoCombo(string Txt)
        {
            string Obtener = "";
            int k;
            k = Strings.InStr(Txt, "-");
            if (k > 1)
                Obtener = Strings.RTrim(Strings.Left(Txt, k - 1));

            return Obtener;
        }

        #endregion Combo

        #region Cadenas

        public static string Escadena(object pdato)
        {
            string cadena;
            if (Information.IsDBNull(pdato))
                cadena = "";
            else
                cadena = Strings.Trim(pdato.ToString());

            return cadena;
        }
        public static double NumeroEntero(string Number)
        {
            Int32 Numero;
            if (Information.IsDBNull(Number) | Strings.Len(Strings.Trim(Number)) == 0)
                Numero = 0;
            else
                // UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Number. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Numero = Convert.ToInt16(Number);

            return Numero;
        }
        public static string DesMes(string nMes)
        {
            string DescriMes = "";
            switch (nMes)
            {
                case "01":
                    DescriMes = "ENERO";
                    break;

                case "02":
                    DescriMes = "FEBRERO";
                    break;

                case "03":
                    DescriMes = "MARZO";
                    break;

                case "04":
                    DescriMes = "ABRIL";
                    break;

                case "05":
                    DescriMes = "MAYO";
                    break;

                case "06":
                    DescriMes = "JUNIO";
                    break;

                case "07":
                    DescriMes = "JULIO";
                    break;

                case "08":
                    DescriMes = "AGOSTO";
                    break;

                case "09":
                    DescriMes = "SETIEMBRE";
                    break;

                case "10":
                    DescriMes = "OCTUBRE";
                    break;

                case "11":
                    DescriMes = "NOVIEMBRE";
                    break;

                case "12":
                    DescriMes = "DICIEMBRE";
                    break;
            }

            return DescriMes;
        }
        public string Left(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(0, caracteres);
        }

        public static string Right(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(Dato.Length - caracteres, caracteres);
        }
        public static string Derecha(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(Dato.Length - caracteres, caracteres);
        }
        public static string Izquierda(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(0, caracteres);
        }
        public static bool EsNumero(string dato, int valor)
        {
            if (!int.TryParse(dato, out valor))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static object EsNulo(object EXPRESION, object valor)
        {
            object functionReturnValue = null;

            if (Convert.ToString(EXPRESION) == null)
            {
                functionReturnValue = valor;
            }
            else
            {
                functionReturnValue = EXPRESION;
            }
            functionReturnValue = valor;
            return functionReturnValue;
        }

        #endregion cadenas

        #region Data
        public DataTable FiltrarDataTable(DataTable poDataTable, string psFiltro, string psOrder = "")
        {
            DataRow[] loRows;
            DataTable loNuevoDataTable = new DataTable();
            try
            {
                loNuevoDataTable = poDataTable.Clone();
                if (psOrder == "")
                {
                    loRows = poDataTable.Select(psFiltro);
                }
                else
                {
                    loRows = poDataTable.Select(psFiltro, psOrder);
                }
                foreach (DataRow ldrRow in loRows)
                {
                    loNuevoDataTable.ImportRow(ldrRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return loNuevoDataTable;
        }

        public DataTable ConsultarTabla(string vSQL, string vCadConex, int vCommandTimeOut = 800)
        {
            string cError = "";
            try
            {
                string strConn = "";
                strConn = vCadConex;
                SqlConnection oConn = new SqlConnection(vCadConex);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(vSQL, oConn);
                da.Fill(dt1);
                oConn.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return null;
            }
        }

        public bool GrabarTabla(string vSQL, string vCadConex)
        {
            string cError = "";
            try
            {
                SqlConnection oConn = new SqlConnection(vCadConex);
                SqlCommand da = new SqlCommand(vSQL, oConn);
                oConn.Open();
                da.ExecuteNonQuery();
                oConn.Close();
                da = null;
                return true;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return false;
            }
        }

        #endregion Data
        public string ComputerName(int tipo = 0)
        {
            string functionReturnValue = null;

            if (tipo == 0)
            {
                Random r = new Random();
                functionReturnValue = "##" + System.Environment.MachineName + r.Next(1, 1000).ToString();
            }
            else
            {
                functionReturnValue = "##" + System.Environment.MachineName;
            }
            return functionReturnValue;
        }
        public string CreacionDirectorio(string Cadena1, string cadena2)
        {
            string Cadena = Path.Combine(Cadena1, $"{cadena2}");

            if (!(Directory.Exists(Cadena)))
            {
                // Try to create the directory.
                Directory.CreateDirectory(Cadena);
            }
            return Cadena;
        }

        #region Imagenes
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch

            {
                return null;
            }
        }

        public static byte[] ImageTobyteArray(Image ImageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ImageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);

            // Don't need to use the constructor that takes the starting offset and length
            // as we're using the whole byte array.
            MemoryStream ms = new MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);

            return image;
        }

        #endregion Imagenes
        public static void ActivaTab(int Pos, int Nro, ref TabControl vControl, int NroExcepto = 99)
        {
            int J;
            for (J = 1; J <= Nro; J++)
            {
                if (J != NroExcepto)
                    vControl.TabPages[J - 1].Enabled = false;
            }
            vControl.TabPages[Pos - 1].Enabled = true;
            J = Pos - 1;
            vControl.SelectedIndex = J;
        }
        public enum ResultadoConsulta
        {
            ConsultaSatisfactoria = 1,
            ErrorDeCaptcha = 2,
            DniNoEncontrado = 3,
            Otro = 4
        }
        public bool ValidaCodigo(DataTable dt, string Valor, string campo = "")
        {
            bool Valida = false;
            try
            {
                var loopTo = dt.Rows.Count - 1;
                for (int i = 0; i <= loopTo; i++)
                {
                    if ((Valor) == Strings.Trim(dt.Rows[i]["" + campo + ""].ToString()))
                    {
                        Valida = true;

                    }
                    else
                    {
                        Valida = false;
                    }
                }
            }
            catch
            {
                Valida = false;
            }

            return Valida;
        }
        public string BuscaPrefijo(string xTexto)
        {
            string BuscaPre;
            int J;
            J = Strings.InStr(xTexto, "-");
            if (J > 1)
                BuscaPre = Strings.Trim(Izquierda(xTexto, J - 1));
            else
                BuscaPre = Strings.Trim(xTexto) + " ";

            return BuscaPre;
        }
       public string SupCadSQL(string s)
        {
            string Aux = "";
            if (!Information.IsDBNull(s))
                Aux = Strings.Replace(s, "'", "''");
            return Aux;
        }
         // función que desencripta una cadena
       public string Numero(object Number)
        {
            double aValor;
            if (Information.IsDBNull(Number) | Strings.Len(Strings.Trim(Number.ToString())) == 0)
                aValor = 0;
            else if (Information.IsNumeric(Number))
                aValor = Conversion.Val(Number);
            else
                aValor = Conversion.Val(Number.ToString());
            return Strings.Format(aValor, "####,###.00");
        }
       public DateTime Fecha(short tipo, DateTime dato, string formato = "/")
        {
            DateTime fecha1;
            DateTime Fecha;
            fecha1 = Convert.ToDateTime("01" + formato + Strings.Format(dato.Month, "00") + formato + dato.Year);
            switch (tipo)
            {
                case 1:
                    {
                        Fecha = fecha1;
                        break;
                    }

                case 2:
                    {
                        fecha1 = System.DateTime.FromOADate(fecha1.ToOADate() + 31);
                        fecha1 = Convert.ToDateTime("01" + formato + Strings.Format(fecha1.Month , "00") + formato + fecha1.Year);
                        Fecha = System.DateTime.FromOADate(fecha1.ToOADate() - 1);
                        break;
                    }

                case 3:
                    {
                        fecha1 = System.DateTime.FromOADate(fecha1.ToOADate() - 27);
                        Fecha = Convert.ToDateTime("01" + formato + Strings.Format(fecha1.Month, "00") + formato + fecha1.Year);
                        break;
                    }

                default:
                    {
                        Fecha =Convert.ToDateTime(Strings.Format(dato.Day, "00") + formato + Strings.Format(fecha1.Month , "00") + formato + fecha1.Year);
                        break;
                    }
            }
            return Convert.ToDateTime(Fecha);
        }
        public string EsNumero(object Number, int dato)
        {
            double aValor;
            if (Information.IsDBNull(Number) | Strings.Len(Strings.Trim(Number.ToString())) == 0)
                aValor = dato;
            else if (Information.IsNumeric(Number))
                aValor = Conversion.Val(Number);
            else
                aValor = Conversion.Val(Number.ToString());
            return Strings.Format(aValor, "####,###.00");
        }

    }
}
