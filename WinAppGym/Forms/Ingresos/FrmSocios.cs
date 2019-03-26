using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinAppGym.Models;
using AForge.Video;
using AForge.Video.DirectShow;
using libzkfpcsharp;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using WinAppGym.Properties;
using Clases;
using Sample;

namespace WinAppGym
{
    public partial class FrmSocios : Form
    {
        #region Variables Privadas

        private string VGCnxSql = Settings.Default.CadenaConexion; 
        private const int MESSAGE_CAPTURED_OK = 0x0400 + 6;
        private const int REGISTER_FINGER_COUNT = 3;
        private bool bIdentify = true;
        private bool bIsTimeToDie = false;
        private byte[] blob1;
        private byte[] CapTmp = new byte[2048];
        private int cbCapTmp = 2048;
        private int cbRegTmp = 0;
        private IntPtr FormHandle = IntPtr.Zero;
        private byte[] FPBuffer;
        private int iFid = 1;
        private byte[] imagen;
        private bool IsRegister = false;
        private IntPtr mDBHandle = IntPtr.Zero;
        private IntPtr mDevHandle = IntPtr.Zero;
        private int mfpDpi = 0;
        private int mfpHeight = 0;
        private int mfpWidth = 0;
        // variables de enrrolador
        private int RegisterCount = 0;

        private byte[] RegTmp = new byte[2048];
        private byte[][] RegTmps = new byte[3][];
        private int[] vActualiza;
        private bool vAdiciona;
        private int vCorrelativoGrupo;
        private int vCorrelativoId;
        private int vCorrelativoSocio;
        private int vHuellas;
        private int vNroHuella;
        private int vTipo;
        private int vUserId;
       [DllImport("user32.dll", EntryPoint = "SendMessageA")]
       public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        #endregion Variables Privadas

        #region constructor

        private FilterInfoCollection CaptureDevice;

        private VideoCaptureDevice FinalFrame;

        public FrmSocios()
        {
            InitializeComponent();
        }
        private void FrmSocios_Load(object sender, EventArgs e)
        {
            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Dispositivos tiene el array, con todos los dispositivos disponibles
            if (CaptureDevice.Count > 0)
            {
                foreach (FilterInfo x in CaptureDevice)
                {
                    CmbCamara.Items.Add(x.Name);
                }
                CmbCamara.SelectedIndex = 0;
            }

            FormHandle = this.Handle;
     
            CargarAyudas();
            CargarCombos();
            ActivaBotones(true, true, true, true, true, false, false, false, true);
        }

        #endregion constructor

        #region Botones

        private void BntAdicionar_Click(object sender, EventArgs e)
        {
            TxtNombres.Text = string.Empty;
            TxtApellidos.Text = string.Empty;
            DtpNacimiento.Value = DateTime.Now;
            DtpInicio.Value = Convert.ToDateTime("01-01-1900");
            DtpTermino.Value = Convert.ToDateTime("01-01-1900");
            TxtCelular.Text = string.Empty;
            PicDetalle.Image = null;
            InicializaVariables();
            ActivaBotones(false, false, false, false, false, true, true, false, false);

            using (Model1 bd = new Model1())
            {
                var ResultID = (from dd in bd.USERINFO
                                 orderby dd.USERID descending
                                 select dd).FirstOrDefault();

                vCorrelativoSocio = Convert.ToInt32(ResultID.USERID );

                var ResultCodigo = (from dd in bd.Zk_Correlativos
                              select dd).FirstOrDefault();


                TxtCodigo.Text = Convert.ToString(ResultCodigo.Codigo );
                vCorrelativoSocio = Convert.ToInt32(ResultID.USERID +1);
                vCorrelativoId = Convert.ToInt32(vCorrelativoSocio);
                TxtId.Text = Convert.ToString(vCorrelativoId);
            }

            vAdiciona = true;
            vTipo = 1;
            ClsFuncNet.ActivaTab(2, 5, ref TabSocios);
        }

        private void BntCamara_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[CmbCamara.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                BntFoto.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            if (BntCierra.Visible == true)
                zkfp2.Terminate();

            BntFoto.Visible = false;
            ClsFuncNet.ActivaTab(1, 5, ref TabSocios);
            ActivaBotones(true, true, true, true, true, false, false, false, true);
        }

        private void BntFoto_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
        }

        private void BntGrabar_Click(object sender, EventArgs e)
        {
            int vOk = 1;
            if (BntCierra.Visible == true)
            {
                Thread.Sleep(100);
                zkfp2.CloseDevice(mDevHandle);
                zkfp2.Terminate();
            }
            if (FinalFrame != null)
            {
                if (FinalFrame.IsRunning)
                    FinalFrame.Stop();
            }

            if (vTipo <= 2)
            {
                if (vAdiciona)
                {
                    GrabaAdiciona();
                }
                else
                {
                    GrabaModifica();
                }
                TxtBuscar_TextChanged(sender, e);

            }
            if (vTipo == 3)
            {
                if (ClsFuncGym.ValidaFechasMembresias(vUserId,DtpInicioMp.Value ))
                {
                    vOk = 0;
                    MessageBox.Show("Fecha de Inicio membresia esta en rango de membresias activas , VERIFIQUE !!!! ");
                }
                if (ChkPagototal.Checked != true)
                {
                    if (TxtACuentaMp.Text == "" || TxtACuentaMp.Text == "0")
                    {
                        MessageBox.Show(" Pago a cuenta con valor 0");
                        vOk = 0;
                    }
                }
                else
                {
                    if (!(TxtACuentaMp.Text == "0" || TxtACuentaMp.Text == ""))
                    {
                        MessageBox.Show(" Pago a cuenta con valor > 0 con Pago TOTAL");
                        vOk = 0;
                    }
                }
                if (vOk == 1)
                    GrabaMembP();
            }
            if (vTipo == 4)
            {
                GrabaMembG();
            }
            if (vTipo ==5)
            {
                if (Convert.ToDecimal(TxtSaldo.Text) < Convert.ToDecimal(TxtImporte.Text))
                {
                    MessageBox.Show(" Importe a pagar MAYOR a Saldo");
                    vOk = 0;
                }
                else
                {
                    if (TxtImporte.Text == "")
                        TxtImporte.Text = "0.00";

                    if (Convert.ToDecimal(TxtImporte.Text)==0)
                    {
                        MessageBox.Show(" Importe a pagar con valor CERO (0.00) ");
                        vOk = 0;
                    }
                    else
                    {
                        GrabaPagos();
                    }
                }

            }
            if (vOk == 1)
            {
                if (TxtDescuento.Text == "")
                    TxtDescuento.Text = "0";

                if (Convert.ToDecimal(TxtDescuento.Text) > 0)
                {
                    ActivaBotones(false, false, false, false, false, false, true, true, false);
               }
                else
                {
                    ClsFuncNet.ActivaTab(1, 5, ref TabSocios);
                    ActivaBotones(true, true, true, true, true, false, false, false, true);
                }
                if (vTipo == 1)
                {
                    TxtBuscar.Text = TxtCodigo.Text;
                }
                if (vTipo == 3)
                {
                    TxtBuscar.Text = LblCodigo.Text;
                }

                BntFoto.Visible = false;
                ChkHuellas.Checked = false;
            }
        }

