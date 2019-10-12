using System;
using System.Windows.Forms;
using WinAppReports;
using WinAppReports.Reports;

namespace WinAppGym.Forms.Reportes
{
    public partial class FrmMembresiasporfechas : Form
    {
        public FrmMembresiasporfechas()
        {
            InitializeComponent();
        }

        private void BntImprimir_Click(object sender, EventArgs e)
        {
            if (ValidaFechas())
            {
                Imprimir();
             }
        }
        private Boolean ValidaFechas()
        {
            Boolean vRetorno;
            vRetorno = false;
            if (rdbxvencer.Checked == true)
            {
                if (DtpDesde.Value < DateTime.Now.Date)
                {
                    MessageBox.Show(" Error en Fecha de Inicio, debe ser mayor o igual a fecha del dia ");
                    return vRetorno;
                }

                if (DtpDesde.Value >= DtpHasta.Value)
                {
                    MessageBox.Show(" Error en fechas");
                    return vRetorno;
                }
            }
            if (rdbVencidas.Checked == true)
            {
                if (DtpHasta.Value.Date  > DateTime.Now.Date )
                {
                    MessageBox.Show(" Error en fechas, fecha fina menor a fecha inicial ");
                    return vRetorno;
                }
                      if (DtpDesde.Value >= DtpHasta.Value)
                {
                    MessageBox.Show(" Error en fechas");
                    return vRetorno;
                }
            }
            return true;

        }

        private void Imprimir()
        {
            Zk_MembresiasxfechaFinal Cry = new Zk_MembresiasxfechaFinal();
            FrmReports Frm = new FrmReports();

            try
            {
                int vRenova;
                
                // Cry.DataSourceConnections(1).SetConnection("counter","zkaccess","sa","12345");
                Cry.SetDatabaseLogon("sa", "12345");

                Cry.SetParameterValue("@base", "zkaccess");
                Cry.SetParameterValue("@Fechainicio", DtpDesde.Text);
                Cry.SetParameterValue("@Fechafinal", DtpHasta.Text);
                Cry.SetParameterValue("@Renova", ChkRenova.Checked);

                Frm.crystalReportViewer1.ReportSource = Cry;
                Frm.Show();
            }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
            }
            }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

