using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Clases;
using WinAppGym;

namespace Class

{
    public class ClsMenu
    {
        public MenuStrip mnuMenuUsuario;
        public string TablaUsu;
        public static string SQL;
        private static int VGTipo = 1;
        public static void OpcionesMenuWin(string vbaseConfig, int vTipo, string vUsusario,ref Form FrmPrincipal)
        {
            try
            {
                StringBuilder sSQL = new StringBuilder();
                DataTable dt = new DataTable();
                sSQL.Append("select a.menucodigo, a.menudescripcion, a.menuforms,MenuVisible from si_menu a left JOIN  si_menuusuarios B ");
                sSQL.Append(" ON a.tipodesistema=b.tipodesistema AND a.MenuCodigo=b.MENuCODIGO ");
                sSQL.Append(" WHERE a.tipodesistema=" + vTipo + " AND Isnull(b.usuariocodigo,'" + vUsusario + "') ='" + vUsusario + "' AND a.MenuVisible=1");

                dt = ClsFunc.ConsultarTabla(Convert.ToString(sSQL), ClsInterface.VgCnxSql);

                // instanciar el menú
                MenuStrip mnuMenuUsuario = new MenuStrip();

                // recorrer las filas e ir creando la estructura de menú

                if (dt.Rows.Count > 0)
                {
                    StringBuilder sSQL1 = new StringBuilder();
                    sSQL1.Append(" Len(menucodigo) =2 ");
                    DataRow[] DrFilas = null;
                    DrFilas = dt.Select(Convert.ToString(sSQL1), "menucodigo");

                    foreach (DataRow dr in DrFilas)
                    {
                        ToolStripMenuItem xMenuItem = new ToolStripMenuItem();
                        xMenuItem.Name = Convert.ToString(dr["menucodigo"]);
                        xMenuItem.Text = Convert.ToString(dr["menudescripcion"]);
                        xMenuItem.Tag = dr["menuForms"];

                        // añadir este menú desplegable a la barra de menú
                        mnuMenuUsuario.Items.Add(xMenuItem);

                        // recorrer si hubiera las opciones dependientes de este menú
                        CrearSubopcionesWin(xMenuItem, dt, ref WinAppGym.MDIPrincipal);

                    }
                }

                // añadir el menú al formulario
                FrmPrincipal.Controls.Add(mnuMenuUsuario);
                FrmPrincipal.ShowDialog();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public static void CrearTablaMenu(ref Form Menu, Form FrmPrincipal)
        {
            DataTable rsaux = default(DataTable);
           int I = 0;
            //*------------------------------------------------------------------*
            ClsFunc.GrabarTabla("DELETE  From si_menu where tipodesistema=" + 1 + "", ClsInterface.VgCnxSql);

            try
            {
                // recorrer las opciones del menú
                foreach (ToolStripMenuItem xOpcion in FrmPrincipal.Menu.MenuItems)
                {
                    //....
                    // si esta opción despliega un submenú
                    // llamar a un método para hacer cambios
                    // en las opciones del submenú
                    I = I + 2;
                      //           objbe.MenuDescripcion = xOpcion.Text
                    //           objbe.menuCodEdit = RTrim(xOpcion.Name)
                     //          objbe.MenuNivel = 1
                    SQL = "SELECT * FROM si_menu WHERE tipodesistema=" + 1 + "  AND menucodigo='" + Strings.Format(I, "00") + "'";
                    rsaux = ClsFunc.ConsultarTabla(SQL, ClsInterface.VgCnxSql);
                    if (rsaux.Rows.Count == 0)
                    {
              //          Objbl.GrabarProc(VGBase, 1, ClsFuncGym.VGCnxSql, objbe);
                    }
                    else
                    {
               //         Objbl.GrabarProc(VGBase, 2, ClsFuncGym.VGCnxSql, objbe);
                    }
                    if (xOpcion.DropDownItems.Count > 0)
                    {
                        string Opcion = Strings.Format(I, "00");
                        MuestraOpciones(xOpcion.DropDownItems, ref Opcion);
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public static void MuestraOpciones(ToolStripItemCollection menu, ref string ii)
        {
            int iii = 0;
            DataTable rsaux = default(DataTable);
            try
            {
                foreach (ToolStripItem item in menu)
                {
                    iii = iii + 2;
                    //           objbe.MenuDescripcion = item.Text
                    //            objbe.menuCodEdit = RTrim(item.Name)
                    //             objbe.MenuNivel = Len(ii + Format(iii, "00")) / 2
                    SQL = "SELECT * FROM si_menu WHERE tipodesistema=" + VGTipo + "  AND menucodigo='" + ii + Strings.Format(iii, "00") + "'";
                    rsaux = ClsFunc.ConsultarTabla(SQL,ClsInterface.VgCnxSql);
                    if (rsaux.Rows.Count == 0)
                    {
       //                 ObjBL.GrabarProc(VGBase, 1, VGCnxSql, objbe);
                    }
                    else
                    {
        //                ObjBL.GrabarProc(VGBase, 2, VGCnxSql, objbe);
                    }
                    //....
                    // si esta opción a su vez despliega un nuevo submenú
                    //  llamar recursivamente a este método para cambiar sus opciones

                    if (((ToolStripMenuItem)item).DropDownItems.Count > 0)
                    {
                        String Opcion = ii + Strings.Format(iii, "00");
                        MuestraOpciones(((ToolStripMenuItem)item).DropDownItems, ref Opcion);
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void CrearSubopcionesWin(ToolStripMenuItem mnuOpcion, DataTable dt, ref Form FrmPrincipal)
        {
            try
            {
                ToolStripMenuItem mnuSubOpcion = default(ToolStripMenuItem);

                string sSQLExpresion = null;
                sSQLExpresion = "SUBSTRING(menucodigo, 1," + mnuOpcion.Name.Length + ") = '" + mnuOpcion.Name + "' ";
                sSQLExpresion += "AND LEN(menucodigo) = " + (Convert.ToInt32(mnuOpcion.Name.Length) + 2);

                DataRow[] aDrFilas = null;
                aDrFilas = dt.Select(sSQLExpresion, "menucodigo");

                foreach (DataRow drFila in aDrFilas)
                {
                    // mnuSubOpcion = new ToolStripMenuItem(drFila["menudescripcion"]);
                    mnuSubOpcion.Name = Convert.ToString(drFila["menucodigo"]);
                    mnuSubOpcion.Text = Convert.ToString(drFila["menudescripcion"]);
                    mnuSubOpcion.Tag = drFila["Menuforms"];
             
                    mnuOpcion.DropDownItems.Add(mnuSubOpcion);

                    // llamar recursivamente a este método
                    // por si a partir de esta subopción se desplegaran
                    // más opciones
                    CrearSubopcionesWin(mnuSubOpcion, dt, ref FrmPrincipal);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public static  Form FormPorNombre(string pNombreForm,string espacio)
        {
            try
            {
                Assembly asm = Assembly.GetEntryAssembly();
                Type formtype = asm.GetType(string.Format("{0}.{1}", espacio, pNombreForm));
                Form f = (Form)Activator.CreateInstance(formtype);
                if ((formtype != null))
                {
                    return (Form)Activator.CreateInstance(formtype);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}