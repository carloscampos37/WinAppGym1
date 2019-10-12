namespace WinAppGym.Forms.Reportes
{
    partial class FrmMembresiasporfechas
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbVencidas = new System.Windows.Forms.RadioButton();
            this.rdbxvencer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChkRenova = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BntSalir);
            this.panel3.Controls.Add(this.BntImprimir);
            this.panel3.Location = new System.Drawing.Point(265, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 172);
            this.panel3.TabIndex = 52;
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(12, 106);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(81, 53);
            this.BntSalir.TabIndex = 7;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = false;
            this.BntSalir.Click += new System.EventHandler(this.BntSalir_Click);
            // 
            // BntImprimir
            // 
            this.BntImprimir.BackColor = System.Drawing.Color.Snow;
            this.BntImprimir.ForeColor = System.Drawing.Color.Black;
            this.BntImprimir.Location = new System.Drawing.Point(12, 17);
            this.BntImprimir.Name = "BntImprimir";
            this.BntImprimir.Size = new System.Drawing.Size(81, 53);
            this.BntImprimir.TabIndex = 6;
            this.BntImprimir.Text = "Imprimir";
            this.BntImprimir.UseVisualStyleBackColor = false;
            this.BntImprimir.Click += new System.EventHandler(this.BntImprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DtpDesde);
            this.panel1.Controls.Add(this.DtpHasta);
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 85);
            this.panel1.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(39, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Desde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(152, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Hasta";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesde.Location = new System.Drawing.Point(13, 33);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(98, 20);
            this.DtpDesde.TabIndex = 45;
            // 
            // DtpHasta
            // 
            this.DtpHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHasta.Location = new System.Drawing.Point(128, 33);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(92, 20);
            this.DtpHasta.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rdbVencidas);
            this.panel2.Controls.Add(this.rdbxvencer);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 55);
            this.panel2.TabIndex = 52;
            // 
            // rdbVencidas
            // 
            this.rdbVencidas.AutoSize = true;
            this.rdbVencidas.Location = new System.Drawing.Point(26, 35);
            this.rdbVencidas.Name = "rdbVencidas";
            this.rdbVencidas.Size = new System.Drawing.Size(127, 17);
            this.rdbVencidas.TabIndex = 3;
            this.rdbVencidas.TabStop = true;
            this.rdbVencidas.Text = "Membresias vencidas";
            this.rdbVencidas.UseVisualStyleBackColor = true;
            // 
            // rdbxvencer
            // 
            this.rdbxvencer.AutoSize = true;
            this.rdbxvencer.Location = new System.Drawing.Point(26, 12);
            this.rdbxvencer.Name = "rdbxvencer";
            this.rdbxvencer.Size = new System.Drawing.Size(135, 17);
            this.rdbxvencer.TabIndex = 2;
            this.rdbxvencer.TabStop = true;
            this.rdbxvencer.Text = "Membresias por vencer";
            this.rdbxvencer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 24);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "MEMBRESIAS POR FECHA DE VENCIMIENTO";
            // 
            // ChkRenova
            // 
            this.ChkRenova.AutoSize = true;
            this.ChkRenova.Location = new System.Drawing.Point(12, 60);
            this.ChkRenova.Name = "ChkRenova";
            this.ChkRenova.Size = new System.Drawing.Size(134, 17);
            this.ChkRenova.TabIndex = 54;
            this.ChkRenova.Text = "Incluye RENOVACION";
            this.ChkRenova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkRenova.UseVisualStyleBackColor = true;
            // 
            // FrmMembresiasporfechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(405, 249);
            this.Controls.Add(this.ChkRenova);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMembresiasporfechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbVencidas;
        private System.Windows.Forms.RadioButton rdbxvencer;
        private System.Windows.Forms.CheckBox ChkRenova;
    }
}