        private void BntImagen_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[CmbCamara.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                BntFoto.Visible = true;

                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    string imagen = openFileDialog1.FileName;
                //    pictDetalle.Image = Image.FromFile(imagen);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BntImprimir_Click(object sender, EventArgs e)
        {
            ClsFuncNet.ActivaTab(1, 5, ref TabSocios);
            using (Model1 bd = new Model1())
            {
            }
        }

        private void BntInicializa_Click(object sender, EventArgs e)
        {
            try
            {
                bIdentify = true;
                InicializaSensor();
     
                BntActivar.Visible = true;
                BntCierra.Visible = true;
                BntCancelarH.Visible = true;
                BntInicializa.Visible = false;
            }
            catch
            {
            }
        }
        private void ActivaSensor()
        {
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("Enrrolador Fallo");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("Init DB fail");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            RegisterCount = 0;
            cbRegTmp = 0;
            iFid = 1;
            for (int i = 0; i < 3; i++)
            {
                RegTmps[i] = new byte[2048];
            }
            byte[] paramValue = new byte[4];
            int size = 4;
            zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

            size = 4;
            zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

            FPBuffer = new byte[mfpWidth * mfpHeight];

            size = 4;
            zkfp2.GetParameters(mDevHandle, 3, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpDpi);

            TxtHuella.Text = "reader parameter, image width:" + mfpWidth + ", height:" + mfpHeight + ", dpi:" + mfpDpi + " ";

            Thread captureThread = new Thread(new ThreadStart(DoCapture));
            captureThread.IsBackground = true;
            captureThread.Start();
            bIsTimeToDie = false;
            TxtHuella.Text = "";

       
        }
        private void BntMembGrupo_Click(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                vTipo = 4;
                ChkPagoTotalG.Checked = false;
                ctr_AyuMembGrupo.Filtro = " MembresiaGrupo=1 AND EstadoAnulado=0 ";
                ClsFuncNet.ActivaTab(4, 5, ref TabSocios);
                ActivaBotones(false, false, false, false, false, true, true, false, false);
            }
        }

