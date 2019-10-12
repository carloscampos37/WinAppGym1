namespace WinAppGym
{
    partial class MDIPrincipal1
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
            this.OpcionMenu = new System.Windows.Forms.MenuStrip();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERIODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBRESIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGRESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migracionSanAndresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huellasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasMembresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.membresiasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpcionMenu
            // 
            this.OpcionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tABLASToolStripMenuItem,
            this.iNGRESOSToolStripMenuItem,
            this.sALIRToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.sALIRToolStripMenuItem1});
            this.OpcionMenu.Location = new System.Drawing.Point(0, 0);
            this.OpcionMenu.Name = "OpcionMenu";
            this.OpcionMenu.Size = new System.Drawing.Size(850, 24);
            this.OpcionMenu.TabIndex = 0;
            this.OpcionMenu.Text = "OpcionMenu";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERIODOSToolStripMenuItem,
            this.mEMBRESIASToolStripMenuItem});
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // pERIODOSToolStripMenuItem
            // 
            this.pERIODOSToolStripMenuItem.Name = "pERIODOSToolStripMenuItem";
            this.pERIODOSToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pERIODOSToolStripMenuItem.Text = "PERIODOS";
            this.pERIODOSToolStripMenuItem.Click += new System.EventHandler(this.PERIODOSToolStripMenuItem_Click);
            // 
            // mEMBRESIASToolStripMenuItem
            // 
            this.mEMBRESIASToolStripMenuItem.Name = "mEMBRESIASToolStripMenuItem";
            this.mEMBRESIASToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mEMBRESIASToolStripMenuItem.Text = "MEMBRESIAS";
            this.mEMBRESIASToolStripMenuItem.Click += new System.EventHandler(this.MEMBRESIASToolStripMenuItem_Click);
            // 
            // iNGRESOSToolStripMenuItem
            // 
            this.iNGRESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMACIONToolStripMenuItem});
            this.iNGRESOSToolStripMenuItem.Name = "iNGRESOSToolStripMenuItem";
            this.iNGRESOSToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.iNGRESOSToolStripMenuItem.Text = "INGRESOS";
            // 
            // iNFORMACIONToolStripMenuItem
            // 
            this.iNFORMACIONToolStripMenuItem.Name = "iNFORMACIONToolStripMenuItem";
            this.iNFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.iNFORMACIONToolStripMenuItem.Text = "INFORMACION";
            this.iNFORMACIONToolStripMenuItem.Click += new System.EventHandler(this.INFORMACIONToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.sALIRToolStripMenuItem.Text = "CONSULTAS";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relacionDePagosToolStripMenuItem,
            this.membresiasPorFechasToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // relacionDePagosToolStripMenuItem
            // 
            this.relacionDePagosToolStripMenuItem.Name = "relacionDePagosToolStripMenuItem";
            this.relacionDePagosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.relacionDePagosToolStripMenuItem.Text = "Relacion de Pagos";
            this.relacionDePagosToolStripMenuItem.Click += new System.EventHandler(this.RelacionDePagosToolStripMenuItem_Click);
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.migracionSanAndresToolStripMenuItem,
            this.huellasToolStripMenuItem,
            this.pruebasMembresiasToolStripMenuItem,
            this.importarAsistenciaToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            this.pROCESOSToolStripMenuItem.Click += new System.EventHandler(this.PROCESOSToolStripMenuItem_Click);
            // 
            // migracionSanAndresToolStripMenuItem
            // 
            this.migracionSanAndresToolStripMenuItem.Name = "migracionSanAndresToolStripMenuItem";
            this.migracionSanAndresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.migracionSanAndresToolStripMenuItem.Text = "Migracion San Andres";
            this.migracionSanAndresToolStripMenuItem.Click += new System.EventHandler(this.MigracionSanAndresToolStripMenuItem_Click);
            // 
            // huellasToolStripMenuItem
            // 
            this.huellasToolStripMenuItem.Name = "huellasToolStripMenuItem";
            this.huellasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.huellasToolStripMenuItem.Text = "Modificacion Fechas";
            this.huellasToolStripMenuItem.Click += new System.EventHandler(this.HuellasToolStripMenuItem_Click);
            // 
            // pruebasMembresiasToolStripMenuItem
            // 
            this.pruebasMembresiasToolStripMenuItem.Name = "pruebasMembresiasToolStripMenuItem";
            this.pruebasMembresiasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pruebasMembresiasToolStripMenuItem.Text = "Ajustes Molinete";
            this.pruebasMembresiasToolStripMenuItem.Click += new System.EventHandler(this.PruebasMembresiasToolStripMenuItem_Click);
            // 
            // importarAsistenciaToolStripMenuItem
            // 
            this.importarAsistenciaToolStripMenuItem.Name = "importarAsistenciaToolStripMenuItem";
            this.importarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importarAsistenciaToolStripMenuItem.Text = "Importar Asistencia";
            this.importarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.ImportarAsistenciaToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.SALIRToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Panel1,
            this.Panel2,
            this.Panel3,
            this.Panel4,
            this.Panel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = false;
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(150, 17);
            this.Panel1.Text = "1";
            // 
            // Panel2
            // 
            this.Panel2.AutoSize = false;
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(150, 17);
            this.Panel2.Text = "2";
            // 
            // Panel3
            // 
            this.Panel3.AutoSize = false;
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(150, 17);
            this.Panel3.Text = "3";
            // 
            // Panel4
            // 
            this.Panel4.AutoSize = false;
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(150, 17);
            this.Panel4.Text = "4";
            // 
            // Panel5
            // 
            this.Panel5.AutoSize = false;
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(150, 17);
            this.Panel5.Text = "5";
            // 
            // membresiasPorFechasToolStripMenuItem
            // 
            this.membresiasPorFechasToolStripMenuItem.Name = "membresiasPorFechasToolStripMenuItem";
            this.membresiasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.membresiasPorFechasToolStripMenuItem.Text = "Membresias por Fechas";
            this.membresiasPorFechasToolStripMenuItem.Click += new System.EventHandler(this.MembresiasPorFechasToolStripMenuItem_Click);
            // 
            // MDIPrincipal1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OpcionMenu);
            this.Name = "MDIPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.OpcionMenu.ResumeLayout(false);
            this.OpcionMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OpcionMenu;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNGRESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERIODOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBRESIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relacionDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migracionSanAndresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huellasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebasMembresiasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Panel1;
        private System.Windows.Forms.ToolStripStatusLabel Panel2;
        private System.Windows.Forms.ToolStripStatusLabel Panel3;
        private System.Windows.Forms.ToolStripStatusLabel Panel4;
        private System.Windows.Forms.ToolStripStatusLabel Panel5;
        private System.Windows.Forms.ToolStripMenuItem importarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresiasPorFechasToolStripMenuItem;
    }
}