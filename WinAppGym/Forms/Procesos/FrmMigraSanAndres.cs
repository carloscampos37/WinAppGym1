using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;

namespace WinAppGym.Forms
{
    public partial class FrmMigraSanAndres : Form
    {
        private string Sql;
        private String VGAccess = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\\\PRINCIPAL\\campos\\Buensoft Socios\\LOCATIONS\\gimnasio top power.loc\\Gimnasio Top power.bdb; User Id=admin;Password=;";

        //      String VGAccess = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\\\Principal\\c\\TEMP\\Buensoft Socios 2009 Backup 2-14-2019  2038.bdb.db;User Id=admin;Password=;";
        private String VGConfigSql = "server=(local);Initial Catalog=ZKAccess;User ID=sa;Password=12345";

        private DataTable Dt = new DataTable();

        public FrmMigraSanAndres()
        {
            InitializeComponent();
        }

        private void ChkSocios_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSocios.Checked == true)
            {
                Sql = "Select * from tblMemberAccounts";
                DgvSocios.DataSource = ConsultarDatos(VGAccess, Sql);
            }
        }

        private DataTable ConsultarDatos(string cadenaConexion, string Datos)
        {
            String cError = "";
            try
            {
                OleDbConnection cnn = new OleDbConnection(cadenaConexion);

                //abro la conexion

                DataTable dt1 = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(Datos, cnn);
                da.Fill(dt1);
                cnn.Open();
                return dt1;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                MessageBox.Show(cError);
                return null;
            }
        }

        private void GrabarDatos(String CadenaConexion, String Datos)
        {
            try
            {
                SqlConnection oConn = new SqlConnection(CadenaConexion);
                SqlCommand da = new SqlCommand(Datos, oConn);
                oConn.Open();
                da.ExecuteNonQuery();
                oConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BntIniciar_Click(object sender, EventArgs e)
        {
            if (ChkSocios.Checked == true)
            {
                InicializaSocios();
            }
            if (ChkMembresias.Checked == true)
            {
                InicializaMembresias();
            }
        }

        private void ActualizaSocios(int i)
        {
            using (Model1 bd = new Model1())
            {
                USERINFO user = new USERINFO();

                user.Badgenumber = Convert.ToString(Dt.Rows[i]["pkMemberID"]);
                user.Name = Convert.ToString(Dt.Rows[i]["tName"]);
                user.lastname = Convert.ToString(Dt.Rows[i]["tLastname"]) + " " + Convert.ToString(Dt.Rows[i]["tLastname2"]);
                //      user.BIRTHDAY = Convert.ToDateTime(Dt.Rows[i]["dBirthdate"]);
                user.email = Convert.ToString(Dt.Rows[i]["temail"]);
                user.Gender = Convert.ToString(Dt.Rows[i]["tgender"]);
                user.OPHONE = Convert.ToString(Dt.Rows[i]["tCellPhone"]);
                //   user.PHOTO = ClsFunc.ImageTobyteArray(PicDetalle.Image);

                user.DEFAULTDEPTID = 2;
                user.ATT = 1;
                user.INLATE = 1;
                user.OUTEARLY = 1;
                user.OVERTIME = 1;
                user.SEP = 1;
                user.HOLIDAY = 1;
                user.privilege = 0;
                user.AutoSchPlan = 1;
                user.MinAutoSchInterval = 24;
                user.RegisterOT = 1;
                user.status = 0;

                bd.USERINFO.Add(user);
                bd.SaveChanges();

                var Resultado = (from dd in bd.Zk_Correlativos
                                 select dd).First();

                int vCodId = Convert.ToInt32(Resultado.codId);
                Resultado.codId += 1;
                Resultado.Codigo += 1;
                bd.SaveChanges();

                acc_levelset_emp level = new acc_levelset_emp();
                level.employee_id = vCodId;
                level.acclevelset_id = 1;

                bd.acc_levelset_emp.Add(level);
                bd.SaveChanges();
            }
        }

        private void FrmMigraSanAndres_Load(object sender, EventArgs e)
        {
        }

        private void ChkMembresias_CheckedChanged(object sender, EventArgs e)
        {
            Sql = "Select * from tblMemberships";
            DgvSocios.DataSource = ConsultarDatos(VGAccess, Sql);
        }

        private void InicializaSocios()
        {
            if (ChkMembresias.Checked == true)
            {
                Sql = "DBCC CHECKIDENT(USERINFO, RESEED, 0)";
                GrabarDatos(VGConfigSql, Sql);
                Sql = "delete userinfo";
                GrabarDatos(VGConfigSql, Sql);
            }
            Sql = "Select * from tblMemberAccounts where pkmemberId>'10000' ";
            Dt = ConsultarDatos(VGAccess, Sql);

            for (int i3 = 0; i3 <= Dt.Rows.Count - 1; i3++)
            {
                ActualizaSocios(i3);
            }
        }

        private void InicializaMembresias()
        {
            if (ChkMembresias.Checked == true)
            {
                Sql = "DBCC CHECKIDENT(tblMemberships, RESEED, 0)";
                GrabarDatos(VGConfigSql, Sql);
                Sql = "delete tblMemberships";
                GrabarDatos(VGConfigSql, Sql);
            }

            Sql = "Select * from tblMemberships";
            Dt = ConsultarDatos(VGAccess, Sql);
            for (int i3 = 0; i3 <= Dt.Rows.Count - 1; i3++)
            {
                ActualizaMembresias(i3);
            }
        }

        private void ActualizaMembresias(int i)
        {
            using (Model1 bd = new Model1())
            {
                Zk_Membresias user = new Zk_Membresias();

                user.DescripcionMembresias = Convert.ToString(Dt.Rows[i]["pkMemberID"]);

                bd.Zk_Membresias.Add(user);
                bd.SaveChanges();
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ChkMembActivas_CheckedChanged(object sender, EventArgs e)
        {
            Sql = "Select * from tblMemberMemberships";
            DgvSocios.DataSource = ConsultarDatos(VGAccess, Sql);
        }
    }
}