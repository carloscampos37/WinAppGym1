using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinAppGym1;
using WinAppGym1.Models;
using WinAppGym1.Properties;

namespace WinAppGym
{

    public partial class FrmSocios : Form
    {
        #region Variables Privadas

        int vUserId;
         int vCorrelativoId;
        int vCorrelativoSocio;
        int vCorrelativoGrupo;
        bool  vAdiciona;
        int vTipo;
        byte[] imagen;
        Object vUserInfo;
         private string VGCnxSql = Settings.Default.CadenaConexion;
        private ModFuncNet FuncNet = new ModFuncNet();

        #endregion

        #region constructor

        public FrmSocios()
        {
            InitializeComponent();
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            CargarAyudas();
            CargarCombos();
            ActivaBotones(true, true, true, true, true, false, false, false, true);

        }


        #endregion

        #region Metodos privados

        private void GrabaAdiciona()
        {
            using (Model1 bd = new Model1())
            {
                USERINFO user = new USERINFO();

                user.Badgenumber = TxtCodigo.Text;
                user.Name = TxtNombres.Text;
                user.lastname = TxtApellidos.Text;
                user.BIRTHDAY = dtpcumpleaños.Value;
                user.email = TxtCorreo.Text;
                user.Gender = TxtGenero.Text;
                user.OPHONE = TxtCelular.Text;
                user.PHOTO = FuncNet.ImageTobyteArray(pictDetalle.Image);

                user.DEFAULTDEPTID = 2;
                user.ATT = 1;
                user.INLATE = 1;
                user.OUTEARLY = 1;
                user.OVERTIME = 1;
                user.SEP = 1;
                user.HOLIDAY=1;
                user.privilege =0;
                user.AutoSchPlan = 1;
                user.MinAutoSchInterval = 24;
                user.RegisterOT = 1;
                user.status = 0;
                
                bd.USERINFO.Add(user);
                bd.SaveChanges();

                var Resultado = (from dd in bd.Correlativos
                                 select dd).First();


                Resultado.codId += 1;
                Resultado.Codigo += 1;
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
                user.BIRTHDAY = dtpcumpleaños.Value;
                user.email = TxtCorreo.Text;
                user.Gender = TxtGenero.Text;
                user.OPHONE = TxtCelular.Text;
                user.PHOTO = FuncNet.ImageTobyteArray(pictDetalle.Image);
                bd.SaveChanges();
            }

        }
        private void GrabaMembP()
        {
            using (Model1 bd =new Model1())
            {
                MembresiasxSocio membsocio = new MembresiasxSocio();

                membsocio.UserInfoID = vUserId;
                membsocio.MembresiasID  = Convert.ToInt32(ctr_AyuMembPersonal.Codigo);
                membsocio.FechaInicio = DtpInicioMp.Value;
                membsocio.FechaFinal = DtpTerminoMp.Value ;
                membsocio.fechaMaximadePago = DtpPagoMp.Value;

                membsocio.Precio = Convert.ToDecimal(TxtPrecio.Text);
                if (ChkTodo.Checked)
                {
                    membsocio.PagosaCuenta = membsocio.Precio;
                    membsocio.EstadoCancelacion = true;
                }
                else
                {
                    membsocio.PagosaCuenta = Convert.ToDecimal(TxtACuentaMp.Text);
                    membsocio.EstadoCancelacion = false;

                }
                bd.MembresiasxSocio.Add(membsocio);
                bd.SaveChanges();

                var user = (from dato in bd.USERINFO
                            where dato.USERID == (vUserId)
                            select dato).First();

                user.acc_startdate = DtpInicioMp.Value;
                user.acc_enddate = DtpTerminoMp.Value;
                bd.SaveChanges();


            }
        }
        private void ActivaBotones(bool adicionar,bool modificar,bool membp, bool membg, bool pagar ,bool guardar, bool cancelar, bool imprimir,bool salir )
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
        private void CargarAyudas()
        {
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql;
            ctr_AyuMembGrupo.CadenaCone = VGCnxSql;
            ctr_AyuSocios.CadenaCone = VGCnxSql;
            ctr_AyuMembPersonal.Filtro = " EstadoAnulado=0  ";

        }
        private void CargarCombos()
        {

        }


 
        #endregion

