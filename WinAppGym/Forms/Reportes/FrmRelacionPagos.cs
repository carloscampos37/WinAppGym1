using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;
using WinAppReports;
using WinAppReports.Reports;


namespace WinAppGym.Forms
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

        private void BntImprimir_Click(object sender, EventArgs e)
        {
            Zk_liquidacionDiaria Cry = new Zk_liquidacionDiaria();
            FrmReports Frm = new FrmReports();

            try
            {
                // Cry.DataSourceConnections(0).SetConnection("counter","zkaccess","sa","12345");
                Cry.SetDatabaseLogon("sa", "12345");

                Cry.SetParameterValue("@base", "zkaccess");
                Cry.SetParameterValue("@empresa", "000");

                Cry.SetParameterValue("@FechaDesde", DtpDesde.Text);
                Cry.SetParameterValue("@FechaHasta", DtpHasta.Text);

                Frm.crystalReportViewer1.ReportSource = Cry;
                Frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}