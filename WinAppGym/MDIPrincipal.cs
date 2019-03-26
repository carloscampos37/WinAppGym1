using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppGym;
using WinAppGym.Forms;

namespace WinAppGym
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void tABLASToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void iNFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios frm = new FrmSocios();
            frm.Show();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mEMBRESIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresias frm = new FrmMembresias();
            frm.Show();
        }

        private void relacionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelacionPagos frm = new FrmRelacionPagos();
            frm.Show();
        }

        private void pERIODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos Frm = new FrmPeriodos();
            Frm.Show();
        }

        private void pROCESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void migracionSanAndresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMigraSanAndres Frm = new FrmMigraSanAndres();
            Frm.Show();
        }

        private void pruebasMembresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjusteMolinete Frm = new FrmAjusteMolinete();
            Frm.Show();
        }  

        private void huellasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioFechas Frm = new FrmCambioFechas();
            Frm.Show();
        }

    }
}