using Clases;
using System;
using System.Windows.Forms;
using WinAppGym.Forms;
using WinAppGym.Forms.Reportes;

namespace WinAppGym
{
    public partial class MDIPrincipal1 : Form
    {
        public MDIPrincipal1()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            ClsFuncGym.ActualizaSensor();
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();
        }

         private void INFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios frm = new FrmSocios();
            frm.Show();
        }

        private void SALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MEMBRESIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresias frm = new FrmMembresias();
            frm.Show();
        }

        private void RelacionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelacionPagos frm = new FrmRelacionPagos();
            frm.Show();
        }

        private void PERIODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos Frm = new FrmPeriodos();
            Frm.Show();
        }

        private void PROCESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MigracionSanAndresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMigraSanAndres Frm = new FrmMigraSanAndres();
            Frm.Show();
        }

        private void PruebasMembresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjusteMolinete Frm = new FrmAjusteMolinete();
            Frm.Show();
        }

        private void HuellasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioFechas Frm = new FrmCambioFechas();
            Frm.Show();
        }

        private void ImportarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportarExcel Frm = new FrmImportarExcel();
            Frm.Show();
        }

        private void MembresiasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresiasporfechas frm = new FrmMembresiasporfechas();
            frm.Show();

        }
    }
}