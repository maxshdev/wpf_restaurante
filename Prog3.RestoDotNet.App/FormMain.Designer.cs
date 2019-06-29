namespace Prog3.RestoDotNet.App
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PnlMapLoad = new System.Windows.Forms.Panel();
            this.cMenuStripMapLoad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarMapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStripMapLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMapLoad
            // 
            this.PnlMapLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMapLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlMapLoad.BackgroundImage")));
            this.PnlMapLoad.Location = new System.Drawing.Point(12, 157);
            this.PnlMapLoad.Name = "PnlMapLoad";
            this.PnlMapLoad.Size = new System.Drawing.Size(892, 515);
            this.PnlMapLoad.TabIndex = 2;
            this.PnlMapLoad.Visible = false;
            // 
            // cMenuStripMapLoad
            // 
            this.cMenuStripMapLoad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.cerrarPedidoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cMenuStripMapLoad.Name = "cMenuStripMapLoad";
            this.cMenuStripMapLoad.Size = new System.Drawing.Size(147, 70);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.verToolStripMenuItem.Text = "Ver Estado";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.VerToolStripMenuItem_Click);
            // 
            // cerrarPedidoToolStripMenuItem
            // 
            this.cerrarPedidoToolStripMenuItem.Name = "cerrarPedidoToolStripMenuItem";
            this.cerrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cerrarPedidoToolStripMenuItem.Text = "Cerrar Pedido";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarMapaToolStripMenuItem,
            this.crearMapaToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cargarMapaToolStripMenuItem
            // 
            this.cargarMapaToolStripMenuItem.Name = "cargarMapaToolStripMenuItem";
            this.cargarMapaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cargarMapaToolStripMenuItem.Text = "Cargar Mapa";
            this.cargarMapaToolStripMenuItem.Click += new System.EventHandler(this.CargarMapaToolStripMenuItem_Click);
            // 
            // crearMapaToolStripMenuItem
            // 
            this.crearMapaToolStripMenuItem.Name = "crearMapaToolStripMenuItem";
            this.crearMapaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crearMapaToolStripMenuItem.Text = "Crear Mapa";
            this.crearMapaToolStripMenuItem.Click += new System.EventHandler(this.CrearMapaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesiónToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 684);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlMapLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Resto DotNet";
            this.cMenuStripMapLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMapLoad;
        private System.Windows.Forms.ContextMenuStrip cMenuStripMapLoad;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarPedidoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarMapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}