using Clases;
using Class;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;

namespace WinAppGym.Forms
{
    public partial class FrmMembresias : Form
    {
        private int vUserId;
        private bool vAdiciona;

        public FrmMembresias()
        {
            InitializeComponent();
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            ctr_AyuPeriodos.CadenaCone = ClsInterface.VgCnxSql;
            using (Model1 bd = new Model1())

            {
                var Resultado = (from dd in bd.Zk_Membresias
                                 join per in bd.Zk_Periodos on dd.PeriodosID equals per.ID
                                 select new
                                 {
                                     dd.ID,
                                     dd.DescripcionMembresias,
                                     dd.PeriodosID,
                                     per.DescripcionPeriodo,
                                     dd.InicioVigencia,
                                     dd.TerminoVigencia,
                                     dd.MembresiaGrupo,
                                     dd.Precio
                                 }
                                 );

                DgvConsulta.DataSource = Resultado.ToList();
            }
            ActivaBotones(true, true, true, false, false, true, true);
        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntModificar_Click(object sender, EventArgs e)
        {
            if (DgvConsulta.RowCount == 0)
            {
                MessageBox.Show(" No existe datos a modificar");
                return;
            }
            if (vUserId == 0)
            {
                MessageBox.Show(" Dar ckick en tabla de Membresias para modificar");
                return;
            }
            using (Model1 bd = new Model1())
            {
                var Resultado = (from dd in bd.Zk_Membresias
                                 where dd.ID == (vUserId)
                                 select dd).First();
                TxtDescripcion.Text = Resultado.DescripcionMembresias;
                TxtId.Text = Convert.ToString(Resultado.ID);
                DtpInicio.Value = Convert.ToDateTime(ClsFunc.EsNulo(Resultado.InicioVigencia, "01-01-1900"));
                Dtptermino.Value = Convert.ToDateTime(ClsFunc.EsNulo(Resultado.TerminoVigencia, "01-01-1900"));
                TxtNroSocios.Text = Convert.ToString(Resultado.CantidaddeSocios);
                TxtPrecio.Text = Convert.ToString(Resultado.Precio);
                ChkLimitado.Checked = Convert.ToBoolean(Resultado.Ilimitado);
                ChkGrupal.Checked = Convert.ToBoolean(Resultado.MembresiaGrupo);
                ChkEstado.Checked = Convert.ToBoolean(Resultado.EstadoAnulado); ;
                ctr_AyuPeriodos.Codigo = Convert.ToString(Resultado.PeriodosID);
                ctr_AyuPeriodos.EjecAyuda();
            }

            ClsFunc.ActivaTab(2, 2, ref tabControl1);

            vAdiciona = false;

            ActivaBotones(false, false, false, true, true, false, false);
        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                vUserId = Convert.ToInt32(DgvConsulta.CurrentRow.Cells["Id"].Value);
            }
        }

        private void BntAdicionar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = "";
            TxtNroSocios.Text = "1";
            TxtPrecio.Text = "0";
            ChkLimitado.Checked = false;
            ChkGrupal.Checked = false;
            ChkEstado.Checked = false;
            DtpInicio.Value = Convert.ToDateTime("01-01-1900");
            Dtptermino.Value = Convert.ToDateTime("01-01-1900");
            vAdiciona = true;
            ClsFunc.ActivaTab(2, 2, ref tabControl1);

            ActivaBotones(false, false, false, true, true, false, false);
        }

        private void BntGrabar_Click(object sender, EventArgs e)
        {
            if (vAdiciona == true)
            {
                GrabaAdiciona();
            }
            else
            {
                GrabaModifica();
            }

            ClsFunc.ActivaTab(1, 2, ref tabControl1);

            ActivaBotones(true, true, true, false, false, true, true);
        }

        private void GrabaAdiciona()
        {
            using (Model1 bd = new Model1())
            {
                Zk_Membresias dd = new Zk_Membresias();

                dd.DescripcionMembresias = TxtDescripcion.Text;
                dd.Ilimitado = ChkLimitado.Checked;
                dd.MembresiaGrupo = ChkGrupal.Checked;
                dd.EstadoAnulado = ChkEstado.Checked;
                dd.InicioVigencia = Convert.ToDateTime(DtpInicio.Text);
                dd.TerminoVigencia = Convert.ToDateTime(Dtptermino.Text);
                dd.PeriodosID = Convert.ToInt32(ctr_AyuPeriodos.Codigo);
                dd.Precio = Convert.ToInt32(TxtPrecio.Text);

                bd.Zk_Membresias.Add(dd);
                bd.SaveChanges();
            }
        }

        private void GrabaModifica()
        {
            using (Model1 bd = new Model1())
            {
                var dd = (from d in bd.Zk_Membresias
                          where d.ID == (vUserId)
                          select d).First();

                dd.DescripcionMembresias = TxtDescripcion.Text;
                dd.Ilimitado = ChkLimitado.Checked;
                dd.MembresiaGrupo = ChkGrupal.Checked;
                dd.EstadoAnulado = ChkEstado.Checked;
                dd.InicioVigencia = Convert.ToDateTime(DtpInicio.Text);
                dd.TerminoVigencia = Convert.ToDateTime(Dtptermino.Text);
                dd.PeriodosID = Convert.ToInt32(ctr_AyuPeriodos.Codigo);
                dd.Precio = Convert.ToInt32(TxtPrecio.Text);
                bd.SaveChanges();
            }
        }

        private void ActivaBotones(bool adicionar, bool modificar, bool anular, bool guardar, bool cancelar, bool imprimir, bool salir)
        {
            BntAdicionar.Visible = adicionar;
            BntModificar.Visible = modificar;
            BntAnular.Visible = anular;
            BntGrabar.Visible = guardar;
            BntCancelar.Visible = cancelar;
            BntImprimir.Visible = imprimir;
            BntSalir.Visible = salir;
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            ClsFunc.ActivaTab(1, 2, ref tabControl1);
            ActivaBotones(true, true, true, false, false, true, true);
        }
    }
}