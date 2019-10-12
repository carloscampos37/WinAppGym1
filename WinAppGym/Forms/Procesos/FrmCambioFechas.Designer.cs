namespace WinAppGym.Forms
{
    partial class FrmCambioFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictFoto = new System.Windows.Forms.PictureBox();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntGrabar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvSocios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblReferencia = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.ctr_AyuAutorizacion = new Ctr_Ayuda.Ctr_Ayuda();
            this.ChkAutorizacion = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DtpTermino = new System.Windows.Forms.DateTimePicker();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.DgvMembresias = new System.Windows.Forms.DataGridView();
            this.PagosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMembPagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMaximaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPactado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BntImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembresias)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.Yellow;
            this.TxtBuscar.Location = new System.Drawing.Point(151, 26);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(185, 20);
            this.TxtBuscar.TabIndex = 18;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // pictFoto
            // 
            this.pictFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictFoto.Location = new System.Drawing.Point(683, 12);
            this.pictFoto.Name = "pictFoto";
            this.pictFoto.Size = new System.Drawing.Size(196, 191);
            this.pictFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictFoto.TabIndex = 19;
            this.pictFoto.TabStop = false;
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(584, 12);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(81, 53);
            this.BntSalir.TabIndex = 22;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = false;
            this.BntSalir.Click += new System.EventHandler(this.BntSalir_Click);
            // 
            // BntGrabar
            // 
            this.BntGrabar.BackColor = System.Drawing.Color.White;
            this.BntGrabar.ForeColor = System.Drawing.Color.Black;
            this.BntGrabar.Location = new System.Drawing.Point(369, 12);
            this.BntGrabar.Name = "BntGrabar";
            this.BntGrabar.Size = new System.Drawing.Size(81, 53);
            this.BntGrabar.TabIndex = 21;
            this.BntGrabar.Text = "Grabar";
            this.BntGrabar.UseVisualStyleBackColor = false;
            this.BntGrabar.Click += new System.EventHandler(this.BntGrabar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Codigo o Nombre ";
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
            this.FechaInicio,
            this.FechaTermino,
            this.Column6,
            this.photo,
            this.Id});
            this.DgvSocios.Location = new System.Drawing.Point(12, 322);
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.ReadOnly = true;
            this.DgvSocios.Size = new System.Drawing.Size(867, 234);
            this.DgvSocios.TabIndex = 24;
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
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaInicio.DataPropertyName = "acc_startdate";
            this.FechaInicio.HeaderText = "Activo Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 90;
            // 
            // FechaTermino
            // 
            this.FechaTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaTermino.DataPropertyName = "acc_enddate";
            this.FechaTermino.HeaderText = "Activo termino";
            this.FechaTermino.Name = "FechaTermino";
            this.FechaTermino.ReadOnly = true;
            this.FechaTermino.Width = 99;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gender";
            this.Column6.HeaderText = "Genero";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "PHOTO";
            this.photo.HeaderText = "Foto";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "USERID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.LblReferencia);
            this.panel4.Controls.Add(this.TxtReferencia);
            this.panel4.Controls.Add(this.ctr_AyuAutorizacion);
            this.panel4.Controls.Add(this.ChkAutorizacion);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.DtpTermino);
            this.panel4.Controls.Add(this.DtpInicio);
            this.panel4.Location = new System.Drawing.Point(12, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 93);
            this.panel4.TabIndex = 121;
            // 
            // LblReferencia
            // 
            this.LblReferencia.AutoSize = true;
            this.LblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReferencia.ForeColor = System.Drawing.Color.Black;
            this.LblReferencia.Location = new System.Drawing.Point(60, 58);
            this.LblReferencia.Name = "LblReferencia";
            this.LblReferencia.Size = new System.Drawing.Size(84, 16);
            this.LblReferencia.TabIndex = 121;
            this.LblReferencia.Text = "Referencia";
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Location = new System.Drawing.Point(186, 57);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(642, 20);
            this.TxtReferencia.TabIndex = 120;
            // 
            // ctr_AyuAutorizacion
            // 
            this.ctr_AyuAutorizacion.CampoDevCod = "Id";
            this.ctr_AyuAutorizacion.CampoDevDesc = "DescripcionAutorizacion";
            this.ctr_AyuAutorizacion.Codigo = "";
            this.ctr_AyuAutorizacion.Descripcion = "";
            this.ctr_AyuAutorizacion.Filtro = "estadoanulado=0";
            this.ctr_AyuAutorizacion.ListaAlias = "Codigo,Descripcion";
            this.ctr_AyuAutorizacion.ListaCampos = "Id,DescripcionAutorizacion";
            this.ctr_AyuAutorizacion.Location = new System.Drawing.Point(443, 31);
            this.ctr_AyuAutorizacion.LongCod = "2";
            this.ctr_AyuAutorizacion.LongDesc = "50";
            this.ctr_AyuAutorizacion.Name = "ctr_AyuAutorizacion";
            this.ctr_AyuAutorizacion.NombreTabla = "ZK_AUTORIZACIONES";
            this.ctr_AyuAutorizacion.Requerido = false;
            this.ctr_AyuAutorizacion.Size = new System.Drawing.Size(405, 20);
            this.ctr_AyuAutorizacion.TabIndex = 119;
            this.ctr_AyuAutorizacion.Titulo = null;
            // 
            // ChkAutorizacion
            // 
            this.ChkAutorizacion.AutoSize = true;
            this.ChkAutorizacion.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ChkAutorizacion.Checked = true;
            this.ChkAutorizacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAutorizacion.ForeColor = System.Drawing.Color.Red;
            this.ChkAutorizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChkAutorizacion.Location = new System.Drawing.Point(294, 25);
            this.ChkAutorizacion.Name = "ChkAutorizacion";
            this.ChkAutorizacion.Size = new System.Drawing.Size(128, 24);
            this.ChkAutorizacion.TabIndex = 52;
            this.ChkAutorizacion.Text = "Autorizacion";
            this.ChkAutorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkAutorizacion.UseVisualStyleBackColor = true;
            this.ChkAutorizacion.CheckedChanged += new System.EventHandler(this.ChkAutorizacion_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(206, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 44;
            this.label16.Text = "F. Termino";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(58, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "F.Inicio";
            // 
            // DtpTermino
            // 
            this.DtpTermino.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTermino.Location = new System.Drawing.Point(186, 29);
            this.DtpTermino.Name = "DtpTermino";
            this.DtpTermino.Size = new System.Drawing.Size(102, 20);
            this.DtpTermino.TabIndex = 39;
            // 
            // DtpInicio
            // 
            this.DtpInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(39, 31);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(105, 20);
            this.DtpInicio.TabIndex = 38;
            this.DtpInicio.ValueChanged += new System.EventHandler(this.DtpInicio_ValueChanged);
            // 
            // DgvMembresias
            // 
            this.DgvMembresias.AllowUserToAddRows = false;
            this.DgvMembresias.AllowUserToDeleteRows = false;
            this.DgvMembresias.AllowUserToOrderColumns = true;
            this.DgvMembresias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembresias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PagosID,
            this.IdSocios,
            this.DescripcionMembPagos,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.FechaMaximaPago,
            this.PrecioPactado,
            this.NroCuota,
            this.Saldo});
            this.DgvMembresias.Location = new System.Drawing.Point(12, 71);
            this.DgvMembresias.Name = "DgvMembresias";
            this.DgvMembresias.ReadOnly = true;
            this.DgvMembresias.Size = new System.Drawing.Size(664, 132);
            this.DgvMembresias.TabIndex = 129;
            this.DgvMembresias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMembresias_CellContentClick);
            // 
            // PagosID
            // 
            this.PagosID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PagosID.DataPropertyName = "id";
            this.PagosID.HeaderText = "ID";
            this.PagosID.Name = "PagosID";
            this.PagosID.ReadOnly = true;
            this.PagosID.Width = 43;
            // 
            // IdSocios
            // 
            this.IdSocios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdSocios.DataPropertyName = "UserInfoID";
            this.IdSocios.HeaderText = "Socio";
            this.IdSocios.Name = "IdSocios";
            this.IdSocios.ReadOnly = true;
            this.IdSocios.Width = 59;
            // 
            // DescripcionMembPagos
            // 
            this.DescripcionMembPagos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescripcionMembPagos.DataPropertyName = "DescripcionMembresias";
            this.DescripcionMembPagos.HeaderText = "Membresia";
            this.DescripcionMembPagos.Name = "DescripcionMembPagos";
            this.DescripcionMembPagos.ReadOnly = true;
            this.DescripcionMembPagos.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "F. Inicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 64;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaFinal";
            this.dataGridViewTextBoxColumn5.HeaderText = "F. Termino";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 76;
            // 
            // FechaMaximaPago
            // 
            this.FechaMaximaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaMaximaPago.DataPropertyName = "fechaMaximadePago";
            this.FechaMaximaPago.HeaderText = "F. Maxima Pago";
            this.FechaMaximaPago.Name = "FechaMaximaPago";
            this.FechaMaximaPago.ReadOnly = true;
            this.FechaMaximaPago.Width = 99;
            // 
            // PrecioPactado
            // 
            this.PrecioPactado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioPactado.DataPropertyName = "PrecioPactado";
            this.PrecioPactado.HeaderText = "Precio";
            this.PrecioPactado.Name = "PrecioPactado";
            this.PrecioPactado.ReadOnly = true;
            this.PrecioPactado.Width = 62;
            // 
            // NroCuota
            // 
            this.NroCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NroCuota.DataPropertyName = "NroCuota";
            this.NroCuota.HeaderText = "Nro Cuota";
            this.NroCuota.Name = "NroCuota";
            this.NroCuota.ReadOnly = true;
            this.NroCuota.Width = 74;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 59;
            // 
            // BntImprimir
            // 
            this.BntImprimir.BackColor = System.Drawing.Color.Snow;
            this.BntImprimir.ForeColor = System.Drawing.Color.Black;
            this.BntImprimir.Location = new System.Drawing.Point(478, 12);
            this.BntImprimir.Name = "BntImprimir";
            this.BntImprimir.Size = new System.Drawing.Size(81, 53);
            this.BntImprimir.TabIndex = 130;
            this.BntImprimir.Text = "Imprimir";
            this.BntImprimir.UseVisualStyleBackColor = false;
            this.BntImprimir.Click += new System.EventHandler(this.BntImprimir_Click);
            // 
            // FrmCambioFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.BntImprimir);
            this.Controls.Add(this.DgvMembresias);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DgvSocios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntSalir);
            this.Controls.Add(this.BntGrabar);
            this.Controls.Add(this.pictFoto);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmCambioFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DE FECHAS";
            this.Load += new System.EventHandler(this.FrmCambioFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembresias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox pictFoto;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntGrabar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblReferencia;
        private System.Windows.Forms.TextBox TxtReferencia;
        internal Ctr_Ayuda.Ctr_Ayuda ctr_AyuAutorizacion;
        private System.Windows.Forms.CheckBox ChkAutorizacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker DtpTermino;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.DataGridView DgvMembresias;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMembPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMaximaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPactado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button BntImprimir;
    }
}