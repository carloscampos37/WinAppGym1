using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGym.Models;

namespace AppGym.Forms
{
    public partial class FrmRelacionPagos : Form
    {
        public FrmRelacionPagos()
        {
            InitializeComponent();
        }

        private void FrmRelacionPagos_Load(object sender, EventArgs e)
        {
            DtpDesde.Value = Convert.ToDateTime(DateTime.Now);
            DtpHasta.Text = DtpDesde.Text;
        }

        private void BntModificar_Click(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                DateTime vfecha = Convert.ToDateTime(DtpDesde.Text);
                var query = (from pagosocio in bd.Zk_PagosSocios
                             join membxSocio in bd.Zk_MembresiasxSocio on pagosocio.MembresiasxSocioID equals membxSocio.ID
                             join memb in bd.Zk_Membresias on membxSocio.MembresiasID equals memb.ID
                             join user in bd.USERINFO on membxSocio.UserInfoID equals user.USERID
                             where pagosocio.FechaPago == vfecha
                             select new
                             {
                                 user.lastname,
                                 user.Name,
                                 pagosocio.FechaPago,
                                 memb.DescripcionMembresias,
                                 membxSocio.Precio,
                                 membxSocio.descuento,
                                 pagosocio.ImportePagado
                             }
                             );

                DgvConsulta.DataSource = query.ToList();
                TxtPagado.Text = Convert.ToString(query.Sum(x => x.ImportePagado));
            }
        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}