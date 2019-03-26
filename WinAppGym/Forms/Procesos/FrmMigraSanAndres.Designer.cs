namespace WinAppGym.Forms
{
    partial class FrmMigraSanAndres
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chkInicializa = new System.Windows.Forms.CheckBox();
            this.ChkMembActivas = new System.Windows.Forms.CheckBox();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntIniciar = new System.Windows.Forms.Button();
            this.DgvSocios = new System.Windows.Forms.DataGridView();
            this.ChkMembresias = new System.Windows.Forms.CheckBox();
            this.ChkSocios = new System.Windows.Forms.CheckBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.BntSocios = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.BntFotos = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(27, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(951, 476);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.DtpFecha);
            this.TabPage1.Controls.Add(this.chkInicializa);
            this.TabPage1.Controls.Add(this.ChkMembActivas);
            this.TabPage1.Controls.Add(this.BntSalir);
            this.TabPage1.Controls.Add(this.BntIniciar);
            this.TabPage1.Controls.Add(this.DgvSocios);
            this.TabPage1.Controls.Add(this.ChkMembresias);
            this.TabPage1.Controls.Add(this.ChkSocios);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(943, 450);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de corte";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(24, 232);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(85, 20);
            this.DtpFecha.TabIndex = 7;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // chkInicializa
            // 
            this.chkInicializa.AutoSize = true;
            this.chkInicializa.Location = new System.Drawing.Point(7, 328);
            this.chkInicializa.Name = "chkInicializa";
            this.chkInicializa.Size = new System.Drawing.Size(66, 17);
            this.chkInicializa.TabIndex = 6;
            this.chkInicializa.Text = "Inicializa";
            this.chkInicializa.UseVisualStyleBackColor = true;
            // 
            // ChkMembActivas
            // 
            this.ChkMembActivas.AutoSize = true;
            this.ChkMembActivas.Location = new System.Drawing.Point(24, 111);
            this.ChkMembActivas.Name = "ChkMembActivas";
            this.ChkMembActivas.Size = new System.Drawing.Size(120, 17);
            this.ChkMembActivas.TabIndex = 5;
            this.ChkMembActivas.Text = "Membresias Activas";
            this.ChkMembActivas.UseVisualStyleBackColor = true;
            this.ChkMembActivas.CheckedChanged += new System.EventHandler(this.ChkMembActivas_CheckedChanged);
            // 
            // BntSalir
            // 
            this.BntSalir.Location = new System.Drawing.Point(88, 397);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(75, 23);
            this.BntSalir.TabIndex = 4;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = true;
            // 
            // BntIniciar
            // 
            this.BntIniciar.Location = new System.Drawing.Point(7, 397);
            this.BntIniciar.Name = "BntIniciar";
            this.BntIniciar.Size = new System.Drawing.Size(75, 23);
            this.BntIniciar.TabIndex = 3;
            this.BntIniciar.Text = "Iniciar";
            this.BntIniciar.UseVisualStyleBackColor = true;
            this.BntIniciar.Click += new System.EventHandler(this.BntIniciar_Click);
            // 
            // DgvSocios
            // 
            this.DgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSocios.Location = new System.Drawing.Point(169, 27);
            this.DgvSocios.Name = "DgvSocios";
            this.DgvSocios.Size = new System.Drawing.Size(768, 416);
            this.DgvSocios.TabIndex = 2;
            // 
            // ChkMembresias
            // 
            this.ChkMembresias.AutoSize = true;
            this.ChkMembresias.Location = new System.Drawing.Point(24, 75);
            this.ChkMembresias.Name = "ChkMembresias";
            this.ChkMembresias.Size = new System.Drawing.Size(82, 17);
            this.ChkMembresias.TabIndex = 1;
            this.ChkMembresias.Text = "Membresias";
            this.ChkMembresias.UseVisualStyleBackColor = true;
            this.ChkMembresias.CheckedChanged += new System.EventHandler(this.ChkMembresias_CheckedChanged);
            // 
            // ChkSocios
            // 
            this.ChkSocios.AutoSize = true;
            this.ChkSocios.Location = new System.Drawing.Point(24, 41);
            this.ChkSocios.Name = "ChkSocios";
            this.ChkSocios.Size = new System.Drawing.Size(58, 17);
            this.ChkSocios.TabIndex = 0;
            this.ChkSocios.Text = "Socios";
            this.ChkSocios.UseVisualStyleBackColor = true;
            this.ChkSocios.CheckedChanged += new System.EventHandler(this.ChkSocios_CheckedChanged);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.BntSocios);
            this.TabPage2.Controls.Add(this.pbImage);
            this.TabPage2.Controls.Add(this.BntFotos);
            this.TabPage2.Controls.Add(this.DataGridView1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(893, 450);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "TabPage2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // BntSocios
            // 
            this.BntSocios.Location = new System.Drawing.Point(38, 19);
            this.BntSocios.Name = "BntSocios";
            this.BntSocios.Size = new System.Drawing.Size(75, 35);
            this.BntSocios.TabIndex = 6;
            this.BntSocios.Text = "Socios";
            this.BntSocios.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(413, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(118, 79);
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // BntFotos
            // 
            this.BntFotos.Location = new System.Drawing.Point(665, 19);
            this.BntFotos.Name = "BntFotos";
            this.BntFotos.Size = new System.Drawing.Size(75, 35);
            this.BntFotos.TabIndex = 4;
            this.BntFotos.Text = "Grabar Fotos";
            this.BntFotos.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(14, 91);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(726, 340);
            this.DataGridView1.TabIndex = 3;
            // 
            // FrmMigraSanAndres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 584);
            this.Controls.Add(this.TabControl1);
            this.Name = "FrmMigraSanAndres";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMigraSanAndres_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSocios)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.CheckBox ChkMembActivas;
        internal System.Windows.Forms.Button BntSalir;
        internal System.Windows.Forms.Button BntIniciar;
        internal System.Windows.Forms.DataGridView DgvSocios;
        internal System.Windows.Forms.CheckBox ChkMembresias;
        internal System.Windows.Forms.CheckBox ChkSocios;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button BntSocios;
        internal System.Windows.Forms.PictureBox pbImage;
        internal System.Windows.Forms.Button BntFotos;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.CheckBox chkInicializa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
    }
}