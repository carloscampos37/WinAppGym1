using Class;
using System;
using System.Windows.Forms;

namespace WinAppGym
{
    public partial class MDIPrincipal : Form
    {
        private string espacio = "";

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void OpcionMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = ClsMenu.FormPorNombre(ToolStripMenuItem).Tag, espacio);
                try
                {
                    if (form != null)
                        form.Show();
                    else
                        throw new Exception("Esta opción de Menú no tiene asignado o no esta creado su Formulario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}