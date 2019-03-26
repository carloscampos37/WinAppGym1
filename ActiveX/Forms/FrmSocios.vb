Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports AppGym.Models
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports libzkfpcsharp
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports AppGym.Properties
Imports Sample

Namespace AppGym
    Public Partial Class FrmSocios
        Inherits Form

        Private VGCnxSql As String = Settings.[Default].CadenaConexion
        Private Const MESSAGE_CAPTURED_OK As Integer = &H0400 + 6
        Private Const REGISTER_FINGER_COUNT As Integer = 3
        Private bIdentify As Boolean = True
        Private bIsTimeToDie As Boolean = False
        Private blob1 As Byte()
        Private CapTmp As Byte() = New Byte(2047) {}
        Private cbCapTmp As Integer = 2048
        Private cbRegTmp As Integer = 0
        Private FormHandle As IntPtr = IntPtr.Zero
        Private FPBuffer As Byte()
        Private FuncNet As ModFuncNet = New ModFuncNet()
        Private iFid As Integer = 1
        Private imagen As Byte()
        Private IsRegister As Boolean = False
        Private mDBHandle As IntPtr = IntPtr.Zero
        Private mDevHandle As IntPtr = IntPtr.Zero
        Private mfpDpi As Integer = 0
        Private mfpHeight As Integer = 0
        Private mfpWidth As Integer = 0
        Private RegisterCount As Integer = 0
        Private RegTmp As Byte() = New Byte(2047) {}
        Private RegTmps As Byte()() = New Byte(2)() {}
        Private vActualiza As Integer()
        Private vAdiciona As Boolean
        Private vCorrelativoGrupo As Integer
        Private vCorrelativoId As Integer
        Private vCorrelativoSocio As Integer
        Private vHuellas As Integer
        Private vNroHuella As Integer
        Private vTipo As Integer
        Private vUserId As Integer
        <DllImport("user32.dll", EntryPoint:="SendMessageA")>
        Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        Private CaptureDevice As FilterInfoCollection
        Private FinalFrame As VideoCaptureDevice

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FrmSocios_Load(ByVal sender As Object, ByVal e As EventArgs)
            CaptureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)

            If CaptureDevice.Count > 0 Then

                For Each x As FilterInfo In CaptureDevice
                    comboBox1.Items.Add(x.Name)
                Next

                comboBox1.SelectedIndex = 0
            End If

            FormHandle = Me.Handle
            CargarAyudas()
            CargarCombos()
            ActivaBotones(True, True, True, True, True, False, False, False, True)
        End Sub

        Private Sub BntAdicionar_Click(ByVal sender As Object, ByVal e As EventArgs)
            TxtNombres.Text = String.Empty
            TxtApellidos.Text = String.Empty
            DtpNacimiento.Value = DateTime.Now
            DtpInicio.Value = Convert.ToDateTime("01-01-1900")
            DtpTermino.Value = Convert.ToDateTime("01-01-1900")
            TxtCelular.Text = String.Empty
            PicDetalle.Image = Nothing
            InicializaVariables()
            ActivaBotones(False, False, False, False, False, True, True, False, False)

            Using bd As Model1 = New Model1()
                Dim ResultID = (From dd In bd.USERINFO Order By dd.USERID Select dd).FirstOrDefault()
                vCorrelativoSocio = Convert.ToInt32(ResultID.USERID)
                Dim ResultCodigo = (From dd In bd.Zk_Correlativos Select dd).FirstOrDefault()
                TxtCodigo.Text = Convert.ToString(ResultCodigo.Codigo)
                vCorrelativoSocio = Convert.ToInt32(ResultID.USERID + 1)
                vCorrelativoId = Convert.ToInt32(vCorrelativoSocio)
                TxtId.Text = Convert.ToString(vCorrelativoId)
            End Using

            vAdiciona = True
            vTipo = 1
            FuncNet.ActivaTab(2, 5, TabSocios)
        End Sub

        Private Sub BntCamara_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                FinalFrame = New VideoCaptureDevice(CaptureDevice(comboBox1.SelectedIndex).MonikerString)
                AddHandler FinalFrame.NewFrame, New NewFrameEventHandler(AddressOf FinalFrame_NewFrame)
                FinalFrame.Start()
                BntFoto.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub BntCancelar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If BntCierra.Visible = True Then zkfp2.Terminate()
            BntFoto.Visible = False
            FuncNet.ActivaTab(1, 5, TabSocios)
            ActivaBotones(True, True, True, True, True, False, False, False, True)
        End Sub

        Private Sub BntFoto_Click(ByVal sender As Object, ByVal e As EventArgs)
            FinalFrame.[Stop]()
        End Sub

        Private Sub BntGrabar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim vOk As Integer = 1

            If BntCierra.Visible = True Then
                Thread.Sleep(100)
                zkfp2.CloseDevice(mDevHandle)
                zkfp2.Terminate()
            End If

            If FinalFrame IsNot Nothing Then
                If FinalFrame.IsRunning Then FinalFrame.[Stop]()
            End If

            If vTipo <= 2 Then

                If vAdiciona Then
                    GrabaAdiciona()
                Else
                    GrabaModifica()
                End If

                TxtBuscar_TextChanged(sender, e)
            End If

            If vTipo = 3 Then

                If ChkPagototal.Checked <> True Then

                    If TxtACuentaMp.Text Is "" OrElse TxtACuentaMp.Text Is "0" Then
                        MessageBox.Show(" Pago a cuenta con valor 0")
                        vOk = 0
                    End If
                Else

                    If Not (TxtACuentaMp.Text Is "0" OrElse TxtACuentaMp.Text Is "") Then
                        MessageBox.Show(" Pago a cuenta con valor > 0 con Pago TOTAL")
                        vOk = 0
                    End If
                End If

                If vOk = 1 Then GrabaMembP()
            End If

            If vTipo = 4 Then
                GrabaMembG()
            End If

            If vOk = 1 Then
                If TxtDescuento.Text Is "" Then TxtDescuento.Text = "0"

                If Convert.ToDecimal(TxtDescuento.Text) > 0 Then
                    ActivaBotones(False, False, False, False, False, False, True, True, False)
                Else
                    FuncNet.ActivaTab(1, 5, TabSocios)
                    ActivaBotones(True, True, True, True, True, False, False, False, True)
                End If

                If vTipo = 1 Then
                    TxtBuscar.Text = TxtCodigo.Text
                End If

                If vTipo = 3 Then
                    TxtBuscar.Text = LblCodigo.Text
                End If

                BntFoto.Visible = False
                ChkHuellas.Checked = False
            End If
        End Sub

        Private Sub BntImagen_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                FinalFrame = New VideoCaptureDevice(CaptureDevice(comboBox1.SelectedIndex).MonikerString)
                AddHandler FinalFrame.NewFrame, New NewFrameEventHandler(AddressOf FinalFrame_NewFrame)
                FinalFrame.Start()
                BntFoto.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub BntImprimir_Click(ByVal sender As Object, ByVal e As EventArgs)
            FuncNet.ActivaTab(1, 5, TabSocios)

            Using bd As Model1 = New Model1()
            End Using
        End Sub

        Private Sub BntInicializa_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                bIdentify = True
                InicializaSensor()
                BntActivar.Visible = True
                BntCierra.Visible = True
                BntCancelarH.Visible = True
                BntInicializa.Visible = False
            Catch
            End Try
        End Sub

        Private Sub ActivaSensor()
            Dim ret As Integer = zkfp.ZKFP_ERR_OK

            If IntPtr.Zero = (CSharpImpl.__Assign(mDevHandle, zkfp2.OpenDevice(cmbIdx.SelectedIndex))) Then
                MessageBox.Show("Enrrolador Fallo")
                Return
            End If

            If IntPtr.Zero = (CSharpImpl.__Assign(mDBHandle, zkfp2.DBInit())) Then
                MessageBox.Show("Init DB fail")
                zkfp2.CloseDevice(mDevHandle)
                mDevHandle = IntPtr.Zero
                Return
            End If

            RegisterCount = 0
            cbRegTmp = 0
            iFid = 1

            For i As Integer = 0 To 3 - 1
                RegTmps(i) = New Byte(2047) {}
            Next

            Dim paramValue As Byte() = New Byte(3) {}
            Dim size As Integer = 4
            zkfp2.GetParameters(mDevHandle, 1, paramValue, size)
            zkfp2.ByteArray2Int(paramValue, mfpWidth)
            size = 4
            zkfp2.GetParameters(mDevHandle, 2, paramValue, size)
            zkfp2.ByteArray2Int(paramValue, mfpHeight)
            FPBuffer = New Byte(mfpWidth * mfpHeight - 1) {}
            size = 4
            zkfp2.GetParameters(mDevHandle, 3, paramValue, size)
            zkfp2.ByteArray2Int(paramValue, mfpDpi)
            TxtHuella.Text = "reader parameter, image width:" & mfpWidth & ", height:" & mfpHeight & ", dpi:" & mfpDpi & " "
            Dim captureThread As Thread = New Thread(New ThreadStart(AddressOf DoCapture))
            captureThread.IsBackground = True
            captureThread.Start()
            bIsTimeToDie = False
            TxtHuella.Text = ""
        End Sub

        Private Sub BntMembGrupo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using bd As Model1 = New Model1()
                vTipo = 4
                ChkPagoTotalG.Checked = False
                ctr_AyuMembGrupo.Filtro = " MembresiaGrupo=1 AND EstadoAnulado=0 "
                FuncNet.ActivaTab(4, 5, TabSocios)
                ActivaBotones(False, False, False, False, False, True, True, False, False)
            End Using
        End Sub

        Private Sub BntMembPersonal_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using bd As Model1 = New Model1()
                Dim cell As DataGridViewImageCell = TryCast(DgvSocios.CurrentRow.Cells("photo"), DataGridViewImageCell)
                imagen = CType(cell.Value, Byte())
                If imagen IsNot Nothing Then pictPersonal.Image = FuncNet.byteArrayToImage(imagen)
                LblCodigo.Text = DgvSocios.CurrentRow.Cells("Codigo").Value.ToString()
                LblNombres.Text = DgvSocios.CurrentRow.Cells("Nombres").Value.ToString()
                LblNombres.Text += " " & DgvSocios.CurrentRow.Cells("Apellidos").Value.ToString()
                Dim query = From MemSocio In bd.Zk_MembresiasxSocio Join Memb In bd.Zk_Membresias On MemSocio.MembresiasID Equals Memb.ID Where MemSocio.UserInfoID = (vUserId) Order By MemSocio.FechaFinal Select New With {MemSocio.UserInfoID, Memb.DescripcionMembresias, MemSocio.FechaInicio, MemSocio.FechaFinal
                }
                dgvMembPersonal.DataSource = query.ToList()
            End Using

            vTipo = 3
            ChkPagototal.Checked = False
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql
            ctr_AyuMembPersonal.Filtro = " MembresiaGrupo=0 AND EstadoAnulado=0 "
            FuncNet.ActivaTab(3, 5, TabSocios)
            ActivaBotones(False, False, False, False, False, True, True, False, False)
        End Sub

        Private Sub BntModificar_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            If DgvSocios.RowCount = 0 Then
                MessageBox.Show(" No existe datos a modificar")
                Return
            ElseIf vUserId = 0 Then
                MessageBox.Show(" Active socio a Modificar")
                Return
            End If

            Using bd As Model1 = New Model1()
                Dim Resultado = (From dato In bd.USERINFO Where dato.USERID = (vUserId) Select dato).First()
                TxtApellidos.Text = Resultado.lastname
                TxtNombres.Text = Resultado.Name
                TxtId.Text = Convert.ToString(Resultado.USERID)
                TxtCodigo.Text = Convert.ToString(Resultado.Badgenumber)
                TxtCelular.Text = Resultado.OPHONE
                TxtCorreo.Text = Resultado.email
                ChkBaja.Checked = Convert.ToBoolean(Resultado.status)
                DtpBaja.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.delete_time, "01-01-1900"))
                DtpNacimiento.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.BIRTHDAY, "01-01-1900"))
                DtpInicio.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.acc_enddate, "01-01-1900"))
                DtpTermino.Value = Convert.ToDateTime(FuncNet.EsNulo(Resultado.acc_enddate, "01-01-1900"))
                InicializaVariables()
            End Using

            FuncNet.ActivaTab(2, 5, TabSocios)
            vAdiciona = False
            ChkBaja.Visible = True
            vTipo = 2
            PicDetalle.Image = FuncNet.byteArrayToImage(imagen)
            ActivaBotones(False, False, False, False, False, True, True, False, False)
        End Sub

        Private Sub BntPagos_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using bd As Model1 = New Model1()
                Dim cell As DataGridViewImageCell = TryCast(DgvSocios.CurrentRow.Cells("photo"), DataGridViewImageCell)
                imagen = CType(cell.Value, Byte())
                PicPagos.Image = FuncNet.byteArrayToImage(imagen)
                LblCodigoP.Text = DgvSocios.CurrentRow.Cells("Codigo").Value.ToString()
                LblNombresP.Text = DgvSocios.CurrentRow.Cells("Nombres").Value.ToString()
                LblNombresP.Text += " " & DgvSocios.CurrentRow.Cells("Apellidos").Value.ToString()
                Dim query = From MemSocio In bd.Zk_MembresiasxSocio Join Memb In bd.Zk_Membresias On MemSocio.MembresiasID Equals Memb.ID Join pagos In bd.Zk_PagosSocios On MemSocio.ID Equals pagos.MembresiasxSocioID Where (MemSocio.UserInfoID = vUserId) Order By MemSocio.FechaFinal Select New With {MemSocio.UserInfoID, Memb.DescripcionMembresias, MemSocio.FechaInicio, MemSocio.FechaFinal, MemSocio.PrecioPactado, MemSocio.Saldo, pagos.ImportePagado
                }
                DgvPagos.DataSource = query.ToList()
            End Using

            FuncNet.ActivaTab(5, 5, TabSocios)

            Using bd As Model1 = New Model1()
            End Using

            PicPagos.Image = FuncNet.byteArrayToImage(imagen)
            ActivaBotones(False, False, False, False, False, True, True, False, False)
        End Sub

        Private Sub BntSalir_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub BntSocios_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub ctr_AyuMembGrupo_AlDevolverDato(ByVal Sender As Object, ByVal e As DataRow)
            Using bd As Model1 = New Model1()
                Dim vCodigo As String = Convert.ToString(ctr_AyuSocios.Codigo)
                Dim Resultado = (From user In bd.USERINFO Where user.Badgenumber Is vCodigo Select New With {user.USERID, user.Name, user.lastname
                }).First()
            End Using
        End Sub

        Private Sub ctr_AyuMembGrupo_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub ctr_AyuMembPersonal_AlDevolverDato(ByVal Sender As Object, ByVal e As DataRow)
            Dim id As String = ctr_AyuMembPersonal.Codigo

            Using bd As Model1 = New Model1()
                Dim vId As Integer = Convert.ToInt32(id)
                Dim Resultado = (From dd In bd.Zk_Membresias Join ee In bd.Zk_Periodos On dd.PeriodosID Equals ee.ID Where dd.ID = vId Select New With {ee.Meses, ee.Dias, dd.DescripcionMembresias, dd.Precio
                }).First()
                TxtPrecio.Text = Convert.ToString(Resultado.Precio)
                TxtMeses.Text = Convert.ToString(Resultado.Meses)
                TxtDias.Text = Convert.ToString(Resultado.Dias)
                DtpInicioMp.Value = DateTime.Now
            End Using
        End Sub

        Private Sub ChkAutorizacionG_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChkAutorizacionG.Checked = True Then
                LblDescuentoG.Visible = True
                TxtDescuentoG.Visible = True
            Else
                LblDescuentoG.Visible = False
                TxtDescuentoG.Visible = False
            End If
        End Sub

        Private Sub DgvSocios_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
            Using bd As Model1 = New Model1()
                vUserId = Convert.ToInt32(DgvSocios.CurrentRow.Cells("Id").Value)
                Dim query = From MemSocio In bd.Zk_MembresiasxSocio Join Memb In bd.Zk_Membresias On MemSocio.MembresiasID Equals Memb.ID Where MemSocio.UserInfoID = vUserId Order By MemSocio.FechaFinal Select New With {MemSocio.UserInfoID, Memb.DescripcionMembresias, MemSocio.FechaInicio, MemSocio.FechaFinal
                }
                DgvMembresias.DataSource = query.ToList()
                Dim cell As DataGridViewImageCell = TryCast(DgvSocios.CurrentRow.Cells("photo"), DataGridViewImageCell)
                imagen = CType(cell.Value, Byte())
                pictFoto.Image = FuncNet.byteArrayToImage(imagen)
            End Using
        End Sub

        Private Sub DtpInicioMG_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim vMeses As Integer = Convert.ToInt32(TxtMeses.Text)
            Dim vDias As Integer = Convert.ToInt32(TxtDias.Text)
            DtpTerminoMG.Value = DtpInicioMG.Value.AddMonths(vMeses)
            DtpTerminoMG.Value = DtpTerminoMG.Value.AddDays(vDias)
            DtpMaxPagoMG.Value = DtpInicioMG.Value.AddDays(-1)
        End Sub

        Private Sub DtpInicioMp_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim vMeses As Integer = Convert.ToInt32(TxtMeses.Text)
            Dim vDias As Integer = Convert.ToInt32(TxtDias.Text)
            DtpTerminoMp.Value = DtpInicioMp.Value.AddMonths(vMeses)
            DtpTerminoMp.Value = DtpTerminoMp.Value.AddDays(vDias)
            DtpMaxPagoMp.Value = DtpInicioMp.Value.AddDays(-1)
        End Sub

        Private Sub TxtBuscar_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If FuncNet.EsNumero(TxtBuscar.Text, 0) Then

                Using bd As Model1 = New Model1()
                    Dim Result = (From dd In bd.USERINFO Where dd.Badgenumber.StartsWith(TxtBuscar.Text) Select New With {dd.USERID, dd.Badgenumber, dd.Name, dd.lastname, dd.acc_startdate, dd.acc_enddate, dd.PHOTO
                    })
                    DgvSocios.DataSource = Result.ToList()
                End Using
            Else

                If Not (TxtBuscar.Text Is "") Then

                    Using bd As Model1 = New Model1()
                        Dim Resultado = (From dd In bd.USERINFO Where dd.lastname.Contains(TxtBuscar.Text) Select New With {dd.USERID, dd.Badgenumber, dd.Name, dd.lastname, dd.acc_startdate, dd.acc_enddate, dd.PHOTO
                        })
                        DgvSocios.DataSource = Resultado.ToList()
                    End Using
                End If
            End If
        End Sub

        Private Sub ChkAutorizacion_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChkAutorizacion.Checked = True Then
                LblDescuento.Visible = True
                TxtDescuento.Visible = True
                TxtReferencia.Visible = True
                LblReferencia.Visible = True
            Else
                LblDescuento.Visible = False
                TxtDescuento.Visible = False
                TxtReferencia.Visible = False
                LblReferencia.Visible = False
            End If
        End Sub

        Private Sub ChkBaja_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            DtpBaja.Visible = ChkBaja.Checked
        End Sub

        Private Sub ChkPagoTotalG_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChkPagoTotalG.Checked = False Then
                DtpMaxPagoMG.Visible = True
                TxtACuentaMG.Visible = True
                TxtACuentaMG.Text = "0"
            Else
                DtpMaxPagoMG.Visible = False
                TxtACuentaMG.Visible = False
                TxtACuentaMG.Text = "0"
            End If
        End Sub

        Private Sub TxtApellidos_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)(0)
        End Sub

        Private Sub TxtBuscar_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)(0)
        End Sub

        Private Sub TxtNombres_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)(0)
        End Sub

        Private Sub TxtReferencia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)(0)
        End Sub

        Private Sub TxtReferenciaG_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray(0, 1)(0)
        End Sub

        Private Sub BntCancelarH_Click(ByVal sender As Object, ByVal e As EventArgs)
            bIsTimeToDie = True
            RegisterCount = 0
            Thread.Sleep(500)
            zkfp2.CloseDevice(mDevHandle)
            zkfp2.Terminate()
            cbRegTmp = 0
            BntRegistrar.Visible = False
            PicHuellas.Visible = False
            BntGrabarH.Visible = False
            BntCancelarH.Visible = False
        End Sub

        Private Sub BntGrabarH_Click(ByVal sender As Object, ByVal e As EventArgs)
            vHuellas = 0

            Select Case vNroHuella
                Case 0
                    BntHuella0.BackColor = Color.Orange
                Case 1
                    BntHuella1.BackColor = Color.Orange
                Case 2
                    BntHuella2.BackColor = Color.Orange
                Case 3
                    BntHuella3.BackColor = Color.Orange
                Case 4
                    BntHuella4.BackColor = Color.Orange
                Case 5
                    BntHuella5.BackColor = Color.Orange
                Case 6
                    BntHuella6.BackColor = Color.Orange
                Case 7
                    BntHuella7.BackColor = Color.Orange
                Case 8
                    BntHuella8.BackColor = Color.Orange
                Case 9
                    BntHuella9.BackColor = Color.Orange
            End Select

            BntRegistrar.Visible = True
            BntGrabarH.Visible = False
            BntCancelarH.Visible = False
            blob1 = zkfp.Base64String2Blob(textRes.Text)
            GrabarHuella(vNroHuella, blob1)
        End Sub

        Private Sub BntHuella0_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella0, 0)
        End Sub

        Private Sub BntHuella1_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella1, 1)
        End Sub

        Private Sub BntHuella2_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella2, 2)
        End Sub

        Private Sub BntHuella3_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella3, 3)
        End Sub

        Private Sub BntHuella4_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella4, 4)
        End Sub

        Private Sub BntHuella5_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella5, 5)
        End Sub

        Private Sub BntHuella6_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella6, 6)
        End Sub

        Private Sub BntHuella7_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella7, 7)
        End Sub

        Private Sub BntHuella8_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella8, 8)
        End Sub

        Private Sub BntHuella9_Click(ByVal sender As Object, ByVal e As EventArgs)
            CambiarColorTextBox(BntHuella9, 9)
        End Sub

        Private Sub BtnReg_Click(ByVal sender As Object, ByVal e As EventArgs)
            TxtHuella.Text = "start register"
        End Sub

        Private Sub CambiarColorTextBox(ByRef Bnt As System.Windows.Forms.TextBox, ByVal vNro As Integer)
            Select Case Bnt.BackColor.Name
                Case "Orange"
                    If vHuellas = 1 Then Return

                    If PreguntarHuella() Then
                        EliminaHuella(vNro)
                        Bnt.BackColor = Color.Yellow
                        vHuellas = 1
                    End If

                Case "White"

                    If vHuellas = 1 Then
                        Return
                    End If

                    Bnt.BackColor = Color.Yellow
                    vHuellas = 1
                Case "Yellow"
                    Bnt.BackColor = Color.White
                    vHuellas = 0
                Case "Control"
                    If vHuellas = 1 Then Return
                    Bnt.BackColor = Color.Yellow
                    vHuellas = 1
            End Select

            If Bnt.BackColor.Name Is "Yellow" Then
                BntInicializa.Visible = True
                BntCancelarH.Visible = True
                PicHuellas.Visible = True
                PicHuellas.Image = Nothing
                vNroHuella = vNro
            Else
                BntRegistrar.Visible = False
                PicHuellas.Visible = False
            End If
        End Sub

        Private Sub ChkHuellas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            PnlHuellas.Visible = ChkHuellas.Checked

            If ChkHuellas.Checked Then

                If vAdiciona = False Then
                    PicHuellas.Image = Nothing
                    TxtHuella.Text = ""
                    ObtenerHuellas()
                End If
            End If
        End Sub

        Private Sub EliminaHuella(ByVal ii As Integer)
            Using bd As Model1 = New Model1()
                bd.TEMPLATE.RemoveRange(bd.TEMPLATE.Where(Function(p) p.USERID = vUserId AndAlso p.FINGERID = ii))
                bd.SaveChanges()
            End Using
        End Sub

        Private Sub GrabarHuella(ByVal vNro As Integer, ByVal blob1 As Byte())
            Using Bd As Model1 = New Model1()
                Dim user As TEMPLATE = New TEMPLATE()
                If vAdiciona = True Then vUserId = Convert.ToInt32(TxtId.Text)
                user.USERID = vUserId
                user.FINGERID = vNro
                user.USETYPE = 0
                user.Flag = 1
                user.DivisionFP = 10
                user.status = 0
                user.Valid = 1
                user.Fpversion = "10"
                user.bio_type = 0
                user.SN = 0
                user.TEMPLATE3 = blob1
                user.TEMPLATE4 = blob1
                Bd.TEMPLATE.Add(user)
                Bd.SaveChanges()
            End Using
        End Sub

        Private Function InicializaHuella() As Boolean
            Try

                If Not IsRegister Then
                    RegisterCount = 0
                    cbRegTmp = 0
                    textRes.Text = ""
                    TxtHuella.Text = "Presione 3 veces el enrrolador !! "
                    IsRegister = True
                    Return True
                Else
                    IsRegister = False
                    Return False
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Function

        Private Function InicializaSensor() As Boolean
            Try
                cmbIdx.Items.Clear()
                Dim ret As Integer = zkfperrdef.ZKFP_ERR_OK

                If zkfp2.Init() = zkfperrdef.ZKFP_ERR_OK Then
                    Dim nCount As Integer = zkfp2.GetDeviceCount()

                    If nCount > 0 Then

                        For i As Integer = 0 To nCount - 1
                            cmbIdx.Items.Add(i.ToString())
                        Next

                        cmbIdx.SelectedIndex = 0
                        Return True
                    Else
                        bIsTimeToDie = True
                        RegisterCount = 0
                        Thread.Sleep(500)
                        zkfp2.CloseDevice(mDevHandle)
                        zkfp2.Terminate()
                        MessageBox.Show("No device connected!")
                        Return False
                    End If
                Else
                    zkfp2.CloseDevice(mDevHandle)
                    zkfp2.Terminate()
                    MessageBox.Show("Inicializacion Fallo, ERROR Nro. =" & ret & " !")
                    Return False
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Function

        Private Sub InicializaVariables()
            BntHuella0.BackColor = Color.White
            BntHuella1.BackColor = Color.White
            BntHuella2.BackColor = Color.White
            BntHuella3.BackColor = Color.White
            BntHuella4.BackColor = Color.White
            BntHuella5.BackColor = Color.White
            BntHuella6.BackColor = Color.White
            BntHuella7.BackColor = Color.White
            BntHuella8.BackColor = Color.White
            BntHuella9.BackColor = Color.White
            vActualiza = New Integer(9) {}
            ChkHuellas.Checked = False
            vHuellas = 0
        End Sub

        Private Sub MostrarHuellas(ByVal i As Integer)
            Select Case i
                Case 0
                    BntHuella0.BackColor = Color.Orange
                Case 1
                    BntHuella1.BackColor = Color.Orange
                Case 2
                    BntHuella2.BackColor = Color.Orange
                Case 3
                    BntHuella3.BackColor = Color.Orange
                Case 4
                    BntHuella4.BackColor = Color.Orange
                Case 5
                    BntHuella5.BackColor = Color.Orange
                Case 6
                    BntHuella6.BackColor = Color.Orange
                Case 7
                    BntHuella7.BackColor = Color.Orange
                Case 8
                    BntHuella8.BackColor = Color.Orange
                Case 9
                    BntHuella9.BackColor = Color.Orange
            End Select
        End Sub

        Private Sub ObtenerHuellas()
            Using bd As Model1 = New Model1()
                Dim Resultado = (From temp In bd.TEMPLATE Where temp.USERID = vUserId Select temp)

                For Each res In Resultado
                    MostrarHuellas(res.FINGERID)
                Next
            End Using
        End Sub

        Private Function PreguntarHuella() As Boolean
            If MessageBox.Show("desea ELIMINAR huella", " Si / No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub TxtDescuento_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            If e.KeyChar = Convert.ToChar(13) Then

                If FuncNet.EsNumero(TxtDescuento.Text, 0) Then

                    If Not (Convert.ToInt32(TxtDescuento.Text) = 0) Then
                        ctr_AyuAutorizacion.Visible = True
                    Else
                        ctr_AyuAutorizacion.Visible = False
                    End If
                Else
                    MessageBox.Show(" dato debe ser numero y mayor a cero")
                End If
            End If
        End Sub

        Private Sub DoCapture()
            While Not bIsTimeToDie
                cbCapTmp = 2048
                Dim ret As Integer = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, cbCapTmp)

                If ret = zkfp.ZKFP_ERR_OK Then
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero)
                End If

                Thread.Sleep(500)
            End While
        End Sub

        Protected Overrides Sub DefWndProc(ByRef m As Message)
            Select Case m.Msg
                Case MESSAGE_CAPTURED_OK
                    Dim ms As MemoryStream = New MemoryStream()
                    BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ms)
                    Dim bmp As Bitmap = New Bitmap(ms)
                    Me.PicHuellas.Image = bmp
                    Dim strShow As String = zkfp2.BlobToBase64(CapTmp, cbCapTmp)

                    If IsRegister Then
                        Dim ret As Integer = zkfp.ZKFP_ERR_OK
                        Dim fid As Integer = 0, score As Integer = 0
                        ret = zkfp2.DBIdentify(mDBHandle, CapTmp, fid, score)

                        If zkfp.ZKFP_ERR_OK = ret Then
                            TxtHuella.Text = "PASO 1: El enrrolador ya esta registrado por  " & fid & "! "
                        End If

                        If RegisterCount > 0 AndAlso zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps(RegisterCount - 1)) <= 0 Then
                            TxtHuella.Text = "Please press the same finger 3 times for the enrollment "
                            Return
                        End If

                        Array.Copy(CapTmp, RegTmps(RegisterCount), cbCapTmp)
                        Dim strBase64 As String = zkfp2.BlobToBase64(CapTmp, cbCapTmp)
                        Dim blob As Byte() = zkfp2.Base64ToBlob(strBase64)
                        RegisterCount += 1

                        If RegisterCount >= REGISTER_FINGER_COUNT Then
                            RegisterCount = 0

                            If zkfp.ZKFP_ERR_OK = (CSharpImpl.__Assign(ret, zkfp2.DBMerge(mDBHandle, RegTmps(0), RegTmps(1), RegTmps(2), RegTmp, cbRegTmp))) AndAlso zkfp.ZKFP_ERR_OK = (CSharpImpl.__Assign(ret, zkfp2.DBAdd(mDBHandle, iFid, RegTmp))) Then
                                iFid += 1
                                textRes.Text = strShow
                                MessageBox.Show("enrolador OK " & vbLf)
                                BntGrabarH.Visible = True
                            Else
                                TxtHuella.AppendText("enrrolador fallo, codigo error =" & ret & vbLf)
                            End If

                            IsRegister = False
                            Return
                        Else
                            TxtHuella.Text = "Necesita continuar presione " & (REGISTER_FINGER_COUNT - RegisterCount) & " veces el enrrolador "
                        End If
                    Else

                        If cbRegTmp <= 0 Then
                            TxtHuella.Text = "Registre su enrrolador primero"
                            Return
                        End If

                        If bIdentify Then
                            Dim ret As Integer = zkfp.ZKFP_ERR_OK
                            Dim fid As Integer = 0, score As Integer = 0
                            ret = zkfp2.DBIdentify(mDBHandle, CapTmp, fid, score)

                            If zkfp.ZKFP_ERR_OK = ret Then
                                textRes.AppendText("Identify succ, fid= " & fid & ",score=" & score & "!" & vbLf)
                                Return
                            Else
                                textRes.AppendText("Identify fail, ret= " & ret & vbLf)
                                Return
                            End If
                        Else
                            Dim ret As Integer = zkfp2.DBMatch(mDBHandle, CapTmp, RegTmp)

                            If 0 < ret Then
                                textRes.AppendText("Match finger succ, score=" & ret & "!" & vbLf)
                                Return
                            Else
                                textRes.AppendText("Match finger fail, ret= " & ret & vbLf)
                                Return
                            End If
                        End If
                    End If

                Case Else
                    MyBase.DefWndProc(m)
            End Select
        End Sub

        Private Sub ActivaBotones(ByVal adicionar As Boolean, ByVal modificar As Boolean, ByVal membp As Boolean, ByVal membg As Boolean, ByVal pagar As Boolean, ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal imprimir As Boolean, ByVal salir As Boolean)
            BntAdicionar.Visible = adicionar
            BntModificar.Visible = modificar
            BntMembPersonal.Visible = membp
            BntMembGrupo.Visible = membg
            BntPagos.Visible = pagar
            BntGrabar.Visible = guardar
            BntCancelar.Visible = cancelar
            BntImprimir.Visible = imprimir
            BntSalir.Visible = salir
        End Sub

        Private Sub AdicionaPagos(ByVal vtotal As Boolean)
            Using bd As Model1 = New Model1()
                Dim Resultado = (From dd In bd.Zk_MembresiasxSocio Order By dd.ID Select New With {dd.ID
                }).FirstOrDefault()
                Dim corr As Integer = Resultado.ID
                Dim pagossocios As Zk_PagosSocios = New Zk_PagosSocios()
                pagossocios.MembresiasxSocioID = corr
                pagossocios.EstadoAnulado = False
                pagossocios.FormaPagoID = 1
                pagossocios.NroCuota = 1
                pagossocios.TurnoID = 1
                pagossocios.Referencia = TxtReferencia.Text
                pagossocios.FechaPago = (DateTime.Now).Date

                If vtotal = True Then
                    pagossocios.ImportePagado = Convert.ToDecimal(TxtPrecio.Text) - Convert.ToDecimal(TxtDescuento.Text)
                Else
                    pagossocios.ImportePagado = Convert.ToDecimal(TxtACuentaMp.Text)
                End If

                bd.Zk_PagosSocios.Add(pagossocios)
                bd.SaveChanges()
            End Using
        End Sub

        Private Sub BajaFechaTermino(ByVal FechaBaja As DateTime)
            Using bd As Model1 = New Model1()
                Dim vfecha As DateTime = Convert.ToDateTime(FechaBaja.Date)
                Dim Result = (From membsocio In bd.Zk_MembresiasxSocio Where membsocio.FechaFinal > vfecha Select New With {membsocio.UserInfoID, membsocio.ID, membsocio.FechaFinal
                }).ToList()

                For i As Integer = 0 To Result.Count - 1 - 1
                Next

                bd.SaveChanges()
            End Using
        End Sub

        Private Sub CargarAyudas()
            ctr_AyuMembPersonal.CadenaCone = VGCnxSql
            ctr_AyuMembGrupo.CadenaCone = VGCnxSql
            ctr_AyuSocios.CadenaCone = VGCnxSql
            ctr_AyuAutorizacion.CadenaCone = VGCnxSql
        End Sub

        Private Sub CargarCombos()
        End Sub

        Private Function CrearTabla() As DataTable
            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("Item", Type.[GetType]("System.Int32"))
            dt.Columns.Add("Id", Type.[GetType]("System.Int32"))
            dt.Columns.Add("CodigoG", Type.[GetType]("System.String"))
            dt.Columns.Add("Name", Type.[GetType]("System.String"))
            dt.Columns.Add("LastName", Type.[GetType]("System.String"))
            Return dt
        End Function

        Private Sub FinalFrame_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
            PicDetalle.Image = CType(eventArgs.Frame.Clone(), Bitmap)
        End Sub

        Private Sub GrabaAdiciona()
            Using bd As Model1 = New Model1()
                Dim user As USERINFO = New USERINFO()
                user.Badgenumber = TxtCodigo.Text
                user.Name = TxtNombres.Text
                user.lastname = TxtApellidos.Text
                user.BIRTHDAY = Convert.ToDateTime(DtpNacimiento.Text)
                user.email = TxtCorreo.Text
                user.Gender = TxtGenero.Text
                user.OPHONE = TxtCelular.Text

                If PicDetalle.Image Is Nothing Then
                    user.PHOTO = Nothing
                Else
                    user.PHOTO = FuncNet.ImageTobyteArray(PicDetalle.Image)
                End If

                user.DEFAULTDEPTID = 2
                user.ATT = 1
                user.INLATE = 1
                user.OUTEARLY = 1
                user.OVERTIME = 1
                user.SEP = 1
                user.HOLIDAY = 1
                user.privilege = 0
                user.AutoSchPlan = 1
                user.MinAutoSchInterval = 24
                user.RegisterOT = 1
                user.status = 0
                bd.USERINFO.Add(user)
                bd.SaveChanges()
                Dim Resultado = (From dd In bd.Zk_Correlativos Select dd).First()
                Resultado.codId += 1
                Resultado.Codigo += 1
                bd.SaveChanges()
                Dim Result = bd.USERINFO.OrderByDescending(Function(t) t.USERID).FirstOrDefault()
                Dim vCodId As Integer = Result.USERID
                Dim level As acc_levelset_emp = New acc_levelset_emp()
                level.employee_id = vCodId
                level.acclevelset_id = 1
                bd.acc_levelset_emp.Add(level)
                bd.SaveChanges()
            End Using
        End Sub

        Private Sub GrabaMembG()
            Using bd As Model1 = New Model1()
                Dim membsocio As Zk_MembresiasxSocio = New Zk_MembresiasxSocio With {
                    .UserInfoID = vUserId,
                    .MembresiasID = Convert.ToInt32(ctr_AyuMembPersonal.Codigo),
                    .FechaInicio = DtpInicioMp.Value,
                    .FechaFinal = DtpTerminoMp.Value,
                    .fechaMaximadePago = DtpMaxPagoMp.Value
                }

                If TxtDescuento.Text Is "" Then
                    TxtDescuento.Text = "0"
                End If

                membsocio.Precio = Convert.ToDecimal(TxtPrecio.Text)
                membsocio.descuento = Convert.ToDecimal(TxtDescuento.Text)
                membsocio.PrecioPactado = membsocio.Precio - membsocio.descuento

                If ChkPagototal.Checked Then
                    membsocio.EstadoCancelacion = True
                Else
                    membsocio.EstadoCancelacion = False
                End If

                bd.Zk_MembresiasxSocio.Add(membsocio)
                bd.SaveChanges()

                If ChkPagototal.Checked Then
                    AdicionaPagos(True)
                Else
                    AdicionaPagos(False)
                End If

                Dim user = (From dato In bd.USERINFO Where dato.USERID = (vUserId) Select dato).First()
                user.acc_startdate = DtpInicioMp.Value
                user.acc_enddate = DtpTerminoMp.Value
                bd.SaveChanges()
            End Using
        End Sub

        Private Sub GrabaMembP()
            Using bd As Model1 = New Model1()
                Dim membsocio As Zk_MembresiasxSocio = New Zk_MembresiasxSocio()
                membsocio.UserInfoID = vUserId
                Dim vId As Integer = Convert.ToInt32(ctr_AyuMembPersonal.Codigo)
                membsocio.MembresiasID = vId
                membsocio.FechaInicio = Convert.ToDateTime(DtpInicioMp.Text)
                membsocio.FechaFinal = Convert.ToDateTime(DtpTerminoMp.Text)
                membsocio.fechaMaximadePago = Convert.ToDateTime(DtpMaxPagoMp.Text)

                If TxtDescuento.Text Is "" Then
                    TxtDescuento.Text = "0"
                End If

                membsocio.Precio = Convert.ToDecimal(TxtPrecio.Text)
                membsocio.descuento = Convert.ToDecimal(TxtDescuento.Text)
                membsocio.PrecioPactado = membsocio.Precio - membsocio.descuento
                membsocio.UsuarioID = 1

                If ChkPagototal.Checked Then
                    membsocio.Saldo = 0
                    membsocio.EstadoCancelacion = True
                Else
                    membsocio.Saldo = membsocio.PrecioPactado - Convert.ToDecimal(TxtACuentaMp.Text)
                    membsocio.EstadoCancelacion = False
                End If

                membsocio.NroCuota = 1
                Dim vIdAutorizacion As Integer = 1

                If ctr_AyuAutorizacion.Codigo IsNot "" Then
                    vIdAutorizacion = Convert.ToInt16(ctr_AyuAutorizacion.Codigo)
                End If

                membsocio.AutorizacionesID = vIdAutorizacion
                membsocio.FechaAct = DateTime.Now
                membsocio.Activacion = False
                bd.Zk_MembresiasxSocio.Add(membsocio)
                bd.SaveChanges()

                If ChkPagototal.Checked Then
                    AdicionaPagos(True)
                Else
                    AdicionaPagos(False)
                End If

                Dim user = (From dato In bd.USERINFO Where dato.USERID = (vUserId) Select dato).First()
                user.acc_startdate = Convert.ToDateTime(DtpInicioMp.Text)
                user.acc_enddate = Convert.ToDateTime(DtpTerminoMp.Text)
                bd.SaveChanges()
            End Using
        End Sub

        Private Sub GrabaModifica()
            Using bd As Model1 = New Model1()
                Dim user = (From dato In bd.USERINFO Where dato.USERID = (vUserId) Select dato).First()
                user.Badgenumber = TxtCodigo.Text
                user.Name = TxtNombres.Text
                user.lastname = TxtApellidos.Text
                user.BIRTHDAY = Convert.ToDateTime(DtpNacimiento.Text)
                user.email = TxtCorreo.Text
                user.Gender = TxtGenero.Text
                user.OPHONE = TxtCelular.Text

                If PicDetalle.Image Is Nothing Then
                    user.PHOTO = Nothing
                Else
                    user.PHOTO = FuncNet.ImageTobyteArray(PicDetalle.Image)
                End If

                If ChkBaja.Checked = True Then
                    user.delete_time = DtpBaja.Value.Date
                    user.status = 1
                    user.hiretype = 1
                    user.acc_enddate = DtpBaja.Value.Date
                    BajaFechaTermino(DtpBaja.Value.Date)
                Else
                    user.delete_time = Convert.ToDateTime("01-01-1900")
                    user.status = 0
                    user.hiretype = 0
                End If

                bd.SaveChanges()
            End Using

            If FinalFrame IsNot Nothing Then

                If FinalFrame.IsRunning Then
                    FinalFrame.[Stop]()
                End If
            End If
        End Sub

        Private Sub WebCamCapture_ImageCaptured(ByVal source As Object, ByVal e As WebcamEventArgs)
            Me.PicDetalle.Image = e.WebCamImage
        End Sub

        Private Sub BntActivar_Click(ByVal sender As Object, ByVal e As EventArgs)
            ActivaSensor()
            BntRegistrar.Visible = True
            BntFinaliza.Visible = True
            BntActivar.Visible = False
        End Sub

        Private Sub BntRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If InicializaHuella() = True Then
                BntRegistrar.Visible = False
            End If
        End Sub

        Private Sub BntFinaliza_Click(ByVal sender As Object, ByVal e As EventArgs)
            bIsTimeToDie = False
            IsRegister = False
            Dim reg1 As Integer = zkfp2.DBFree(mDevHandle)
            Dim reg As Integer = zkfp2.DBClear(mDevHandle)
            RegisterCount = 0
            zkfp2.CloseDevice(mDevHandle)
            BntActivar.Visible = True
            BntFinaliza.Visible = False
        End Sub

        Private Sub BntCierra_Click(ByVal sender As Object, ByVal e As EventArgs)
            zkfp2.Terminate()
            cmbIdx.Items.Clear()
            cbRegTmp = 0
            BntInicializa.Visible = True
            BntCierra.Visible = False
            BntActivar.Visible = False
        End Sub

        Private Sub PnlHuellas_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        End Sub

        Private Sub groupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub groupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
