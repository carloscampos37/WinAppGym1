namespace WinAppGym.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.DTPfecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.CmbGrupo = new System.Windows.Forms.ComboBox();
            this.CmbEmpresas = new System.Windows.Forms.ComboBox();
            this.Combo4 = new System.Windows.Forms.ComboBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbAceptar = new System.Windows.Forms.ToolStripButton();
            this._lblLabels_0 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this._Label4_0 = new System.Windows.Forms.Label();
            this._Label4_1 = new System.Windows.Forms.Label();
            this.Lbempresa = new System.Windows.Forms.Label();
            this._Label1_3 = new System.Windows.Forms.Label();
            this._lblLabels_1 = new System.Windows.Forms.Label();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.ToolStrip1.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.AutoSize = false;
            this.ToolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(120, 50);
            this.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(36, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(417, 24);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "SISTEMA DE FACTURAS ELECTRONICAS ";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Navy;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.Yellow;
            this.TextBox1.Location = new System.Drawing.Point(0, 277);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(462, 37);
            this.TextBox1.TabIndex = 21;
            this.TextBox1.Text = "JCK Consultores -  RPC993900810/ RPM #974989647/ ENTEL 954818107    Correo: carlo" +
    "s.campos.si@hotmail.com";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTPfecha1
            // 
            this.DTPfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPfecha1.Location = new System.Drawing.Point(109, 245);
            this.DTPfecha1.Name = "DTPfecha1";
            this.DTPfecha1.Size = new System.Drawing.Size(136, 20);
            this.DTPfecha1.TabIndex = 20;
            this.DTPfecha1.Value = new System.DateTime(2014, 8, 19, 11, 3, 11, 0);
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsReturn = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(109, 124);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(115, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(109, 163);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.CmbGrupo.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbGrupo.Location = new System.Drawing.Point(110, 51);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbGrupo.Size = new System.Drawing.Size(179, 21);
            this.CmbGrupo.TabIndex = 1;
            // 
            // CmbEmpresas
            // 
            this.CmbEmpresas.BackColor = System.Drawing.SystemColors.Window;
            this.CmbEmpresas.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpresas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbEmpresas.Location = new System.Drawing.Point(109, 90);
            this.CmbEmpresas.Name = "CmbEmpresas";
            this.CmbEmpresas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbEmpresas.Size = new System.Drawing.Size(180, 21);
            this.CmbEmpresas.TabIndex = 2;
            this.CmbEmpresas.Visible = false;
            // 
            // Combo4
            // 
            this.Combo4.BackColor = System.Drawing.SystemColors.Window;
            this.Combo4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Combo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.Combo4.Location = new System.Drawing.Point(109, 201);
            this.Combo4.Name = "Combo4";
            this.Combo4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combo4.Size = new System.Drawing.Size(180, 21);
            this.Combo4.TabIndex = 4;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAceptar,
            this.ToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(473, 41);
            this.ToolStrip1.TabIndex = 29;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TsbAceptar
            // 
            this.TsbAceptar.AutoSize = false;
            this.TsbAceptar.ForeColor = System.Drawing.Color.Black;
            this.TsbAceptar.Image = ((System.Drawing.Image)(resources.GetObject("TsbAceptar.Image")));
            this.TsbAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAceptar.Name = "TsbAceptar";
            this.TsbAceptar.Size = new System.Drawing.Size(120, 50);
            this.TsbAceptar.Text = "Aceptar";
            this.TsbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TsbAceptar.Click += new System.EventHandler(this.TsbAceptar_Click);
            // 
            // _lblLabels_0
            // 
            this._lblLabels_0.AutoSize = true;
            this._lblLabels_0.BackColor = System.Drawing.Color.Transparent;
            this._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblLabels_0.ForeColor = System.Drawing.Color.Maroon;
            this._lblLabels_0.Location = new System.Drawing.Point(26, 131);
            this._lblLabels_0.Name = "_lblLabels_0";
            this._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblLabels_0.Size = new System.Drawing.Size(49, 13);
            this._lblLabels_0.TabIndex = 16;
            this._lblLabels_0.Text = "Usuario :";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(36, 377);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(70, 20);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Acceso      : ";
            this.Label5.Visible = false;
            // 
            // _Label4_0
            // 
            this._Label4_0.AutoSize = true;
            this._Label4_0.BackColor = System.Drawing.Color.Transparent;
            this._Label4_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label4_0.ForeColor = System.Drawing.Color.Maroon;
            this._Label4_0.Location = new System.Drawing.Point(36, 53);
            this._Label4_0.Name = "_Label4_0";
            this._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label4_0.Size = new System.Drawing.Size(42, 13);
            this._Label4_0.TabIndex = 13;
            this._Label4_0.Text = "Grupo :";
            // 
            // _Label4_1
            // 
            this._Label4_1.AutoSize = true;
            this._Label4_1.BackColor = System.Drawing.Color.Transparent;
            this._Label4_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label4_1.ForeColor = System.Drawing.Color.Maroon;
            this._Label4_1.Location = new System.Drawing.Point(35, 252);
            this._Label4_1.Name = "_Label4_1";
            this._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label4_1.Size = new System.Drawing.Size(43, 13);
            this._Label4_1.TabIndex = 12;
            this._Label4_1.Text = "Fecha :";
            // 
            // Lbempresa
            // 
            this.Lbempresa.AutoSize = true;
            this.Lbempresa.BackColor = System.Drawing.Color.Transparent;
            this.Lbempresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbempresa.ForeColor = System.Drawing.Color.Maroon;
            this.Lbempresa.Location = new System.Drawing.Point(35, 93);
            this.Lbempresa.Name = "Lbempresa";
            this.Lbempresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbempresa.Size = new System.Drawing.Size(54, 13);
            this.Lbempresa.TabIndex = 11;
            this.Lbempresa.Text = "Empresa :";
            // 
            // _Label1_3
            // 
            this._Label1_3.AutoSize = true;
            this._Label1_3.BackColor = System.Drawing.Color.Transparent;
            this._Label1_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_3.ForeColor = System.Drawing.Color.Maroon;
            this._Label1_3.Location = new System.Drawing.Point(35, 204);
            this._Label1_3.Name = "_Label1_3";
            this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_3.Size = new System.Drawing.Size(74, 13);
            this._Label1_3.TabIndex = 10;
            this._Label1_3.Text = "Pto.  Emision :";
            // 
            // _lblLabels_1
            // 
            this._lblLabels_1.AutoSize = true;
            this._lblLabels_1.BackColor = System.Drawing.Color.Transparent;
            this._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblLabels_1.ForeColor = System.Drawing.Color.Maroon;
            this._lblLabels_1.Location = new System.Drawing.Point(35, 167);
            this._lblLabels_1.Name = "_lblLabels_1";
            this._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblLabels_1.Size = new System.Drawing.Size(64, 13);
            this._lblLabels_1.TabIndex = 15;
            this._lblLabels_1.Text = "&Contraseña:";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.White;
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.TextBox1);
            this.Frame1.Controls.Add(this.DTPfecha1);
            this.Frame1.Controls.Add(this.txtUserName);
            this.Frame1.Controls.Add(this.txtPassword);
            this.Frame1.Controls.Add(this.CmbGrupo);
            this.Frame1.Controls.Add(this.CmbEmpresas);
            this.Frame1.Controls.Add(this.Combo4);
            this.Frame1.Controls.Add(this._lblLabels_0);
            this.Frame1.Controls.Add(this._lblLabels_1);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this._Label4_0);
            this.Frame1.Controls.Add(this._Label4_1);
            this.Frame1.Controls.Add(this.Lbempresa);
            this.Frame1.Controls.Add(this._Label1_3);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Frame1.Location = new System.Drawing.Point(0, 89);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(465, 317);
            this.Frame1.TabIndex = 28;
            this.Frame1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Frame1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.DateTimePicker DTPfecha1;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.ComboBox CmbGrupo;
        public System.Windows.Forms.ComboBox CmbEmpresas;
        public System.Windows.Forms.ComboBox Combo4;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton TsbAceptar;
        public System.Windows.Forms.Label _lblLabels_0;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label _Label4_0;
        public System.Windows.Forms.Label _Label4_1;
        public System.Windows.Forms.Label Lbempresa;
        public System.Windows.Forms.Label _Label1_3;
        public System.Windows.Forms.Label _lblLabels_1;
        public System.Windows.Forms.GroupBox Frame1;
    }
}