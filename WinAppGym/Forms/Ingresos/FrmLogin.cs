using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Clases;


namespace WinAppGym.Forms
{
    public partial class FrmLogin : Form
    {
  
        private int clave;
        public string VgCnxSql;
        string espacio = "";

        public FrmLogin()
        {
            InitializeComponent();
        }
        public void LlenarListaEmpresas()
        {
            DataTable REG1;
            string espacio = "";
            REG1 = ClsFuncGym.ConsultarTabla("Select * from co_multiempresas where empresacodigo<>'00'", ClsFuncGym.VGCnxSql);
            CmbEmpresas.Items.Clear();
            var loopTo = REG1.Rows.Count - 1;
            for (int I = 0; I <= loopTo; I++)
                CmbEmpresas.Items.Add(REG1.Rows[I]["empresacodigo"].ToString() + " " + REG1.Rows[I]["empresadescripcion"].ToString());
            CmbEmpresas.SelectedIndex = 0;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {

                if (CmbGrupo.Items.Count > 0)
                    CmbGrupo.SelectedIndex = 0;
                clave = 1;
                DTPfecha1.Value = DateTime.Today;

                string VGTipo = null;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void TsbAceptar_Click(object sender, EventArgs e)
        {
            DataTable Dtx = new DataTable();

            if (Strings.Len(Strings.Trim(txtUserName.Text)) == 0)
            {
                Interaction.MsgBox("Usuario no valido. Vuelva a intentarlo", MsgBoxStyle.Information, "Inicio de sesión");
                txtUserName.Focus();
                return;
            }

            if (Strings.Len(Strings.Trim(txtPassword.Text)) == 0)
            {
                Interaction.MsgBox("Contraseña no valida. Vuelva a intentarlo", MsgBoxStyle.Information, "Inicio de sesión");
                txtPassword.Focus();
                return;
            }
            if (DTPfecha1.Value > DateTime.Today)
            {
                Interaction.MsgBox("Fecha mayor al del sistema ", MsgBoxStyle.Information, "Inicio de sesión");
                return;
            }

            if (clave < 4)
            {
                int VGTipo = 1;
                // Clsmenu.CrearTablaMenu(MDIContab)
                ClsMenuNet.OpcionesMenuWin(VgCnxSql, VGTipo, ClsFuncGym.VGUsuarioCodigo, ref MDIPrincipal);

                ClsMenuNet.FormPorNombre("MDIPrincipal",espacio);
                this.Close();
            }
        }

    }
}