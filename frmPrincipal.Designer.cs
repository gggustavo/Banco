namespace Banco
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titularesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositarExtraerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulareslistadoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadocuentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(784, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titularesMenuItem,
            this.CuentasMenuItem,
            this.toolStripSeparator1,
            this.salirMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // titularesMenuItem
            // 
            this.titularesMenuItem.Name = "titularesMenuItem";
            this.titularesMenuItem.Size = new System.Drawing.Size(205, 38);
            this.titularesMenuItem.Text = "Titulares";
            this.titularesMenuItem.Click += new System.EventHandler(this.titularesMenuItem_Click);
            // 
            // CuentasMenuItem
            // 
            this.CuentasMenuItem.Name = "CuentasMenuItem";
            this.CuentasMenuItem.Size = new System.Drawing.Size(205, 38);
            this.CuentasMenuItem.Text = "Cuentas";
            this.CuentasMenuItem.Click += new System.EventHandler(this.CuentasMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(205, 38);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositarExtraerMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // depositarExtraerMenuItem
            // 
            this.depositarExtraerMenuItem.Name = "depositarExtraerMenuItem";
            this.depositarExtraerMenuItem.Size = new System.Drawing.Size(298, 38);
            this.depositarExtraerMenuItem.Text = "Depositar/Extraer";
            this.depositarExtraerMenuItem.Click += new System.EventHandler(this.depositarExtraerMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titulareslistadoMenuItem,
            this.listadocuentasMenuItem,
            this.movimientosMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // titulareslistadoMenuItem
            // 
            this.titulareslistadoMenuItem.Name = "titulareslistadoMenuItem";
            this.titulareslistadoMenuItem.Size = new System.Drawing.Size(269, 38);
            this.titulareslistadoMenuItem.Text = "Titulares";
            this.titulareslistadoMenuItem.Click += new System.EventHandler(this.titulareslistadoMenuItem_Click);
            // 
            // listadocuentasMenuItem
            // 
            this.listadocuentasMenuItem.Name = "listadocuentasMenuItem";
            this.listadocuentasMenuItem.Size = new System.Drawing.Size(269, 38);
            this.listadocuentasMenuItem.Text = "Cuentas";
            this.listadocuentasMenuItem.Click += new System.EventHandler(this.listadocuentasMenuItem_Click);
            // 
            // movimientosMenuItem
            // 
            this.movimientosMenuItem.Name = "movimientosMenuItem";
            this.movimientosMenuItem.Size = new System.Drawing.Size(269, 38);
            this.movimientosMenuItem.Text = "Movimientos";
            this.movimientosMenuItem.Click += new System.EventHandler(this.movimientosMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titularesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CuentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titulareslistadoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadocuentasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositarExtraerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem movimientosMenuItem;
    }
}

