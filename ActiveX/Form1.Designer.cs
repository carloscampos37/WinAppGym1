namespace AppGym
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                //axZKFPEngX1.FreeFPCacheDB(fpcHandle);
            }
            //showpicture.Stop();
            //showpicture.Close();
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.btnCloseSensor = new System.Windows.Forms.Button();
            this.txtb5 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInitialSensor = new System.Windows.Forms.Button();
            this.BntRegistro = new System.Windows.Forms.Button();
            this.axZKFPEngX1 = new AxZKFPEngXControl.AxZKFPEngX();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PicHuellas = new System.Windows.Forms.PictureBox();
            this.BntFoto = new System.Windows.Forms.Button();
            this.PicDetalle = new System.Windows.Forms.PictureBox();
            this.BntCamara = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvSocios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BntHuella4 = new System.Windows.Forms.TextBox();
            this.BntHuella3 = new System.Windows.Forms.TextBox();
            this.BntHuella2 = new System.Windows.Forms.TextBox();
            this.BntHuella1 = new System.Windows.Forms.TextBox();
            this.BntHuella0 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BntHuella9 = new System.Windows.Forms.TextBox();
            this.BntHuella8 = new System.Windows.Forms.TextBox();
            this.BntHuella7 = new System.Windows.Forms.TextBox();
            this.BntHuella6 = new System.Windows.Forms.TextBox();
            this.BntHuella5 = new System.Windows.Forms.TextBox();
            this.TxtHuella = new System.Windows.Forms.TextBox();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntGrabar = new System.Windows.Forms.Button();
            this.TxtResul = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHuellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(82, 29);
            this.txtb2.Name = "txtb2";
            this.txtb2.ReadOnly = true;
            this.txtb2.Size = new System.Drawing.Size(68, 20);
            this.txtb2.TabIndex = 3;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Status:";
            this.statusBarPanel1.Width = 80;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 200;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            // 
            // btnCloseSensor
            // 
            this.btnCloseSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseSensor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSensor.Enabled = false;
            this.btnCloseSensor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseSensor.Location = new System.Drawing.Point(189, 391);
            this.btnCloseSensor.Name = "btnCloseSensor";
            this.btnCloseSensor.Size = new System.Drawing.Size(73, 25);
            this.btnCloseSensor.TabIndex = 9;
            this.btnCloseSensor.Text = "Desconectar";
            this.btnCloseSensor.UseVisualStyleBackColor = false;
            this.btnCloseSensor.Click += new System.EventHandler(this.btnCloseSensor_Click);
            // 
            // txtb5
            // 
            this.txtb5.Location = new System.Drawing.Point(100, 54);
            this.txtb5.Name = "txtb5";
            this.txtb5.ReadOnly = true;
            this.txtb5.Size = new System.Drawing.Size(162, 20);
            this.txtb5.TabIndex = 8;
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(24, 29);
            this.txtb1.Name = "txtb1";
            this.txtb1.ReadOnly = true;
            this.txtb1.Size = new System.Drawing.Size(52, 20);
            this.txtb1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Serial Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sensor Count";
            // 
            // btnInitialSensor
            // 
            this.btnInitialSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInitialSensor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitialSensor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInitialSensor.Location = new System.Drawing.Point(12, 389);
            this.btnInitialSensor.Name = "btnInitialSensor";
            this.btnInitialSensor.Size = new System.Drawing.Size(64, 22);
            this.btnInitialSensor.TabIndex = 0;
            this.btnInitialSensor.Text = "Conectar";
            this.btnInitialSensor.UseVisualStyleBackColor = false;
            this.btnInitialSensor.Visible = false;
            this.btnInitialSensor.Click += new System.EventHandler(this.btnInitialSensor_Click);
            // 
            // BntRegistro
            // 
            this.BntRegistro.BackColor = System.Drawing.Color.White;
            this.BntRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BntRegistro.Location = new System.Drawing.Point(100, 389);
            this.BntRegistro.Name = "BntRegistro";
            this.BntRegistro.Size = new System.Drawing.Size(72, 25);
            this.BntRegistro.TabIndex = 0;
            this.BntRegistro.Text = "Registrar";
            this.BntRegistro.UseVisualStyleBackColor = false;
            this.BntRegistro.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // axZKFPEngX1
            // 
            this.axZKFPEngX1.Enabled = true;
            this.axZKFPEngX1.Location = new System.Drawing.Point(458, 166);
            this.axZKFPEngX1.Name = "axZKFPEngX1";
            this.axZKFPEngX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axZKFPEngX1.OcxState")));
            this.axZKFPEngX1.Size = new System.Drawing.Size(24, 24);
            this.axZKFPEngX1.TabIndex = 3;
            this.axZKFPEngX1.OnFeatureInfo += new AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEventHandler(this.axZKFPEngX1_OnFeatureInfo);
            this.axZKFPEngX1.OnImageReceived += new AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEventHandler(this.axZKFPEngX1_OnImageReceived);
            this.axZKFPEngX1.OnEnroll += new AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEventHandler(this.axZKFPEngX1_OnEnroll);
            this.axZKFPEngX1.OnCapture += new AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEventHandler(this.axZKFPEngX1_OnCapture);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PicHuellas
            // 
            this.PicHuellas.BackColor = System.Drawing.Color.White;
            this.PicHuellas.Location = new System.Drawing.Point(12, 75);
            this.PicHuellas.Name = "PicHuellas";
            this.PicHuellas.Size = new System.Drawing.Size(250, 307);
            this.PicHuellas.TabIndex = 11;
            this.PicHuellas.TabStop = false;
            // 
            // BntFoto
            // 
            this.BntFoto.BackColor = System.Drawing.Color.Lime;
            this.BntFoto.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BntFoto.Location = new System.Drawing.Point(581, 336);
            this.BntFoto.Name = "BntFoto";
            this.BntFoto.Size = new System.Drawing.Size(78, 35);
            this.BntFoto.TabIndex = 93;
            this.BntFoto.Text = "Imagen";
            this.BntFoto.UseVisualStyleBackColor = false;
            this.BntFoto.Visible = false;
            this.BntFoto.Click += new System.EventHandler(this.BntFoto_Click);
            // 
            // PicDetalle
            // 
            this.PicDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PicDetalle.Location = new System.Drawing.Point(304, 228);
            this.PicDetalle.Name = "PicDetalle";
            this.PicDetalle.Size = new System.Drawing.Size(259, 229);
            this.PicDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDetalle.TabIndex = 94;
            this.PicDetalle.TabStop = false;
            // 
            // BntCamara
            // 
            this.BntCamara.BackColor = System.Drawing.Color.White;
            this.BntCamara.ForeColor = System.Drawing.Color.Black;
            this.BntCamara.Location = new System.Drawing.Point(581, 269);
            this.BntCamara.Name = "BntCamara";
            this.BntCamara.Size = new System.Drawing.Size(78, 35);
            this.BntCamara.TabIndex = 92;
            this.BntCamara.Text = "Camara";
            this.BntCamara.UseVisualStyleBackColor = false;
            this.BntCamara.Click += new System.EventHandler(this.BntCamara_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.TxtBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(165, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 38);
            this.panel1.TabIndex = 95;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.Yellow;
            this.TxtBuscar.Location = new System.Drawing.Point(341, 8);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(153, 20);
            this.TxtBuscar.TabIndex = 17;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo o Nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // DgvSocios
            // 
            this.DgvSocios.AllowUserToAddRows = false;
            this.DgvSocios.AllowUserToDeleteRows = false;
            this.DgvSocios.AllowUserToOrderColumns = true;
            this.DgvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombres,
            this.Apellidos,
            this.Column4,
            this.Column5,
            this.photo,
            this.Column6,
            this.Id});
            this.DgvSocios.Location = new System.Drawing.Point(303, 57);
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.ReadOnly = true;
            this.DgvSocios.Size = new System.Drawing.Size(671, 168);
            this.DgvSocios.TabIndex = 96;
            this.DgvSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSocios_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Badgenumber";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombres.DataPropertyName = "name";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Apellidos.DataPropertyName = "lastname";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "acc_startdate";
            this.Column4.HeaderText = "Activo Inicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "acc_enddate";
            this.Column5.HeaderText = "Activo termino";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 99;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "PHOTO";
            this.photo.HeaderText = "Foto";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gender";
            this.Column6.HeaderText = "Genero";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "USERID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BntHuella4);
            this.groupBox1.Controls.Add(this.BntHuella3);
            this.groupBox1.Controls.Add(this.BntHuella2);
            this.groupBox1.Controls.Add(this.BntHuella1);
            this.groupBox1.Controls.Add(this.BntHuella0);
            this.groupBox1.Location = new System.Drawing.Point(685, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 55);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANO IZQUIERDA";
            // 
            // BntHuella4
            // 
            this.BntHuella4.Location = new System.Drawing.Point(192, 28);
            this.BntHuella4.Name = "BntHuella4";
            this.BntHuella4.ReadOnly = true;
            this.BntHuella4.Size = new System.Drawing.Size(42, 20);
            this.BntHuella4.TabIndex = 101;
            // 
            // BntHuella3
            // 
            this.BntHuella3.Location = new System.Drawing.Point(144, 28);
            this.BntHuella3.Name = "BntHuella3";
            this.BntHuella3.ReadOnly = true;
            this.BntHuella3.Size = new System.Drawing.Size(42, 20);
            this.BntHuella3.TabIndex = 102;
            // 
            // BntHuella2
            // 
            this.BntHuella2.Location = new System.Drawing.Point(96, 28);
            this.BntHuella2.Name = "BntHuella2";
            this.BntHuella2.ReadOnly = true;
            this.BntHuella2.Size = new System.Drawing.Size(42, 20);
            this.BntHuella2.TabIndex = 101;
            this.BntHuella2.Click += new System.EventHandler(this.BntHuella2_Click);
            // 
            // BntHuella1
            // 
            this.BntHuella1.Location = new System.Drawing.Point(48, 28);
            this.BntHuella1.Name = "BntHuella1";
            this.BntHuella1.ReadOnly = true;
            this.BntHuella1.Size = new System.Drawing.Size(42, 20);
            this.BntHuella1.TabIndex = 102;
            // 
            // BntHuella0
            // 
            this.BntHuella0.Location = new System.Drawing.Point(0, 28);
            this.BntHuella0.Name = "BntHuella0";
            this.BntHuella0.ReadOnly = true;
            this.BntHuella0.Size = new System.Drawing.Size(42, 20);
            this.BntHuella0.TabIndex = 103;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BntHuella9);
            this.groupBox2.Controls.Add(this.BntHuella8);
            this.groupBox2.Controls.Add(this.BntHuella7);
            this.groupBox2.Controls.Add(this.BntHuella6);
            this.groupBox2.Controls.Add(this.BntHuella5);
            this.groupBox2.Location = new System.Drawing.Point(685, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 40);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MANO DERECHA";
            // 
            // BntHuella9
            // 
            this.BntHuella9.Location = new System.Drawing.Point(198, 19);
            this.BntHuella9.Name = "BntHuella9";
            this.BntHuella9.ReadOnly = true;
            this.BntHuella9.Size = new System.Drawing.Size(42, 20);
            this.BntHuella9.TabIndex = 104;
            // 
            // BntHuella8
            // 
            this.BntHuella8.Location = new System.Drawing.Point(150, 19);
            this.BntHuella8.Name = "BntHuella8";
            this.BntHuella8.ReadOnly = true;
            this.BntHuella8.Size = new System.Drawing.Size(42, 20);
            this.BntHuella8.TabIndex = 105;
            // 
            // BntHuella7
            // 
            this.BntHuella7.Location = new System.Drawing.Point(102, 19);
            this.BntHuella7.Name = "BntHuella7";
            this.BntHuella7.ReadOnly = true;
            this.BntHuella7.Size = new System.Drawing.Size(42, 20);
            this.BntHuella7.TabIndex = 106;
            this.BntHuella7.Click += new System.EventHandler(this.BntHuella7_Click);
            // 
            // BntHuella6
            // 
            this.BntHuella6.Location = new System.Drawing.Point(54, 19);
            this.BntHuella6.Name = "BntHuella6";
            this.BntHuella6.ReadOnly = true;
            this.BntHuella6.Size = new System.Drawing.Size(42, 20);
            this.BntHuella6.TabIndex = 107;
            this.BntHuella6.Click += new System.EventHandler(this.BntHuella6_Click);
            // 
            // BntHuella5
            // 
            this.BntHuella5.Location = new System.Drawing.Point(6, 19);
            this.BntHuella5.Name = "BntHuella5";
            this.BntHuella5.ReadOnly = true;
            this.BntHuella5.Size = new System.Drawing.Size(42, 20);
            this.BntHuella5.TabIndex = 54;
            this.BntHuella5.Click += new System.EventHandler(this.BntHuella5_Click);
            // 
            // TxtHuella
            // 
            this.TxtHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHuella.ForeColor = System.Drawing.Color.Red;
            this.TxtHuella.Location = new System.Drawing.Point(24, 416);
            this.TxtHuella.Multiline = true;
            this.TxtHuella.Name = "TxtHuella";
            this.TxtHuella.Size = new System.Drawing.Size(264, 55);
            this.TxtHuella.TabIndex = 99;
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.Red;
            this.BntCancelar.ForeColor = System.Drawing.Color.Black;
            this.BntCancelar.Location = new System.Drawing.Point(781, 375);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(81, 53);
            this.BntCancelar.TabIndex = 102;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            this.BntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(886, 375);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(81, 53);
            this.BntSalir.TabIndex = 101;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = false;
            this.BntSalir.Click += new System.EventHandler(this.BntSalir_Click);
            // 
            // BntGrabar
            // 
            this.BntGrabar.BackColor = System.Drawing.Color.Yellow;
            this.BntGrabar.ForeColor = System.Drawing.Color.Black;
            this.BntGrabar.Location = new System.Drawing.Point(685, 375);
            this.BntGrabar.Name = "BntGrabar";
            this.BntGrabar.Size = new System.Drawing.Size(81, 53);
            this.BntGrabar.TabIndex = 100;
            this.BntGrabar.Text = "Grabar";
            this.BntGrabar.UseVisualStyleBackColor = false;
            this.BntGrabar.Click += new System.EventHandler(this.BntGrabar_Click);
            // 
            // TxtResul
            // 
            this.TxtResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResul.ForeColor = System.Drawing.Color.Red;
            this.TxtResul.Location = new System.Drawing.Point(569, 432);
            this.TxtResul.Multiline = true;
            this.TxtResul.Name = "TxtResul";
            this.TxtResul.Size = new System.Drawing.Size(387, 41);
            this.TxtResul.TabIndex = 103;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 485);
            this.Controls.Add(this.TxtResul);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntSalir);
            this.Controls.Add(this.BntGrabar);
            this.Controls.Add(this.TxtHuella);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvSocios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BntFoto);
            this.Controls.Add(this.PicDetalle);
            this.Controls.Add(this.BntCamara);
            this.Controls.Add(this.PicHuellas);
            this.Controls.Add(this.axZKFPEngX1);
            this.Controls.Add(this.btnCloseSensor);
            this.Controls.Add(this.btnInitialSensor);
            this.Controls.Add(this.BntRegistro);
            this.Controls.Add(this.txtb5);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHuellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb2;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel1;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel2;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInitialSensor;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloseSensor;
        private System.Windows.Forms.StatusBarPanel sstatusbar0;
        private System.Windows.Forms.StatusBarPanel statusBarPanel4;
        private System.Windows.Forms.Button BntRegistro;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxZKFPEngXControl.AxZKFPEngX axZKFPEngX1;
        private System.Windows.Forms.PictureBox PicHuellas;
        private System.Windows.Forms.Button BntFoto;
        private System.Windows.Forms.PictureBox PicDetalle;
        private System.Windows.Forms.Button BntCamara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvSocios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BntHuella4;
        private System.Windows.Forms.TextBox BntHuella3;
        private System.Windows.Forms.TextBox BntHuella2;
        private System.Windows.Forms.TextBox BntHuella1;
        private System.Windows.Forms.TextBox BntHuella0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BntHuella9;
        private System.Windows.Forms.TextBox BntHuella8;
        private System.Windows.Forms.TextBox BntHuella7;
        private System.Windows.Forms.TextBox BntHuella6;
        private System.Windows.Forms.TextBox BntHuella5;
        private System.Windows.Forms.TextBox TxtHuella;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntGrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox TxtResul;
    }
}

