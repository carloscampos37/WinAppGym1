namespace AppGym.Forms
{
    partial class FrmPeriodos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNroSocios = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.ctr_AyuPeriodos = new Ctr_Ayuda.Ctr_Ayuda();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkGrupal = new System.Windows.Forms.CheckBox();
            this.ChkLimitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtptermino = new System.Windows.Forms.DateTimePicker();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BntImprimir = new System.Windows.Forms.Button();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntSalir = new System.Windows.Forms.Button();
            this.BntGrabar = new System.Windows.Forms.Button();
            this.BntAnular = new System.Windows.Forms.Button();
            this.BntModificar = new System.Windows.Forms.Button();
            this.BntAdicionar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 326);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgvConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membresias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AllowUserToAddRows = false;
            this.DgvConsulta.AllowUserToDeleteRows = false;
            this.DgvConsulta.AllowUserToOrderColumns = true;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Periodo,
            this.Precio,
            this.Grupal});
            this.DgvConsulta.Location = new System.Drawing.Point(16, 7);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.ReadOnly = true;
            this.DgvConsulta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvConsulta.Size = new System.Drawing.Size(739, 279);
            this.DgvConsulta.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 43;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 86;
            // 
            // Periodo
            // 
            this.Periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Periodo.DataPropertyName = "meses";
            this.Periodo.HeaderText = "Meses";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 63;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "dias";
            this.Precio.HeaderText = "Dias";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Grupal
            // 
            this.Grupal.DataPropertyName = "estadoanulado";
            this.Grupal.HeaderText = "Estado";
            this.Grupal.Name = "Grupal";
            this.Grupal.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChkEstado);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtNroSocios);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtPrecio);
            this.tabPage2.Controls.Add(this.ctr_AyuPeriodos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ChkGrupal);
            this.tabPage2.Controls.Add(this.ChkLimitado);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Dtptermino);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.DtpInicio);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkEstado.Location = new System.Drawing.Point(562, 180);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(86, 31);
            this.ChkEstado.TabIndex = 125;
            this.ChkEstado.Text = "Estado Anulado";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(371, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 124;
            this.label7.Text = "Nro de socios";
            // 
            // TxtNroSocios
            // 
            this.TxtNroSocios.Location = new System.Drawing.Point(371, 191);
            this.TxtNroSocios.Name = "TxtNroSocios";
            this.TxtNroSocios.Size = new System.Drawing.Size(97, 20);
            this.TxtNroSocios.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(193, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 122;
            this.label6.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(177, 191);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(97, 20);
            this.TxtPrecio.TabIndex = 121;
            // 
            // ctr_AyuPeriodos
            // 
            this.ctr_AyuPeriodos.CampoDevCod = "Id";
            this.ctr_AyuPeriodos.CampoDevDesc = "Descripcion";
            this.ctr_AyuPeriodos.Codigo = "";
            this.ctr_AyuPeriodos.Descripcion = "";
            this.ctr_AyuPeriodos.Filtro = "";
            this.ctr_AyuPeriodos.ListaAlias = "Codigo,Descripcion";
            this.ctr_AyuPeriodos.ListaCampos = "Id,Descripcion";
            this.ctr_AyuPeriodos.Location = new System.Drawing.Point(474, 39);
            this.ctr_AyuPeriodos.LongCod = "2";
            this.ctr_AyuPeriodos.LongDesc = "50";
            this.ctr_AyuPeriodos.Name = "ctr_AyuPeriodos";
            this.ctr_AyuPeriodos.NombreTabla = "Periodos";
            this.ctr_AyuPeriodos.Requerido = false;
            this.ctr_AyuPeriodos.Size = new System.Drawing.Size(264, 30);
            this.ctr_AyuPeriodos.TabIndex = 120;
            this.ctr_AyuPeriodos.Titulo = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(242, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 50;
            // 
            // ChkGrupal
            // 
            this.ChkGrupal.AutoSize = true;
            this.ChkGrupal.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkGrupal.Location = new System.Drawing.Point(21, 172);
            this.ChkGrupal.Name = "ChkGrupal";
            this.ChkGrupal.Size = new System.Drawing.Size(96, 31);
            this.ChkGrupal.TabIndex = 47;
            this.ChkGrupal.Text = "Membresia Grupal";
            this.ChkGrupal.UseVisualStyleBackColor = true;
            // 
            // ChkLimitado
            // 
            this.ChkLimitado.AutoSize = true;
            this.ChkLimitado.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkLimitado.Location = new System.Drawing.Point(21, 99);
            this.ChkLimitado.Name = "ChkLimitado";
            this.ChkLimitado.Size = new System.Drawing.Size(93, 31);
            this.ChkLimitado.TabIndex = 46;
            this.ChkLimitado.Text = "Vigencia Ilimitada";
            this.ChkLimitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(535, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Periodo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(357, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Termino Vigencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(183, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Inicio Vigencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(227, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(44, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id";
            // 
            // Dtptermino
            // 
            this.Dtptermino.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dtptermino.Enabled = false;
            this.Dtptermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtptermino.Location = new System.Drawing.Point(371, 118);
            this.Dtptermino.Name = "Dtptermino";
            this.Dtptermino.Size = new System.Drawing.Size(105, 20);
            this.Dtptermino.TabIndex = 39;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(126, 39);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(339, 20);
            this.TxtDescripcion.TabIndex = 37;
            // 
            // DtpInicio
            // 
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(186, 118);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(98, 20);
            this.DtpInicio.TabIndex = 38;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(21, 39);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(79, 20);
            this.TxtId.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BntImprimir);
            this.panel3.Controls.Add(this.BntCancelar);
            this.panel3.Controls.Add(this.BntSalir);
            this.panel3.Controls.Add(this.BntGrabar);
            this.panel3.Controls.Add(this.BntAnular);
            this.panel3.Controls.Add(this.BntModificar);
            this.panel3.Controls.Add(this.BntAdicionar);
            this.panel3.Location = new System.Drawing.Point(12, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 82);
            this.panel3.TabIndex = 13;
            // 
            // BntImprimir
            // 
            this.BntImprimir.BackColor = System.Drawing.Color.Snow;
            this.BntImprimir.ForeColor = System.Drawing.Color.Black;
            this.BntImprimir.Location = new System.Drawing.Point(557, 13);
            this.BntImprimir.Name = "BntImprimir";
            this.BntImprimir.Size = new System.Drawing.Size(81, 53);
            this.BntImprimir.TabIndex = 9;
            this.BntImprimir.Text = "Imprimir";
            this.BntImprimir.UseVisualStyleBackColor = false;
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BntCancelar.ForeColor = System.Drawing.Color.Black;
            this.BntCancelar.Location = new System.Drawing.Point(456, 13);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(81, 53);
            this.BntCancelar.TabIndex = 8;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            // 
            // BntSalir
            // 
            this.BntSalir.BackColor = System.Drawing.Color.Aqua;
            this.BntSalir.ForeColor = System.Drawing.Color.Black;
            this.BntSalir.Location = new System.Drawing.Point(661, 13);
            this.BntSalir.Name = "BntSalir";
            this.BntSalir.Size = new System.Drawing.Size(81, 53);
            this.BntSalir.TabIndex = 7;
            this.BntSalir.Text = "Salir";
            this.BntSalir.UseVisualStyleBackColor = false;
            // 
            // BntGrabar
            // 
            this.BntGrabar.BackColor = System.Drawing.Color.White;
            this.BntGrabar.ForeColor = System.Drawing.Color.Black;
            this.BntGrabar.Location = new System.Drawing.Point(332, 13);
            this.BntGrabar.Name = "BntGrabar";
            this.BntGrabar.Size = new System.Drawing.Size(81, 53);
            this.BntGrabar.TabIndex = 5;
            this.BntGrabar.Text = "Grabar";
            this.BntGrabar.UseVisualStyleBackColor = false;
            this.BntGrabar.Click += new System.EventHandler(this.BntGrabar_Click);
            // 
            // BntAnular
            // 
            this.BntAnular.BackColor = System.Drawing.Color.Red;
            this.BntAnular.ForeColor = System.Drawing.Color.Black;
            this.BntAnular.Location = new System.Drawing.Point(221, 13);
            this.BntAnular.Name = "BntAnular";
            this.BntAnular.Size = new System.Drawing.Size(81, 53);
            this.BntAnular.TabIndex = 4;
            this.BntAnular.Text = "Anular";
            this.BntAnular.UseVisualStyleBackColor = false;
            // 
            // BntModificar
            // 
            this.BntModificar.BackColor = System.Drawing.Color.LawnGreen;
            this.BntModificar.ForeColor = System.Drawing.Color.Black;
            this.BntModificar.Location = new System.Drawing.Point(108, 13);
            this.BntModificar.Name = "BntModificar";
            this.BntModificar.Size = new System.Drawing.Size(81, 53);
            this.BntModificar.TabIndex = 2;
            this.BntModificar.Text = "Modificar";
            this.BntModificar.UseVisualStyleBackColor = false;
            // 
            // BntAdicionar
            // 
            this.BntAdicionar.BackColor = System.Drawing.Color.Yellow;
            this.BntAdicionar.ForeColor = System.Drawing.Color.Black;
            this.BntAdicionar.Location = new System.Drawing.Point(8, 13);
            this.BntAdicionar.Name = "BntAdicionar";
            this.BntAdicionar.Size = new System.Drawing.Size(81, 53);
            this.BntAdicionar.TabIndex = 1;
            this.BntAdicionar.Text = "Agregar";
            this.BntAdicionar.UseVisualStyleBackColor = false;
            // 
            // FrmPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmPeriodos";
            this.Text = "FrmPeriodos";
            this.Load += new System.EventHandler(this.FrmPeriodos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ChkEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNroSocios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrecio;
        internal Ctr_Ayuda.Ctr_Ayuda ctr_AyuPeriodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkGrupal;
        private System.Windows.Forms.CheckBox ChkLimitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtptermino;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BntImprimir;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntSalir;
        private System.Windows.Forms.Button BntGrabar;
        private System.Windows.Forms.Button BntAnular;
        private System.Windows.Forms.Button BntModificar;
        private System.Windows.Forms.Button BntAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupal;
    }
}