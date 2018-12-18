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

namespace WinAppGym1
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
    }
}
