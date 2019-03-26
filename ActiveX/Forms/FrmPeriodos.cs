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
    public partial class FrmPeriodos : Form
    {
        public FrmPeriodos()
        {
            InitializeComponent();
        }

        private void FrmPeriodos_Load(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())

            {
                var Resultado = (from dd in bd.Zk_Periodos
                                 select new
                                 {
                                     dd.ID,
                                     dd.DescripcionPeriodo,
                                     dd.Meses,
                                     dd.Dias,
                                     dd.EstadoAnulado
                                 }
                                 );

                DgvConsulta.DataSource = Resultado.ToList();
            }
            ActivaBotones(true, true, true, false, false, true, true);
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

        private void BntGrabar_Click(object sender, EventArgs e)
        {
        }
    }
}