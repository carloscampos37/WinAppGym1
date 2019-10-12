using Officce;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;

namespace WinAppGym
{
    public partial class FrmImportarExcel : Form
    {
        private DataTable Dt;

        public FrmImportarExcel()
        {
            InitializeComponent();
        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntImportar_Click(object sender, EventArgs e)
        {
            Dt = ClsOfficce.ImportarExcel("data");
            dataGridView1.DataSource = Dt;
        }

        private void FrmImportarExcel_Load(object sender, EventArgs e)
        {
        }

        private void BntGrabar_Click(object sender, EventArgs e)
        {
            DateTime vfecha = Convert.ToDateTime(Dt.Rows[0][0]);
            DateTime vfecha1 = vfecha.Date;
            using (Model1 bd = new Model1())
            {
                var resultado = (from dd in bd.Zk_Asistencia
                                 where dd.FechaAsistencia == vfecha1
                                 select dd);
                int vReg = 0;
                foreach (var d1 in resultado)
                {
                    vReg = 1;
                    break;
                }
                if (vReg == 1)
                {
                    MessageBox.Show(" fecha ya fue registrada");
                    BntEliminar.Visible = true;
                    BntImportar.Visible = false;
                    BntGrabar.Visible = false;
                }
            }
            for (int ii = 0; ii < Dt.Rows.Count; ii++)
            {
                if (Convert.ToString(Dt.Rows[ii][1]) != "")
                {
                    using (Model1 bd1 = new Model1())
                    {
                        string vCod = Convert.ToString(Dt.Rows[ii][1]);
                        Int32 vId;
                        using (Model1 bd2 = new Model1())
                        {
                            var user = (from user1 in bd2.USERINFO
                                        where user1.Badgenumber == vCod
                                        select user1).FirstOrDefault();
                            vId = user.USERID;
                        }
                        Zk_Asistencia asistencia = new Zk_Asistencia();
                        asistencia.FechaAsistencia = Convert.ToDateTime(Dt.Rows[ii][0]);
                        asistencia.UserInfoID = vId;

                        bd1.Zk_Asistencia.Add(asistencia);

                        bd1.SaveChanges();
                    }
                    //   Zk_MembresiasxSocio membsocio = new Zk_MembresiasxSocio();
                }
            }
        }
    }
}