        private void BntMembPersonal_Click(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                if(imagen !=null)
                pictPersonal.Image = ClsFuncNet.byteArrayToImage(imagen);

                LblCodigo.Text = DgvSocios.CurrentRow.Cells["Codigo"].Value.ToString();
                LblNombres.Text = DgvSocios.CurrentRow.Cells["Nombres"].Value.ToString();
                LblNombres.Text += " " + DgvSocios.CurrentRow.Cells["Apellidos"].Value.ToString();

                var query = from MemSocio in bd.Zk_MembresiasxSocio
                            join Memb in bd.Zk_Membresias on MemSocio.MembresiasID equals Memb.ID
                            where MemSocio.UserInfoID == (vUserId)
                            orderby MemSocio.FechaFinal descending
                            select new { MemSocio.UserInfoID, Memb.DescripcionMembresias, MemSocio.FechaInicio, MemSocio.FechaFinal };

                dgvMembPersonal.DataSource = query.ToList();
            }
            vTipo = 3;
            ChkPagototal.Checked = false;
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql;
            ctr_AyuMembPersonal.Filtro = " MembresiaGrupo=0 AND EstadoAnulado=0 ";
            ClsFuncNet.ActivaTab(3, 5, ref TabSocios);
            ActivaBotones(false, false, false, false, false, true, true, false, false);
        }

        private void BntModificar_Click_1(object sender, EventArgs e)
        {
            if (DgvSocios.RowCount == 0)
            {
                MessageBox.Show(" No existe datos a modificar");
                return;
            }
            else if (vUserId == 0)
            {
                MessageBox.Show(" Active socio a Modificar");
                return;
            }
            using (Model1 bd = new Model1())
            {
                var Resultado = (from dato in bd.USERINFO
                                 where dato.USERID == (vUserId)
                                 select dato).First();
                TxtApellidos.Text = Resultado.lastname;
                TxtNombres.Text = Resultado.Name;
                TxtId.Text = Convert.ToString(Resultado.USERID);
                TxtCodigo.Text = Convert.ToString(Resultado.Badgenumber);
                TxtCelular.Text = Resultado.OPHONE;
                TxtCorreo.Text = Resultado.email;
                ChkBaja.Checked = Convert.ToBoolean(Resultado.status);
                DtpBaja.Value = Convert.ToDateTime(ClsFuncNet.EsNulo(Resultado.delete_time, "01-01-1900"));
                DtpNacimiento.Value = Convert.ToDateTime(ClsFuncNet.EsNulo(Resultado.BIRTHDAY, "01-01-1900"));
                DtpInicio.Value = Convert.ToDateTime(ClsFuncNet.EsNulo(Resultado.acc_enddate, "01-01-1900"));
                DtpTermino.Value = Convert.ToDateTime(ClsFuncNet.EsNulo(Resultado.acc_enddate, "01-01-1900"));
                CmbGenero.Text =Convert.ToString( ClsFuncNet.BuscaCombo(CmbGenero, Resultado.Gender ));
                InicializaVariables();
            }

            ClsFuncNet.ActivaTab(2, 5, ref TabSocios);

            vAdiciona = false;
            ChkBaja.Visible = true;
            vTipo = 2;
            PicDetalle.Image = ClsFuncNet.byteArrayToImage(imagen);

            ActivaBotones(false, false, false, false, false, true, true, false, false);
        }

        private void BntPagos_Click(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                PicPagos.Image = ClsFuncNet.byteArrayToImage(imagen);

                LblCodigoP.Text = DgvSocios.CurrentRow.Cells["Codigo"].Value.ToString();
                LblNombresP.Text = DgvSocios.CurrentRow.Cells["Nombres"].Value.ToString();
                LblNombresP.Text += " " + DgvSocios.CurrentRow.Cells["Apellidos"].Value.ToString();

                var query = from MemSocio in bd.Zk_MembresiasxSocio
                            join Memb in bd.Zk_Membresias on MemSocio.MembresiasID equals Memb.ID
                            where (MemSocio.UserInfoID == vUserId)
                            //(MemSocio.EstadoCancelacion=false )
                            orderby MemSocio.FechaFinal descending
                            select new
                            {
                                MemSocio.ID,
                                MemSocio.UserInfoID,
                                Memb.DescripcionMembresias,
                                MemSocio.FechaInicio,
                                MemSocio.FechaFinal,
                                MemSocio.PrecioPactado,
                                MemSocio.Saldo,
                                MemSocio.NroCuota
                            };
                DgvPagosMembresias.DataSource = query.ToList();
                vTipo = 5;
            }

            ClsFuncNet.ActivaTab(5, 5, ref TabSocios);
            using (Model1 bd = new Model1())
            {
            }
            PicPagos.Image = ClsFuncNet.byteArrayToImage(imagen);
            ActivaBotones(false, false, false, false, false, true, true, false, false);
        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntSocios_Click(object sender, EventArgs e)
        {
        }
        #endregion Botones

        #region Ayudas

        private void ctr_AyuMembGrupo_AlDevolverDato(object Sender, DataRow e)
        {
            using (Model1 bd = new Model1())
            {
                string vCodigo = Convert.ToString(ctr_AyuSocios.Codigo);
                var Resultado = (from user in bd.USERINFO
                                 where user.Badgenumber == vCodigo
                                 select new
                                 {
                                     user.USERID,
                                     user.Name,
                                     user.lastname
                                 }
                                 ).First();
            }
        }

        private void ctr_AyuMembGrupo_Load(object sender, EventArgs e)
        {
        }
        private void ctr_AyuMembPersonal_AlDevolverDato(object Sender, DataRow e)
        {
            string id = ctr_AyuMembPersonal.Codigo ;
            using (Model1 bd = new Model1())
            {
                int vId = Convert.ToInt32(id);

                var Resultado = (from dd in bd.Zk_Membresias
                                 join ee in bd.Zk_Periodos on dd.PeriodosID equals ee.ID
                                 where dd.ID == vId
                                 select new
                                 {
                                     ee.Meses,
                                     ee.Dias,
                                     dd.DescripcionMembresias,
                                     dd.Precio
                                 }).First();

                TxtPrecio.Text = Convert.ToString(Resultado.Precio);
                TxtMeses.Text = Convert.ToString(Resultado.Meses);
                TxtDias.Text = Convert.ToString(Resultado.Dias);
                DtpInicioMp.Value = DateTime.Now;
                TxtImporteaPagar.Text = TxtPrecio.Text;
            }
        }

        #endregion Ayudas

        #region Input datos

        private void ChkAutorizacionG_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutorizacionG.Checked == true)
            {
                LblDescuentoG.Visible = true;
                TxtDescuentoG.Visible = true;
            }
            else
            {
                LblDescuentoG.Visible = false;
                TxtDescuentoG.Visible = false;
            }
        }

        private void DgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model1 bd = new Model1())
            {
                vUserId = Convert.ToInt32(DgvSocios.CurrentRow.Cells["Id"].Value);
                var query = from MemSocio in bd.Zk_MembresiasxSocio
                            join Memb in bd.Zk_Membresias on MemSocio.MembresiasID equals Memb.ID
                            where MemSocio.UserInfoID == vUserId
                            orderby MemSocio.FechaFinal descending
                            select new
                            {
                                MemSocio.UserInfoID,
                                Memb.DescripcionMembresias,
                                MemSocio.FechaInicio,
                                MemSocio.FechaFinal,
                                MemSocio.fechaMaximadePago
                            };

                DgvMembresias.DataSource = query.ToList();
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                pictFoto.Image = ClsFuncNet.byteArrayToImage(imagen);
            }
        }

        private void DtpInicioMG_ValueChanged(object sender, EventArgs e)
        {
            int vMeses = Convert.ToInt32(TxtMeses.Text);
            int vDias = Convert.ToInt32(TxtDias.Text);
            DtpTerminoMG.Value = DtpInicioMG.Value.AddMonths(vMeses);
            DtpTerminoMG.Value = DtpTerminoMG.Value.AddDays(vDias);
            DtpMaxPagoMG.Value = DtpInicioMG.Value.AddDays(-1);
        }

        private void DtpInicioMp_ValueChanged(object sender, EventArgs e)
        {
            int vMeses = Convert.ToInt32(TxtMeses.Text);
            int vDias = Convert.ToInt32(TxtDias.Text);
            DtpTerminoMp.Value = DtpInicioMp.Value.AddMonths(vMeses);
            DtpTerminoMp.Value = DtpTerminoMp.Value.AddDays(vDias );
            DtpMaxPagoMp.Value = DtpInicioMp.Value.AddDays(-1);
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (ClsFuncNet.EsNumero(TxtBuscar.Text, 0))
            {
                using (Model1 bd = new Model1())

                {
                    var Result = (from dd in bd.USERINFO
                                  where dd.Badgenumber.StartsWith(TxtBuscar.Text)
                                  select new
                                  {
                                      dd.USERID,
                                      dd.Badgenumber,
                                      dd.Name,
                                      dd.lastname,
                                      dd.acc_startdate,
                                      dd.acc_enddate,
                                      dd.PHOTO
                                  });

                    DgvSocios.DataSource = Result.ToList();
                }
            }
            else
            {
                if (!(TxtBuscar.Text == ""))
                {
                    using (Model1 bd = new Model1())
                    {
                        var Resultado = (from dd in bd.USERINFO
                                         where dd.lastname.Contains(TxtBuscar.Text)
                                         select new
                                         {
                                             dd.USERID,
                                             dd.Badgenumber,
                                             dd.Name,
                                             dd.lastname,
                                             dd.acc_startdate,
                                             dd.acc_enddate,
                                             dd.PHOTO
                                         });
                        DgvSocios.DataSource = Resultado.ToList();
                    }
                }
            }
        }

        #endregion Input datos

        #region Chk

        private void ChkAutorizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutorizacion.Checked == true)
            {
                LblDescuento.Visible = true;
                TxtDescuento.Visible = true;
                TxtReferencia.Visible = true;
                LblReferencia.Visible = true;
            }
            else
            {
                LblDescuento.Visible = false;
                TxtDescuento.Visible = false;
                TxtReferencia.Visible = false;
                LblReferencia.Visible = false;
            }
        }

        private void ChkBaja_CheckedChanged(object sender, EventArgs e)
        {
            DtpBaja.Visible = ChkBaja.Checked;
            DtpBaja.Value = DateTime.Now.Date;
        }

        private void ChkPagoTotalG_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPagoTotalG.Checked == false)
            {
                DtpMaxPagoMG.Visible = true;
                TxtACuentaMG.Visible = true;
                TxtACuentaMG.Text = "0";
            }
            else
            {
                DtpMaxPagoMG.Visible = false;
                TxtACuentaMG.Visible = false;
                TxtACuentaMG.Text = "0";
            }
        }
        #endregion Chk

        #region Txt

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }
        private void TxtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        private void TxtReferenciaG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }

        #endregion Txt

        #region huella

        private void BntCancelarH_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(500);
            zkfp2.CloseDevice(mDevHandle);
            zkfp2.Terminate();
            cbRegTmp = 0;

            BntRegistrar.Visible = false;
            PicHuellas.Visible = false;
            BntGrabarH.Visible = false;
            BntCancelarH.Visible = false;
        }

        private void BntGrabarH_Click(object sender, EventArgs e)
        {
            vHuellas = 0;
            switch (vNroHuella)
            {
                case 0:
                    BntHuella0.BackColor = Color.Orange;
                    break;

                case 1:
                    BntHuella1.BackColor = Color.Orange;
                    break;

                case 2:
                    BntHuella2.BackColor = Color.Orange;
                    break;

                case 3:
                    BntHuella3.BackColor = Color.Orange;
                    break;

                case 4:
                    BntHuella4.BackColor = Color.Orange;
                    break;

                case 5:
                    BntHuella5.BackColor = Color.Orange;
                    break;

                case 6:
                    BntHuella6.BackColor = Color.Orange;
                    break;

                case 7:
                    BntHuella7.BackColor = Color.Orange;
                    break;

                case 8:
                    BntHuella8.BackColor = Color.Orange;
                    break;

                case 9:
                    BntHuella9.BackColor = Color.Orange;
                    break;
            }
            BntRegistrar.Visible = true;
            BntGrabarH.Visible = false;
            BntCancelarH.Visible = false;
            blob1 = zkfp.Base64String2Blob(textRes.Text);

            GrabarHuella(vNroHuella, blob1);
        }

        private void BntHuella0_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella0, 0);
        }

        private void BntHuella1_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella1, 1);
        }

        private void BntHuella2_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella2, 2);
        }

        private void BntHuella3_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella3, 3);
        }

        private void BntHuella4_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella4, 4);
        }

        private void BntHuella5_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella5, 5);
        }

        private void BntHuella6_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella6, 6);
        }

        private void BntHuella7_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella7, 7);
        }

        private void BntHuella8_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella8, 8);
        }

        private void BntHuella9_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella9, 9);
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            TxtHuella.Text = "start register";
        }

        private void CambiarColorTextBox(ref System.Windows.Forms.TextBox Bnt, int vNro)
        {
            switch (Bnt.BackColor.Name) //Establecer Color Activo
            {
                case "Orange":
                    if (vHuellas == 1) return;
                    if (PreguntarHuella())
                    {
                        EliminaHuella(vNro);
                        Bnt.BackColor = Color.Yellow;
                        vHuellas = 1;
                    }
                    break;

                case "White":
                    if (vHuellas == 1)
                    {
                        return;
                    }
                    Bnt.BackColor = Color.Yellow;
                    vHuellas = 1;
                    break;

                case "Yellow":
                    Bnt.BackColor = Color.White;
                    vHuellas = 0;
                   break;

                case "Control":
                    if (vHuellas == 1) return;
                    Bnt.BackColor = Color.Yellow;
                    vHuellas = 1;
                    break;
            }
            if (Bnt.BackColor.Name == "Yellow")
            {
                BntInicializa.Visible = true;
                BntCancelarH.Visible = true;
                PicHuellas.Visible = true;
                PicHuellas.Image = null;
                vNroHuella = vNro;
            }
            else
            {
                BntRegistrar.Visible = false;
                PicHuellas.Visible = false;
            }
        }

        private void ChkHuellas_CheckedChanged(object sender, EventArgs e)
        {
            PnlHuellas.Visible = ChkHuellas.Checked;
            if (ChkHuellas.Checked)
            {
                if (vAdiciona == false)
                {
                    PicHuellas.Image = null;
                    TxtHuella.Text = "";
                    ObtenerHuellas();
                }
            }
        }

        private void EliminaHuella(int ii)
        {
            using (Model1 bd = new Model1())
            {
                //      var Dato = from x in bd.TEMPLATE
                //                 where x.USERID == vUserId && x.FINGERID == ii
                //                select x;

                //   bd.TEMPLATE.RemoveRange(Dato);

                bd.TEMPLATE.RemoveRange(bd.TEMPLATE.Where(p => p.USERID == vUserId && p.FINGERID == ii));
                bd.SaveChanges();
            }
        }

        private void GrabarHuella(int vNro, byte[] blob1)
        {
            using (Model1 Bd = new Model1())
            {
                TEMPLATE user = new TEMPLATE();
                if (vAdiciona == true)
                    vUserId = Convert.ToInt32(TxtId.Text);

                        user.USERID = vUserId;
                user.FINGERID = vNro;
                user.USETYPE = 0;
                user.Flag = 1;
                user.DivisionFP = 10;
                user.status = 0;
                user.Valid = 1;
                user.Fpversion = "10";
                user.bio_type = 0;
                user.SN = 0;

                user.TEMPLATE3 = blob1;
                user.TEMPLATE4 = blob1;

                Bd.TEMPLATE.Add(user);
                Bd.SaveChanges();
            }
        }

        private Boolean InicializaHuella()
        {
            try
            {
                if (!IsRegister)
                {
                    RegisterCount = 0;
                    cbRegTmp = 0;
                    textRes.Text = "";
                    TxtHuella.Text = "Presione 3 veces el enrrolador !! ";
                        IsRegister = true;
                    return true;
                }
                else
                    {
                        IsRegister = false;
                    return false;
                    }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private Boolean InicializaSensor()
        {
            try
            {
                cmbIdx.Items.Clear();
                int ret = zkfperrdef.ZKFP_ERR_OK;
                if (zkfp2.Init() == zkfperrdef.ZKFP_ERR_OK)
                {
                    int nCount = zkfp2.GetDeviceCount();
                    if (nCount > 0)
                    {
                        for (int i = 0; i < nCount; i++)
                        {
                            cmbIdx.Items.Add(i.ToString());
                        }
                        cmbIdx.SelectedIndex = 0;
                        return true;
                    }
                    else
                    {
                        bIsTimeToDie = true;
                        RegisterCount = 0;
                        Thread.Sleep(500);
                        zkfp2.CloseDevice(mDevHandle);
                        zkfp2.Terminate();
                        MessageBox.Show("No device connected!");
                        return false;
                    }
                }
                else
                {
                    zkfp2.CloseDevice(mDevHandle);
                    zkfp2.Terminate();
                    MessageBox.Show("Inicializacion Fallo, ERROR Nro. =" + ret + " !");
                    return false;
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void InicializaVariables()
        {
            BntHuella0.BackColor = Color.White;
            BntHuella1.BackColor = Color.White;
            BntHuella2.BackColor = Color.White;
            BntHuella3.BackColor = Color.White;
            BntHuella4.BackColor = Color.White;
            BntHuella5.BackColor = Color.White;
            BntHuella6.BackColor = Color.White;
            BntHuella7.BackColor = Color.White;
            BntHuella8.BackColor = Color.White;
            BntHuella9.BackColor = Color.White;
             vActualiza = new int[10];
            ChkHuellas.Checked = false;
            vHuellas = 0;
        }

        private void MostrarHuellas(int i)
        {
            switch (i)
            {
                case 0:
                    BntHuella0.BackColor = Color.Orange;
                    break;

                case 1:
                    BntHuella1.BackColor = Color.Orange;
                    break;

                case 2:
                    BntHuella2.BackColor = Color.Orange;
                    break;

                case 3:
                    BntHuella3.BackColor = Color.Orange;
                    break;

                case 4:
                    BntHuella4.BackColor = Color.Orange;
                    break;

                case 5:
                    BntHuella5.BackColor = Color.Orange;
                    break;

                case 6:
                    BntHuella6.BackColor = Color.Orange;
                    break;

                case 7:
                    BntHuella7.BackColor = Color.Orange;
                    break;

                case 8:
                    BntHuella8.BackColor = Color.Orange;
                    break;

                case 9:
                    BntHuella9.BackColor = Color.Orange;
                    break;
            }
        }

        private void ObtenerHuellas()
        {
            using (Model1 bd = new Model1())
            {
                var Resultado = (from temp in bd.TEMPLATE
                                 where temp.USERID == vUserId
                                 select temp);

                foreach (var res in Resultado)
                {
                    MostrarHuellas(res.FINGERID);
                }
            }
        }
        private bool PreguntarHuella()
        {
            if (MessageBox.Show("desea ELIMINAR huella", " Si / No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                if (ClsFuncNet.EsNumero(TxtDescuento.Text, 0))
                {
                    if (!(Convert.ToInt32(TxtDescuento.Text) == 0))
                    {
                        ctr_AyuAutorizacion.Visible = true;
                        TxtImporteaPagar.Text =Convert.ToString( Convert.ToDecimal(TxtPrecio.Text ) -Convert.ToDecimal(TxtDescuento.Text));
                    }
                    else
                    {
                        ctr_AyuAutorizacion.Visible = false;
                        TxtImporteaPagar.Text = "0.00";
                    }
                }
                else
                {
                    MessageBox.Show(" dato debe ser numero y mayor a cero");
                }
            }
        }
        #endregion huella

        #region Metodos privados

        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                }
                Thread.Sleep(500);
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        MemoryStream ms = new MemoryStream();
                       BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new Bitmap(ms);
                        this.PicHuellas.Image = bmp;

                        String strShow = zkfp2.BlobToBase64(CapTmp, cbCapTmp);

                        if (IsRegister)
                        {
                            int ret = zkfp.ZKFP_ERR_OK;
                            int fid = 0, score = 0;
                            ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                            if (zkfp.ZKFP_ERR_OK == ret)
                            {
                                TxtHuella.Text = "PASO 1: El enrrolador ya esta registrado por  " + fid + "! ";
                      //          return;
                            }

                            if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                            {
                                TxtHuella.Text = "Please press the same finger 3 times for the enrollment ";
                                return;
                            }
                            Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
                            String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                            byte[] blob = zkfp2.Base64ToBlob(strBase64);
                            RegisterCount++;
                            if (RegisterCount >= REGISTER_FINGER_COUNT)
                            {
                                RegisterCount = 0;
                                if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)) &&
                                       zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBAdd(mDBHandle, iFid, RegTmp)))
                                {
                                    iFid++;
                                    textRes.Text = strShow;
                            
                                    MessageBox.Show("enrolador OK \n");
                                    BntGrabarH.Visible = true;
                                }
                                else
                                {
                                    TxtHuella.AppendText("enrrolador fallo, codigo error =" + ret + "\n");
                                }
                                IsRegister = false;
                                return;
                            }
                            else
                            {
                                TxtHuella.Text = "Necesita continuar presione " + (REGISTER_FINGER_COUNT - RegisterCount) + " veces el enrrolador ";
                            }
                        }
                        else
                        {
                            if (cbRegTmp <= 0)
                            {
                                TxtHuella.Text = "Registre su enrrolador primero";
                                return;
                            }
                            if (bIdentify)
                            {
                                int ret = zkfp.ZKFP_ERR_OK;
                                int fid = 0, score = 0;
                                ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                                if (zkfp.ZKFP_ERR_OK == ret)
                                {
                                    textRes.AppendText("Identify succ, fid= " + fid + ",score=" + score + "!\n");
                                    return;
                                }
                                else
                                {
                                    textRes.AppendText("Identify fail, ret= " + ret + "\n");
                                    return;
                                }
                            }
                            else
                            {
                                int ret = zkfp2.DBMatch(mDBHandle, CapTmp, RegTmp);
                                if (0 < ret)
                                {
                                    textRes.AppendText("Match finger succ, score=" + ret + "!\n");
                                    return;
                                }
                                else
                                {
                                    textRes.AppendText("Match finger fail, ret= " + ret + "\n");
                                    return;
                                }
                            }
                        }
                    }
                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void ActivaBotones(bool adicionar, bool modificar, bool membp, bool membg, bool pagar, bool guardar, bool cancelar, bool imprimir, bool salir)
        {
            BntAdicionar.Visible = adicionar;
            BntModificar.Visible = modificar;
            BntMembPersonal.Visible = membp;
            BntMembGrupo.Visible = membg;
            BntPagos.Visible = pagar;
            BntGrabar.Visible = guardar;
            BntCancelar.Visible = cancelar;
            BntImprimir.Visible = imprimir;
            BntSalir.Visible = salir;
        }

        private void AdicionaPagos(Boolean vtotal)
        {
            using (Model1 bd = new Model1())
            {
                var Resultado = (from dd in bd.Zk_MembresiasxSocio
                                 orderby dd.ID descending
                                 select new { dd.ID }
                                 ).FirstOrDefault();

                int corr = Resultado.ID;

                Zk_PagosSocios pagossocios = new Zk_PagosSocios();

                pagossocios.MembresiasxSocioID = corr;
                pagossocios.EstadoAnulado = false;
                pagossocios.FormaPagoID = 1;
                pagossocios.NroCuota = 1;
                pagossocios.TurnoID = 1;
                pagossocios.Referencia = TxtReferencia.Text;
                pagossocios.FechaPago = (DateTime.Now).Date;
                if (vtotal == true)
                {
                    pagossocios.ImportePagado = Convert.ToDecimal(TxtPrecio.Text) - Convert.ToDecimal(TxtDescuento.Text);
                }
                else
                {
                    pagossocios.ImportePagado = Convert.ToDecimal(TxtACuentaMp.Text);
                }
                bd.Zk_PagosSocios.Add(pagossocios);
                bd.SaveChanges();
            }
        }

        private void BajaFechaTermino(DateTime FechaBaja)
        {
            using (Model1 bd = new Model1())
            {
                DateTime vfecha = Convert.ToDateTime(FechaBaja.Date);
                var Result = (from membsocio in bd.Zk_MembresiasxSocio
                              where (membsocio.FechaFinal >= vfecha )
                              & membsocio.UserInfoID==vUserId
                              select new
                              {
                                  membsocio.UserInfoID,
                                  membsocio.ID,
                                  membsocio.FechaFinal
                              }
                             ).ToList();

                foreach (var baja in Result)
                {
                    using (Model1 bd1 = new Model1())
                    {
                        var data = (from memb in bd1.Zk_MembresiasxSocio
                                    where memb.ID == baja.ID
                                    select memb
                                   ).First() ;

                        data.FechaFinal = DtpBaja.Value.Date;
                        bd1.SaveChanges();
                    }
                }
            }
        }

        private void CargarAyudas()
        {
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql;
            ctr_AyuMembGrupo.CadenaCone = VGCnxSql;
            ctr_AyuSocios.CadenaCone = VGCnxSql;
            ctr_AyuAutorizacion.CadenaCone = VGCnxSql;
        }

        private void CargarCombos()
        {
            ClsFuncNet.CargaCombo(ref CmbGenero, "select id,descripciongenero from zk_genero ");
        }

        private DataTable CrearTabla()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Item", Type.GetType("System.Int32"));
            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("CodigoG", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("LastName", Type.GetType("System.String"));
            return dt;
        }

         private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PicDetalle.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void GrabaAdiciona()
        {
            using (Model1 bd = new Model1())
            {
                USERINFO user = new USERINFO();


                user.Badgenumber = TxtCodigo.Text;
                user.Name = TxtNombres.Text;
                user.lastname = TxtApellidos.Text;
                user.BIRTHDAY = Convert.ToDateTime(DtpNacimiento.Text);
                user.email = TxtCorreo.Text;
                user.Gender = ClsFuncNet.ObtenerDatoCombo(CmbGenero.Text);
                user.OPHONE = TxtCelular.Text;
                if (PicDetalle.Image == null)
                {
                    user.PHOTO = null;
                }
                else
                {
                    user.PHOTO = ClsFuncNet.ImageTobyteArray(PicDetalle.Image);
                }
                user.DEFAULTDEPTID = 2;
                    user.ATT = 1;
                user.INLATE = 1;
                user.OUTEARLY = 1;
                user.OVERTIME = 1;
                user.SEP = 1;
                user.HOLIDAY = 1;
                user.privilege = 0;
                user.AutoSchPlan = 1;
                user.MinAutoSchInterval = 24;
                user.RegisterOT = 1;
                user.status = 0;
                user.acc_startdate =Convert.ToDateTime("01-01-1900");
                user.acc_enddate= Convert.ToDateTime("01-01-1900");

                bd.USERINFO.Add(user);
                bd.SaveChanges();


                var Resultado = (from dd in bd.Zk_Correlativos
                                 select dd).First();

                Resultado.codId += 1;
                Resultado.Codigo += 1;
                bd.SaveChanges();

                var Result = bd.USERINFO
                .OrderByDescending(t => t.USERID)
                .FirstOrDefault();

                int vCodId = Result.USERID;

                acc_levelset_emp level = new acc_levelset_emp();
                level.employee_id = vCodId;
                level.acclevelset_id = 1;

                bd.acc_levelset_emp.Add(level);
                bd.SaveChanges();
            }
        }

        private void GrabaMembG()
        {
            using (Model1 bd = new Model1())
            {
                Zk_MembresiasxSocio membsocio = new Zk_MembresiasxSocio
                {
                    UserInfoID = vUserId,
                    MembresiasID = Convert.ToInt32(ctr_AyuMembPersonal.Codigo),
                    FechaInicio = DtpInicioMp.Value,
                    FechaFinal = DtpTerminoMp.Value,
                    fechaMaximadePago = DtpMaxPagoMp.Value
                };
                if (TxtDescuento.Text == "")
                {
                    TxtDescuento.Text = "0";
                }

                membsocio.Precio = Convert.ToDecimal(TxtPrecio.Text);
                membsocio.descuento = Convert.ToDecimal(TxtDescuento.Text);
                membsocio.PrecioPactado = membsocio.Precio - membsocio.descuento;

                if (ChkPagototal.Checked)
                {
                    membsocio.EstadoCancelacion = true;
                }
                else
                {
                    membsocio.EstadoCancelacion = false;
                }
                bd.Zk_MembresiasxSocio.Add(membsocio);
                bd.SaveChanges();
            }
            if (ChkPagototal.Checked)
            {
                    AdicionaPagos(true);
            }
            else
            {
                    AdicionaPagos(false);
            }
            using (Model1 bd1 = new Model1())
            {
                var user = (from dato in bd1.USERINFO
                            where dato.USERID == (vUserId)
                            select dato).First();

                DateTime vfecha1n =Convert.ToDateTime( user.acc_startdate);
                DateTime vfecha2n = Convert.ToDateTime(user.acc_enddate);

                if (ClsFuncGym.ActivarFechasSensor(1, vUserId, ref vfecha1n, ref vfecha2n))
                {
                    user.acc_startdate = vfecha1n;
                    user.acc_enddate = vfecha2n;
                }
                else
                {
                    user.acc_startdate = DtpInicioMp.Value;
                    user.acc_enddate = DtpTerminoMp.Value;
                }
                bd1.SaveChanges();
            }
        }

        private void GrabaMembP()
        {
            using (Model1 bd = new Model1())
            {
                Zk_MembresiasxSocio membsocio = new Zk_MembresiasxSocio();

                membsocio.UserInfoID = vUserId;
                int vId = Convert.ToInt32(ctr_AyuMembPersonal.Codigo);
                membsocio.MembresiasID = vId;
                membsocio.FechaInicio = Convert.ToDateTime(DtpInicioMp.Text);
                membsocio.FechaFinal = Convert.ToDateTime(DtpTerminoMp.Text);
                membsocio.fechaMaximadePago = Convert.ToDateTime(DtpMaxPagoMp.Text);
                if (TxtDescuento.Text == "")
                {
                    TxtDescuento.Text = "0";
                }

                membsocio.Precio = Convert.ToDecimal(TxtPrecio.Text);
                membsocio.descuento = Convert.ToDecimal(TxtDescuento.Text);
                membsocio.PrecioPactado = membsocio.Precio - membsocio.descuento;
                membsocio.UsuarioID = 1;
                if (ChkPagototal.Checked)
                {
                    membsocio.Saldo = 0;
                    membsocio.EstadoCancelacion = true;
                }
                else
                {
                    membsocio.Saldo = membsocio.PrecioPactado - Convert.ToDecimal(TxtACuentaMp.Text);
                    membsocio.EstadoCancelacion = false;
                }
                membsocio.NroCuota = 1;
                int vIdAutorizacion = 1;
                if(ctr_AyuAutorizacion.Codigo!="")
                {
                    vIdAutorizacion= Convert.ToInt16(ctr_AyuAutorizacion.Codigo);
                }
                 membsocio.AutorizacionesID = vIdAutorizacion;
                membsocio.FechaAct = DateTime.Now;
                membsocio.Activacion = false;
                bd.Zk_MembresiasxSocio.Add(membsocio);
                bd.SaveChanges();

                if (ChkPagototal.Checked)
                {
                    AdicionaPagos(true);
                }
                else
                {
                    AdicionaPagos(false);
                }

                var user = (from dato in bd.USERINFO
                            where dato.USERID == (vUserId)
                            select dato).First();

                user.acc_startdate = Convert.ToDateTime(DtpInicioMp.Text);
                user.acc_enddate = Convert.ToDateTime(DtpTerminoMp.Text);
                bd.SaveChanges();
            }
        }

        private void GrabaModifica()
        {
            using (Model1 bd = new Model1())
            {
                var user = (from dato in bd.USERINFO
                            where dato.USERID == (vUserId)
                            select dato).First();

                user.Badgenumber = TxtCodigo.Text;
                user.Name = TxtNombres.Text;
                user.lastname = TxtApellidos.Text;
                user.BIRTHDAY = Convert.ToDateTime(DtpNacimiento.Text);
                user.email = TxtCorreo.Text;
                user.Gender = ClsFuncNet.ObtenerDatoCombo (CmbGenero.Text);
                user.OPHONE = TxtCelular.Text;
                if (PicDetalle.Image == null)
                {
                    user.PHOTO = null;
                }
                else
                {
                    user.PHOTO = ClsFuncNet.ImageTobyteArray(PicDetalle.Image);
                }
                if (ChkBaja.Checked == true)
                {
                    user.delete_time = DtpBaja.Value.Date;
                    user.status = 1;
                    user.hiretype = 1;
                    user.acc_enddate = DtpBaja.Value.Date;
                    BajaFechaTermino(DtpBaja.Value.Date);
                }
                else
                {
                    user.delete_time = Convert.ToDateTime("01-01-1900");
                    user.status = 0;
                    user.hiretype = 0;
                } 

                bd.SaveChanges();
            }
            if (FinalFrame != null)
            {
                if (FinalFrame.IsRunning)
                {
                    FinalFrame.Stop();
                }
            }
        }

        private void GrabaPagos()
        {
            if (TxtSaldo.Text == "")
                TxtSaldo.Text = "0.00";

            Int32 vMembID = 0;

            using (Model1 bd = new Model1())
            {

                Zk_PagosSocios dd = new Zk_PagosSocios();

                dd.MembresiasxSocioID = Convert.ToInt32(DgvPagosMembresias.CurrentRow.Cells["PagosID"].Value);
                dd.NroCuota = Convert.ToInt32(TxtNroCuota.Text)+1;
                dd.FechaPago = DateTime.Now.Date;
                dd.ImportePagado = Convert.ToDecimal(TxtImporte.Text);
                dd.TurnoID = 1;
                dd.FormaPagoID = 1;
                dd.UsuarioID = 1;
                dd.FechaAct = DateTime.Now;

                vMembID =Convert.ToInt32(dd.MembresiasxSocioID);
            
                bd.Zk_PagosSocios.Add(dd);
                bd.SaveChanges();
            }

            using (Model1 bd = new Model1())
            { 
                var user = (from d1 in bd.Zk_MembresiasxSocio
                            where d1.ID == vMembID
                            select d1).First();
                
                user.NroCuota=Convert.ToInt32(TxtNroCuota.Text)+1;
                user.Saldo= Convert.ToDecimal(TxtSaldo.Text)- Convert.ToDecimal(TxtSaldo.Text);
                if (user.Saldo == 0)
                    user.EstadoCancelacion =true;

                bd.SaveChanges();

            }
        }

        private void WebCamCapture_ImageCaptured(object source, WebcamEventArgs e)
        {
            // set the picturebox picture
            this.PicDetalle.Image = e.WebCamImage;
        }
        #endregion Metodos privados


        private void BntActivar_Click(object sender, EventArgs e)
        {
            ActivaSensor();
            BntRegistrar.Visible = true;
            BntFinaliza.Visible = true;
            BntActivar.Visible = false;
        }

        private void BntRegistrar_Click(object sender, EventArgs e)
        {
            if (InicializaHuella() == true)
            {
                BntRegistrar.Visible= false;
            }
        }

        private void BntFinaliza_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = false;
            IsRegister = false;
            int reg1 = zkfp2.DBFree(mDevHandle);
            int reg = zkfp2.DBClear(mDevHandle);
            RegisterCount = 0;
            //   Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            BntActivar.Visible = true;
            BntFinaliza.Visible = false;
        }
        private void BntCierra_Click(object sender, EventArgs e)
        {
            zkfp2.Terminate();
            cmbIdx.Items.Clear();
            cbRegTmp = 0;
   
            BntInicializa.Visible = true;
            BntCierra.Visible = false;
            BntActivar.Visible = false;
        }

        private void DgvPagosMembresias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 vMemb = 0;
            vMemb = Convert.ToInt32(DgvPagosMembresias.CurrentRow.Cells["PagosId"].Value);
            TxtSaldo.Text = Convert.ToString(DgvPagosMembresias.CurrentRow.Cells["saldo"].Value);
            TxtNroCuota.Text = Convert.ToString(DgvPagosMembresias.CurrentRow.Cells["NroCuota"].Value);
            using (Model1 bd = new Model1())
            {
                var query = from pagos in bd.Zk_PagosSocios
                            where (pagos.MembresiasxSocioID == vMemb)
                            //(MemSocio.EstadoCancelacion=false )
                            orderby pagos.FechaPago descending
                            select new
                            {
                                pagos.ID,
                                pagos.FechaPago,
                                pagos.ImportePagado,
                                pagos.NroCuota,
                                pagos.TurnoID,

                            };

                DgvPagos.DataSource = query.ToList();
            }
        }
    }
}