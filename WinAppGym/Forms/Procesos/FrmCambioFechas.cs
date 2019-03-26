using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppGym.Models;

namespace WinAppGym.Forms
{
    public partial class FrmCambioFechas : Form
    {
 
        private Int32 vUserId;
        private DateTime vInicio;
        private DateTime vTermino;
        private byte[] imagen;
        public FrmCambioFechas()
        {
            InitializeComponent();
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (ClsFuncNet.EsNumero(TxtBuscar.Text, 0))
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
           if(ClsFuncGym.ActivarFechasSensor(1,vUserId, ref vInicio,ref vTermino))
           {
                using (Model1 bd = new Model1())
                {
                    var user = (from dd in bd.USERINFO 
                                where dd.USERID == (vUserId)
                                select dd).FirstOrDefault ();

                    user.acc_startdate = vInicio;
                    user.acc_enddate = vTermino;
                    bd.SaveChanges();

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
                vInicio= Convert.ToDateTime(DgvSocios.CurrentRow.Cells["FechaInicio"].Value);
                vTermino= Convert.ToDateTime(DgvSocios.CurrentRow.Cells["FechaTermino"].Value);

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
                pictFoto.Image = ClsFuncNet.byteArrayToImage(imagen);
            }
        }
    }
}
