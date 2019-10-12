using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Data.OleDb;
using System.Collections;
using AForge.Video;
using AForge.Video.DirectShow;
using AppGym.Models;
using System.Linq;
using libzkfpcsharp;
using Class;

namespace AppGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //private System.Timers.Timer showpicture = new System.Timers.Timer();

        int FMatchType;
        int fpcHandle;
        int FPID = 0;
        string sRegTemplate, sRegTemplate10;

        private FilterInfoCollection CaptureDevice;

        private VideoCaptureDevice FinalFrame;

 
        private int fila1;
        private byte[] imagen;
        private Int32 vUserId;
        private int vHuellas;
        private int vNroHuella;
        private byte[] blob1;
        private object pTemplate;
        private void btnInitialSensor_Click(object sender, EventArgs e)        
        {
                axZKFPEngX1.FakeFunOn = 1;
 
            if (axZKFPEngX1.InitEngine() == 0)
            {
                EnableButton(false);
 
                axZKFPEngX1.FPEngineVersion = "10";

                fpcHandle = axZKFPEngX1.CreateFPCacheDBEx();

                txtb1.Text = axZKFPEngX1.SensorCount.ToString();
                txtb2.Text = axZKFPEngX1.SensorIndex.ToString();
                txtb5.Text = axZKFPEngX1.SensorSN;
                TxtHuella.Text = "Sensor Connectado!";
                BntRegistro.Visible = true;
                MessageBox.Show("Inicio correcto !", "Information");                
            }
            else
            {
                axZKFPEngX1.EndEngine();
                MessageBox.Show("Inico INCORRECTO !", "Error"); 
            }

            FMatchType = 2;
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (axZKFPEngX1.IsRegister)
            {
                axZKFPEngX1.CancelEnroll();
            }
            axZKFPEngX1.EnrollCount = 3;
            axZKFPEngX1.BeginEnroll();
            TxtHuella.Text = "Inicio registro";
            BntRegistro.Visible = false;
        }
 
        private void btnCloseSensor_Click(object sender, EventArgs e)
        {
            axZKFPEngX1.EndEngine();
            EnableButton(true);
        }
        private void axZKFPEngX1_OnCapture(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent e)
        {                                     
            if (FMatchType == 1)
            {
                bool RegChanged = false;
                string sTemp = axZKFPEngX1.GetTemplateAsString();
                string sVerTemplate;

                sVerTemplate = sRegTemplate10;

                if (axZKFPEngX1.VerFingerFromStr(ref sVerTemplate, sTemp, false, ref RegChanged))
                {
                    TxtHuella.Text = "Verify Succeed";
                }
                else
                {
                    TxtHuella.Text = "Verify Failed";
                }               
            }
            else if (FMatchType == 2)
            {
                int score = 8;
                int processedNum = 1;
                int ID = axZKFPEngX1.IdentificationInFPCacheDB(fpcHandle, e.aTemplate, ref score, ref processedNum);
                if (ID == -1)
                    TxtHuella.Text = "Identify Failed";
                else
                    TxtHuella.Text = string.Format("Identify Succeed ID = {0} Score = {1}  Processed Number = {2}", ID, score, processedNum);
            }
        }

        private void axZKFPEngX1_OnEnroll(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (!e.actionResult)                
            {
                MessageBox.Show("Registro ERRADO !", "error!");
            }
            else
            {
                sRegTemplate = axZKFPEngX1.GetTemplateAsStringEx("9");
		        sRegTemplate10 = axZKFPEngX1.GetTemplateAsStringEx("10");

		        if(sRegTemplate.Length > 0)
		        {
                    if (sRegTemplate10.Length > 0)
                        axZKFPEngX1.AddRegTemplateStrToFPCacheDBEx(fpcHandle, FPID, sRegTemplate, sRegTemplate10);
                    else
                        MessageBox.Show("Register 10.0 failed, template length is zero", "error!");

                 
                        pTemplate = axZKFPEngX1.DecodeTemplate1(sRegTemplate10);
                
			        axZKFPEngX1.SaveTemplate("fingerprint.tpl", pTemplate);

			        FPID++;
                 
			        MessageBox.Show("Registro CORRECTO ", "Information!");
                }
                else
		        {
                    MessageBox.Show("Register Failed, template length is zero", "error!");
		        };
            }            
        }

        private void axZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = PicHuellas.CreateGraphics();
            int dc = g.GetHdc().ToInt32();
            axZKFPEngX1.PrintImageAt(dc, 0, 0, axZKFPEngX1.ImageWidth, axZKFPEngX1.ImageHeight);
        }

        private void axZKFPEngX1_OnFeatureInfo(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEvent e)
        {
            string sTemp = "";
            if (axZKFPEngX1.IsRegister)
                sTemp = "Registro iniciado, presione  " + axZKFPEngX1.EnrollIndex.ToString() + " veces !";

            sTemp = sTemp + " Fingerprint quality";
            int lastq = axZKFPEngX1.LastQuality;
            if (e.aQuality == -1)
                sTemp = sTemp + " not good, Suspicious fingerprints, quality=" + lastq.ToString();
            else if (e.aQuality != 0)
                sTemp = sTemp + " not good, quality=" + lastq.ToString();
            else
                sTemp = sTemp + " good, quality=" + lastq.ToString();
            TxtHuella.Text = sTemp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Dispositivos tiene el array, con todos los dispositivos disponibles
            if (CaptureDevice.Count > 0)
            {
                foreach (FilterInfo x in CaptureDevice)
                {
                    comboBox1.Items.Add(x.Name);
                }
                comboBox1.SelectedIndex = 0;
            }

            //showpicture.Elapsed += new System.Timers.ElapsedEventHandler(showpicture_Elapsed);
            EnableButton(true);
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PicDetalle.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BntCamara_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                BntFoto.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BntFoto_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
      
                if (ClsFunc.EsNumero(TxtBuscar.Text, 0))
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

        private void DgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila1 = e.RowIndex;
            BntGrabar.Visible = true;
            DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
            imagen = (byte[])cell.Value;
            PicDetalle.Image = ClsFunc.byteArrayToImage(imagen);
            vUserId = Convert.ToInt32(DgvSocios.CurrentRow.Cells["Id"].Value);

            ObtenerHuellas();
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

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntHuella2_Click(object sender, EventArgs e)
        {
            CambiarColorTextBox(ref BntHuella1, 1);

        }
        private void CambiarColorTextBox(ref System.Windows.Forms.TextBox Bnt, int vNro)
        {
            switch (Bnt.BackColor.Name) //Establecer Color Activo
            {
                case "Orange":
                    if (vHuellas == 1) return;
                    if (PreguntarHuella())
                    {
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
                btnInitialSensor.Visible = true;
                PicHuellas.Visible = true;
                PicHuellas.Image = null;
                vNroHuella = vNro;
            }
            else
            {
               PicHuellas.Visible = false;
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

        private void BntGrabar_Click(object sender, EventArgs e)
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
            blob1 = zkfp.Base64String2Blob(sRegTemplate10);
            if(btnCloseSensor.Visible==true)
            {
                axZKFPEngX1.EndEngine();
                EnableButton(true);
            }
            GrabarHuella(vNroHuella, blob1);
            GrabaFoto();
            BntGrabar.Visible = false;
        }
        private void GrabarHuella(int vNro, byte[] blob1)
        {
            using (Model1 Bd = new Model1())
            {
                TEMPLATE user = new TEMPLATE();
  
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

        private void GrabaFoto()
        {
            using (Model1 bd = new Model1())
            {
                var user = (from dato in bd.USERINFO
                            where dato.USERID == (vUserId)
                            select dato).First();

                if (PicDetalle.Image == null)
                {
                    user.PHOTO = null;
                }
                else
                {
                    user.PHOTO = ClsFunc.ImageTobyteArray(PicDetalle.Image);
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

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            BntGrabar.Visible = false;
        }

        private void EnableButton(bool bEnable)
        {
            btnInitialSensor.Enabled = bEnable;
            btnCloseSensor.Enabled = !bEnable;
           BntRegistro.Enabled = !bEnable;
            PicHuellas.Visible = !bEnable;
        }
    }
}
    
