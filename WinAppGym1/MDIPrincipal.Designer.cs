namespace WinAppGym1
{
    partial class MDIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERIODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBRESIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGRESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tABLASToolStripMenuItem,
            this.iNGRESOSToolStripMenuItem,
            this.sALIRToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.sALIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERIODOSToolStripMenuItem,
            this.mEMBRESIASToolStripMenuItem});
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            this.tABLASToolStripMenuItem.Click += new System.EventHandler(this.tABLASToolStripMenuItem_Click);
            // 
            // pERIODOSToolStripMenuItem
            // 
            this.pERIODOSToolStripMenuItem.Name = "pERIODOSToolStripMenuItem";
            this.pERIODOSToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pERIODOSToolStripMenuItem.Text = "PERIODOS";
            // 
            // mEMBRESIASToolStripMenuItem
            // 
            this.mEMBRESIASToolStripMenuItem.Name = "mEMBRESIASToolStripMenuItem";
            this.mEMBRESIASToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mEMBRESIASToolStripMenuItem.Text = "MEMBRESIAS";
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
            this.iNFORMACIONToolStripMenuItem.Click += new System.EventHandler(this.iNFORMACIONToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.sALIRToolStripMenuItem.Text = "CONSULTAS";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.sALIRToolStripMenuItem1_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNGRESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERIODOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBRESIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
    }
}