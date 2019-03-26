namespace WinAppGym.Forms
{
    partial class FrmAjusteMolinete
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
            this.DgvMembresias = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembresias)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.Yellow;
            this.TxtBuscar.Location = new System.Drawing.Point(111, 31);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(153, 20);
            this.TxtBuscar.TabIndex = 18;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // pictFoto
            // 
            this.pictFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictFoto.Location = new System.Drawing.Point(609, 31);
            this.pictFoto.Name = "pictFoto";
            this.pictFoto.Size = new System.Drawing.Size(199, 168);
            this.pictFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictFoto.TabIndex = 19;
            this.pictFoto.TabStop = false;
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(460, 12);
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
            this.BntGrabar.Location = new System.Drawing.Point(335, 12);
            this.BntGrabar.Name = "BntGrabar";
            this.BntGrabar.Size = new System.Drawing.Size(81, 53);
            this.BntGrabar.TabIndex = 21;
            this.BntGrabar.Text = "Ajustar";
            this.BntGrabar.UseVisualStyleBackColor = false;
            this.BntGrabar.Click += new System.EventHandler(this.BntGrabar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 12);
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
            this.DgvSocios.Location = new System.Drawing.Point(28, 214);
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.ReadOnly = true;
            this.DgvSocios.Size = new System.Drawing.Size(780, 290);
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
            // DgvMembresias
            // 
            this.DgvMembresias.AllowUserToAddRows = false;
            this.DgvMembresias.AllowUserToDeleteRows = false;
            this.DgvMembresias.AllowUserToOrderColumns = true;
            this.DgvMembresias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembresias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Membresia,
            this.Inicio,
            this.termino});
            this.DgvMembresias.Location = new System.Drawing.Point(28, 84);
            this.DgvMembresias.Name = "DgvMembresias";
            this.DgvMembresias.ReadOnly = true;
            this.DgvMembresias.Size = new System.Drawing.Size(550, 115);
            this.DgvMembresias.TabIndex = 25;
            // 
            // User
            // 
            this.User.DataPropertyName = "UserInfoID";
            this.User.HeaderText = "Socio";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Membresia
            // 
            this.Membresia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Membresia.DataPropertyName = "DescripcionMembresias";
            this.Membresia.HeaderText = "Membresia";
            this.Membresia.Name = "Membresia";
            this.Membresia.ReadOnly = true;
            this.Membresia.Width = 83;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "FechaInicio";
            this.Inicio.HeaderText = "F. Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // termino
            // 
            this.termino.DataPropertyName = "FechaFinal";
            this.termino.HeaderText = "F. Termino";
            this.termino.Name = "termino";
            this.termino.ReadOnly = true;
            // 
            // FrmAjusteMolinete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 516);
            this.Controls.Add(this.DgvMembresias);
            this.Controls.Add(this.DgvSocios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntSalir);
            this.Controls.Add(this.BntGrabar);
            this.Controls.Add(this.pictFoto);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmAjusteMolinete";
            this.Text = "AJUSTE DE FECHAS EN MOLINETE";
            this.Load += new System.EventHandler(this.FrmAjusteFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvMembresias;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}