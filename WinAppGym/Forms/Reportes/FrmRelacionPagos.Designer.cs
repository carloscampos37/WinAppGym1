namespace WinAppGym.Forms
{
    partial class FrmRelacionPagos
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BntModificar = new System.Windows.Forms.Button();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntImprimir = new System.Windows.Forms.Button();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.TxtPagado = new System.Windows.Forms.TextBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(187, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(50, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Desde";
            // 
            // DtpHasta
            // 
            this.DtpHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHasta.Location = new System.Drawing.Point(163, 33);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(92, 20);
            this.DtpHasta.TabIndex = 46;
            // 
            // DtpDesde
            // 
            this.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesde.Location = new System.Drawing.Point(24, 33);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(98, 20);
            this.DtpDesde.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DtpDesde);
            this.panel1.Controls.Add(this.DtpHasta);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 85);
            this.panel1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BntModificar);
            this.panel3.Controls.Add(this.BntSalir);
            this.panel3.Controls.Add(this.BntImprimir);
            this.panel3.Location = new System.Drawing.Point(332, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 85);
            this.panel3.TabIndex = 50;
            // 
            // BntModificar
            // 
            this.BntModificar.BackColor = System.Drawing.Color.LawnGreen;
            this.BntModificar.ForeColor = System.Drawing.Color.Black;
            this.BntModificar.Location = new System.Drawing.Point(49, 14);
            this.BntModificar.Name = "BntModificar";
            this.BntModificar.Size = new System.Drawing.Size(81, 53);
            this.BntModificar.TabIndex = 8;
            this.BntModificar.Text = "Generar";
            this.BntModificar.UseVisualStyleBackColor = false;
            this.BntModificar.Click += new System.EventHandler(this.BntModificar_Click);
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(328, 14);
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
            this.BntImprimir.Location = new System.Drawing.Point(188, 14);
            this.BntImprimir.Name = "BntImprimir";
            this.BntImprimir.Size = new System.Drawing.Size(81, 53);
            this.BntImprimir.TabIndex = 6;
            this.BntImprimir.Text = "Imprimir";
            this.BntImprimir.UseVisualStyleBackColor = false;
            this.BntImprimir.Click += new System.EventHandler(this.BntImprimir_Click);
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(24, 115);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(753, 267);
            this.DgvConsulta.TabIndex = 51;
            // 
            // TxtPagado
            // 
            this.TxtPagado.Location = new System.Drawing.Point(669, 410);
            this.TxtPagado.Name = "TxtPagado";
            this.TxtPagado.Size = new System.Drawing.Size(100, 20);
            this.TxtPagado.TabIndex = 52;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(418, 410);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento.TabIndex = 53;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(160, 410);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 54;
            // 
            // FrmRelacionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 472);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.TxtPagado);
            this.Controls.Add(this.DgvConsulta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRelacionPagos";
            this.Text = "FrmrelacionPagos";
            this.Load += new System.EventHandler(this.FrmRelacionPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntImprimir;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Button BntModificar;
        private System.Windows.Forms.TextBox TxtPagado;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.TextBox TxtPrecio;
    }
}