        #region Botones
        private void BntAdicionar_Click(object sender, EventArgs e)
        {
            pnlSocio.Visible = false;
            TxtNombres.Text = string.Empty;
            TxtApellidos.Text = string.Empty;
            dtpcumpleaños.Value = DateTime.Now;
            DtpInicio.Value = Convert.ToDateTime("01-01-1900");
            DtpTermino.Value = Convert.ToDateTime("01-01-1900");
            TxtCelular.Text = string.Empty;
           pnlSocio.Visible = false;
            pictDetalle.Image = null;
            ActivaBotones(false, false, false, false, false, true, true, false, false);

            using (Model1 bd = new Model1())
            {
                var Resultado =(from dd in bd.Correlativos
                                select dd).First();

               vCorrelativoSocio =Convert.ToInt32(Resultado.Codigo+1);
               TxtCodigo.Text = Convert.ToString(vCorrelativoSocio);
               vCorrelativoId = Convert.ToInt32(Resultado.codId + 1);
               TxtId.Text = Convert.ToString(vCorrelativoId);

            }
            vAdiciona = true;
            vTipo = 1;
            FuncNet.ActivaTab(2, 5,ref TabSocios);

        }
        private void BntModificar_Click_1(object sender, EventArgs e)
        {
            if (DgvSocios.RowCount == 0)
            {
                MessageBox.Show(" No existe datos a modificar");
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
                TxtCodigo.Text = Convert.ToString(Resultado.Badgenumber );
                               TxtCelular.Text = Resultado.OPHONE;
                TxtCorreo.Text = Resultado.email;
                dtpcumpleaños.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.BIRTHDAY,"01-01-1900"));
                DtpInicio.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.acc_enddate,"01-01-1900"));
                DtpTermino.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.acc_enddate,"01-01-1900"));
            }

            FuncNet.ActivaTab(2, 5, ref TabSocios);

            vAdiciona = false;
            vTipo = 2;
            pnlSocio.Visible = false;
            pictDetalle.Image = FuncNet.byteArrayToImage(imagen);

            ActivaBotones(false, false, false, false, false, true, true, false, false);

        }
        private void BntPagos_Click(object sender, EventArgs e)
        {
            FuncNet.ActivaTab(5, 5, ref TabSocios);
            using (Model1 bd = new Model1())
            {
           
            }
            pictPagos.Image = FuncNet.byteArrayToImage(imagen);
            ActivaBotones(false, false, false, false, false, true, true, false, false);

        }
        private void BntGrabar_Click(object sender, EventArgs e)
        {
            using (Model1 bd = new Model1())
            {
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
                }
                if (vTipo==3)
                {
                    GrabaMembP();
                }
            }
            FuncNet.ActivaTab(1, 5,ref TabSocios);
            ActivaBotones(true, true, true, true, true, false, false, false, true);
            if (vTipo<3)
            {
                if (vTipo == 1)
                {
                    TxtBuscar.Text = TxtCodigo.Text;
                }

            }
        }
        private void BntCancelar_Click(object sender, EventArgs e)
        {
            FuncNet.ActivaTab(1, 5, ref TabSocios);

            ActivaBotones(true, true, true, true, true, false, false, false, true);

        }
        private void BntImprimir_Click(object sender, EventArgs e)
        {
            FuncNet.ActivaTab(1, 5, ref TabSocios);
            using (Model1 bd = new Model1())
            {
           
            }

        }
        private void BntMembPersonal_Click(object sender, EventArgs e)
        {
 
            using (Model1 bd = new Model1())
            {
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                pictPersonal.Image = FuncNet.byteArrayToImage(imagen);

                lLblNombres.Text = DgvSocios.CurrentRow.Cells["Nombres"].Value.ToString();
                lLblNombres.Text+=" "+ DgvSocios.CurrentRow.Cells["Apellidos"].Value.ToString();

                var query = from MemSocio in bd.MembresiasxSocio
                            join Memb in bd.Membresias on MemSocio.MembresiasID equals Memb.ID
                            where MemSocio.UserInfoID ==( vUserId)
                            orderby MemSocio.FechaFinal descending
                            select new { MemSocio.UserInfoID, Memb.Descripcion, MemSocio.FechaInicio, MemSocio.FechaFinal };

                dgvMembPersonal.DataSource = query.ToList();
            }
              FuncNet.ActivaTab(3, 5, ref TabSocios);
            ActivaBotones(false, false, false, false, false, true, true, false, false);

        }
        private void BntImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictDetalle.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BntMembGrupo_Click(object sender, EventArgs e)
        {
            FuncNet.ActivaTab(4, 5, ref TabSocios);
            string vCondicion = FuncNet.Izquierda(Convert.ToString(DateTime.Now), 10);
            ctr_AyuMembGrupo.Filtro = vCondicion + " between InicioVigencia AND TerminoVigencia AND estadoAnulado=0 ";
            ActivaBotones(false, false, false, false, false, true, true, false, false);

        }
        private void BntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Input datos

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (FuncNet.EsNumero(TxtBuscar.Text, 0))
            {
                using (Model1 bd = new Model1())

                                    {

                    var Result = (from dd in bd.USERINFO
                                  where dd.Badgenumber.StartsWith(TxtBuscar.Text)
                                  select new
                                  {dd.USERID,
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
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];
        }



        #endregion


         private void ctr_AyuMembPersonal_AlDevolverDato(object Sender, DataRow e)
        {
            string id = ctr_AyuMembPersonal.Codigo;
            using (Model1 bd = new Model1())
            {
                int vId = Convert.ToInt32(id);

                var Resultado = (from dd in bd.Membresias
                                 join ee in bd.Periodos on dd.PeriodosID equals ee.ID 
                                 where dd.ID ==vId
                                 select new {ee.Meses,ee.Dias,dd.Descripcion,
                                     dd.Precio } ).First();

                TxtPrecio.Text =Convert.ToString( Resultado.Precio);
                TxtMeses.Text = Convert.ToString(Resultado.Meses);
                TxtDias.Text = Convert.ToString(Resultado.Dias);
                DtpInicioMp.Value =DateTime.Now;
             
            }

        }

        private void ctr_AyuMembPersonal_Load(object sender, EventArgs e)
        {

        }

        private void DtpInicioMp_ValueChanged(object sender, EventArgs e)
        {
            int vMeses = Convert.ToInt32(TxtMeses.Text);
            int vDias= Convert.ToInt32(TxtDias.Text);
            DtpTerminoMp.Value = DtpInicioMp.Value.AddMonths(vMeses);
            DtpTerminoMp.Value = DtpTerminoMp.Value.AddMonths(vDias);
            DtpPagoMp.Value = DtpInicioMp.Value.AddDays(-1);

        }

        private void TxtACuentaMp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];

        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];

        }

        private void TxtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];

        }

        private void TxtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)[0];

        }

        private void DgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model1 bd = new Model1())
            {

                vUserId = Convert.ToInt32(DgvSocios.CurrentRow.Cells["Id"].Value);
                var query = from MemSocio in bd.MembresiasxSocio
                            join Memb in bd.Membresias on MemSocio.MembresiasID equals Memb.ID
                            where MemSocio.UserInfoID == vUserId
                            orderby MemSocio.FechaFinal descending
                            select new { MemSocio.UserInfoID, Memb.Descripcion, MemSocio.FechaInicio, MemSocio.FechaFinal };

                DgvMembresias.DataSource = query.ToList();
                DataGridViewImageCell cell = DgvSocios.CurrentRow.Cells["photo"] as DataGridViewImageCell;
                imagen = (byte[])cell.Value;
                pictFoto.Image = FuncNet.byteArrayToImage(imagen);

            }

        }
    }
}
