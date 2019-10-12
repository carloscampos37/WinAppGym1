using Clases;
using Class;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;

namespace WinAppGym.Forms
{
    public partial class FrmAjusteMolinete : Form
    {
        private Int32 vUserId;
        private DateTime vInicio;
        private DateTime vTermino;
        private byte[] imagen;

        public FrmAjusteMolinete()
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
            if (ClsFuncGym.ActivarFechasSensor(1, vUserId, ref vInicio, ref vTermino))
            {
                using (Model1 bd = new Model1())
                {
                    var user = (from dd in bd.USERINFO
                                where dd.USERID == (vUserId)
                                select dd).FirstOrDefault();

                    user.acc_startdate = vInicio;
                    user.acc_enddate = vTermino;
                    bd.SaveChanges();
                    BntGrabar.Visible = false;
                };
            }
        }

        private void FrmAjusteFechas_Load(object sender, EventArgs e)
        {
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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }
    }
}