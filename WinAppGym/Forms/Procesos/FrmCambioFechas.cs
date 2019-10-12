using Clases;
using Class;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;
using WinAppReports.Reports;

namespace WinAppGym.Forms
{
    public partial class FrmCambioFechas : Form
    {
        private Int32 vUserId;
        private Int32 vMembId;
        private int vDias;
        private DateTime vInicio;
        private DateTime vTermino;
        private byte[] imagen;

        public FrmCambioFechas()
        {
            InitializeComponent();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BntGrabar.Visible = true;
            if (ClsFunc.EsNumero(TxtBuscar.Text, 0))
            {
                using (Model1 bd = new Model1())

                {
                    var Result = (from dd in bd.USERINFO
                                  where dd.Badgenumber.StartsWith(TxtBuscar.Text)
                                  select new
                                  {
                                      dd.USERID,
                                      dd.Badgenumber,
                                      dd.Name,
                                      dd.lastname,
                                      dd.acc_startdate,
                                      dd.acc_enddate,
                                      dd.PHOTO
                                  });

                    DgvSocios.DataSource = Result.ToList();
                }
            }
            else
            {
                if (!(TxtBuscar.Text == ""))
                {
                    using (Model1 bd = new Model1())
                    {
                        var Resultado = (from dd in bd.USERINFO
                                         where dd.lastname.Contains(TxtBuscar.Text)
                                         select new
                                         {
                                             dd.USERID,
                                             dd.Badgenumber,
                                             dd.Name,
                                             dd.lastname,
                                             dd.acc_startdate,
                                             dd.acc_enddate,
                                             dd.PHOTO
                                         });
                        DgvSocios.DataSource = Resultado.ToList();
                    }
                }
            }
        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntGrabar_Click(object sender, EventArgs e)
        {
            int vOk = 1;
            if (ClsFuncGym.ValidaCambioFechasMembresias(vUserId, vMembId, DtpInicio.Value))
            {
                MessageBox.Show("Fecha de Inicio membresia esta en rango de membresias activas , VERIFIQUE !!!! ");
                vOk = 0;
            }
            if (ctr_AyuAutorizacion.Codigo == "")
            {
                MessageBox.Show("Ingrese Codigo de autorizacion ");
                vOk = 0;
            }

            if (vOk == 1)
            {
                DateTime vfecha1 = DtpInicio.Value.Date;
                DateTime vfecha2 = DtpTermino.Value.Date;

                GrabaMembresia(ref vfecha1, ref vfecha2);
                using (Model1 bd = new Model1())
                {
                    var user1 = (from dd in bd.USERINFO
                                 where dd.USERID == (vUserId)
                                 select dd).FirstOrDefault();

                    vfecha1 = Convert.ToDateTime(user1.acc_startdate);
                    vfecha2 = Convert.ToDateTime(user1.acc_enddate);
                    if (ClsFuncGym.ActivarFechasSensor(1, vUserId, ref vfecha1, ref vfecha2))
                    {
                        user1.acc_startdate = Convert.ToDateTime(vfecha1);
                        user1.acc_enddate = Convert.ToDateTime(vfecha2); ;
                    }
                    BntGrabar.Visible = false;
                }
            }
        }

        private void GrabaMembresia(ref DateTime vfecha1, ref DateTime vfecha2)
        {
            using (Model1 bd = new Model1())
            {
                var user = (from dd in bd.Zk_MembresiasxSocio
                            where dd.ID == (vMembId)
                            select dd).FirstOrDefault();

                vfecha1 = Convert.ToDateTime(DtpInicio.Text);
                vfecha2 = Convert.ToDateTime(DtpTermino.Text);

                user.FechaInicio = vfecha1;
                user.FechaFinal = vfecha2;
                user.Referencia = TxtReferencia.Text;
                user.FechaModificacion = DateTime.Now.Date;
                user.AutorizacionesID = Convert.ToInt32(ctr_AyuAutorizacion.Codigo);

                bd.SaveChanges();
            }
        }

        private void DgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                vUserId = Convert.ToInt32(DgvSocios.CurrentRow.Cells["Id"].Value);
                vInicio = Convert.ToDateTime(DgvSocios.CurrentRow.Cells["FechaInicio"].Value);
                vTermino = Convert.ToDateTime(DgvSocios.CurrentRow.Cells["FechaTermino"].Value);

                var query = from MemSocio in bd.Zk_MembresiasxSocio
                            join Memb in bd.Zk_Membresias on MemSocio.MembresiasID equals Memb.ID
                            where MemSocio.UserInfoID == vUserId
                            orderby MemSocio.FechaFinal descending
                            select new
                            {
                                MemSocio.ID,
                                MemSocio.UserInfoID,
                                Memb.DescripcionMembresias,
                                MemSocio.FechaInicio,
                                MemSocio.FechaFinal
                            };

                DgvMembresias.DataSource = query.ToList();
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                pictFoto.Image = ClsFunc.ByteArrayToImage(imagen);
            }
        }

        private void DgvMembresias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                vMembId = Convert.ToInt32(DgvMembresias.CurrentRow.Cells["PagosID"].Value);
                var query = (from MemSocio in bd.Zk_MembresiasxSocio
                             where MemSocio.ID == vMembId
                             select new
                             {
                                 MemSocio.UserInfoID,
                                 MemSocio.FechaInicio,
                                 MemSocio.FechaFinal,
                                 MemSocio.fechaMaximadePago,
                                 MemSocio.Referencia
                             }).First();

                TimeSpan vDias1 = Convert.ToDateTime(query.FechaFinal) - Convert.ToDateTime(query.FechaInicio);
                vDias = vDias1.Days;
                DtpInicio.Value = Convert.ToDateTime(query.FechaInicio);
                DtpTermino.Value = Convert.ToDateTime(query.FechaFinal);
                TxtReferencia.Text = query.Referencia;
            }
        }

        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            DtpTermino.Value = DtpInicio.Value.Date.AddDays(vDias);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        private void ChkAutorizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutorizacion.Checked == true)
            {
                ctr_AyuAutorizacion.Visible = true;
            }
            else
            {
                ctr_AyuAutorizacion.Visible = false;
                ctr_AyuAutorizacion.Codigo = "0";
            }
        }

        private void FrmCambioFechas_Load(object sender, EventArgs e)
        {
            ctr_AyuAutorizacion.CadenaCone = ClsInterface.VgCnxSql;
        }

        private void BntImprimir_Click(object sender, EventArgs e)
        {
            FrmReports f = new FrmReports();
            Zk_Autorizado Cry = new Zk_Autorizado();

            try
            {
                //      Cry.DataSourceConnections("hp", "zkaccess", "sa", "12345");
                Cry.SetDatabaseLogon("sa", "12345");

                Cry.SetParameterValue("@base", "zkaccess");
                Cry.SetParameterValue("@ID", vMembId);

                f.crystalReportViewer1.ReportSource = Cry;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}