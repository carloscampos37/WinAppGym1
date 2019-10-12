namespace WinAppGym
{
    partial class FrmImportarExcel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntGrabar = new System.Windows.Forms.Button();
            this.BntAdicionar = new System.Windows.Forms.Button();
            this.BntImportar = new System.Windows.Forms.Button();
            this.BntEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-11, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 356);
            this.dataGridView1.TabIndex = 2;
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BntCancelar.ForeColor = System.Drawing.Color.Black;
            this.BntCancelar.Location = new System.Drawing.Point(456, 12);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(81, 53);
            this.BntCancelar.TabIndex = 12;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(613, 12);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(81, 53);
            this.BntSalir.TabIndex = 11;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = false;
            this.BntSalir.Click += new System.EventHandler(this.BntSalir_Click);
            // 
            // BntGrabar
            // 
            this.BntGrabar.BackColor = System.Drawing.Color.White;
            this.BntGrabar.ForeColor = System.Drawing.Color.Black;
            this.BntGrabar.Location = new System.Drawing.Point(168, 12);
            this.BntGrabar.Name = "BntGrabar";
            this.BntGrabar.Size = new System.Drawing.Size(81, 53);
            this.BntGrabar.TabIndex = 10;
            this.BntGrabar.Text = "Grabar";
            this.BntGrabar.UseVisualStyleBackColor = false;
            this.BntGrabar.Click += new System.EventHandler(this.BntGrabar_Click);
            // 
            // BntAdicionar
            // 
            this.BntAdicionar.BackColor = System.Drawing.Color.Yellow;
            this.BntAdicionar.ForeColor = System.Drawing.Color.Black;
            this.BntAdicionar.Location = new System.Drawing.Point(-90, 12);
            this.BntAdicionar.Name = "BntAdicionar";
            this.BntAdicionar.Size = new System.Drawing.Size(81, 53);
            this.BntAdicionar.TabIndex = 9;
            this.BntAdicionar.Text = "Agregar Socio";
            this.BntAdicionar.UseVisualStyleBackColor = false;
            // 
            // BntImportar
            // 
            this.BntImportar.BackColor = System.Drawing.Color.Yellow;
            this.BntImportar.ForeColor = System.Drawing.Color.Black;
            this.BntImportar.Location = new System.Drawing.Point(35, 12);
            this.BntImportar.Name = "BntImportar";
            this.BntImportar.Size = new System.Drawing.Size(81, 53);
            this.BntImportar.TabIndex = 13;
            this.BntImportar.Text = "Importar";
            this.BntImportar.UseVisualStyleBackColor = false;
            this.BntImportar.Click += new System.EventHandler(this.BntImportar_Click);
            // 
            // BntEliminar
            // 
            this.BntEliminar.BackColor = System.Drawing.Color.Pink;
            this.BntEliminar.ForeColor = System.Drawing.Color.Black;
            this.BntEliminar.Location = new System.Drawing.Point(317, 12);
            this.BntEliminar.Name = "BntEliminar";
            this.BntEliminar.Size = new System.Drawing.Size(81, 53);
            this.BntEliminar.TabIndex = 14;
            this.BntEliminar.Text = "Eliminar";
            this.BntEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BntEliminar);
            this.Controls.Add(this.BntImportar);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BntSalir);
            this.Controls.Add(this.BntGrabar);
            this.Controls.Add(this.BntAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmImportarExcel";
            this.Text = "FrmImportarExcel";
            this.Load += new System.EventHandler(this.FrmImportarExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntGrabar;
        private System.Windows.Forms.Button BntAdicionar;
        private System.Windows.Forms.Button BntImportar;
        private System.Windows.Forms.Button BntEliminar;
    }
}