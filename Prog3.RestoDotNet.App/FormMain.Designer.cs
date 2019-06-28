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
            this.btnMapEdit = new System.Windows.Forms.Button();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.PnlMapLoad = new System.Windows.Forms.Panel();
            this.cMenuStripMapLoad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cMenuStripMapLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMapEdit
            // 
            this.btnMapEdit.Location = new System.Drawing.Point(102, 12);
            this.btnMapEdit.Name = "btnMapEdit";
            this.btnMapEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMapEdit.TabIndex = 0;
            this.btnMapEdit.Text = "Editar Mapa";
            this.btnMapEdit.UseVisualStyleBackColor = true;
            this.btnMapEdit.Click += new System.EventHandler(this.BtnMapEdit_Click);
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.Location = new System.Drawing.Point(12, 12);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(84, 23);
            this.btnMapLoad.TabIndex = 1;
            this.btnMapLoad.Text = "Cargar Mapa";
            this.btnMapLoad.UseVisualStyleBackColor = true;
            this.btnMapLoad.Click += new System.EventHandler(this.BtnMapLoad_Click);
            // 
            // PnlMapLoad
            // 
            this.PnlMapLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMapLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlMapLoad.BackgroundImage")));
            this.PnlMapLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlMapLoad);
            this.Controls.Add(this.btnMapLoad);
            this.Controls.Add(this.btnMapEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Resto DotNet";
            this.cMenuStripMapLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMapEdit;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.Panel PnlMapLoad;
        private System.Windows.Forms.ContextMenuStrip cMenuStripMapLoad;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarPedidoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}