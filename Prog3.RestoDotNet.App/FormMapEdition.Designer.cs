namespace Prog3.RestoDotNet.App
{
    partial class FormMapEdition
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapEdition));
            this.PnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PnlToolBox = new System.Windows.Forms.Panel();
            this.TabControlToolBox = new System.Windows.Forms.TabControl();
            this.TabToolBoxTables = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MesaRect = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.MesaCuad = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WallHor = new System.Windows.Forms.PictureBox();
            this.WallVer = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MissPool = new System.Windows.Forms.PictureBox();
            this.MissBar = new System.Windows.Forms.PictureBox();
            this.PnlMap = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.cmenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MesaRed = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.PnlLayout.SuspendLayout();
            this.PnlToolBox.SuspendLayout();
            this.TabControlToolBox.SuspendLayout();
            this.TabToolBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.cmenuStripTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRed)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLayout
            // 
            this.PnlLayout.ColumnCount = 2;
            this.PnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.39689F));
            this.PnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.60311F));
            this.PnlLayout.Controls.Add(this.PnlToolBox, 0, 0);
            this.PnlLayout.Controls.Add(this.PnlMap, 1, 0);
            this.PnlLayout.Controls.Add(this.PnlButtons, 0, 1);
            this.PnlLayout.Controls.Add(this.LblEstado, 1, 1);
            this.PnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLayout.Location = new System.Drawing.Point(0, 0);
            this.PnlLayout.Name = "PnlLayout";
            this.PnlLayout.RowCount = 2;
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.84862F));
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.151382F));
            this.PnlLayout.Size = new System.Drawing.Size(1028, 568);
            this.PnlLayout.TabIndex = 1;
            // 
            // PnlToolBox
            // 
            this.PnlToolBox.Controls.Add(this.TabControlToolBox);
            this.PnlToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlToolBox.Location = new System.Drawing.Point(3, 3);
            this.PnlToolBox.Name = "PnlToolBox";
            this.PnlToolBox.Size = new System.Drawing.Size(142, 515);
            this.PnlToolBox.TabIndex = 2;
            // 
            // TabControlToolBox
            // 
            this.TabControlToolBox.Controls.Add(this.TabToolBoxTables);
            this.TabControlToolBox.Controls.Add(this.tabPage2);
            this.TabControlToolBox.Controls.Add(this.tabPage1);
            this.TabControlToolBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControlToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlToolBox.Location = new System.Drawing.Point(0, 0);
            this.TabControlToolBox.Name = "TabControlToolBox";
            this.TabControlToolBox.SelectedIndex = 0;
            this.TabControlToolBox.Size = new System.Drawing.Size(142, 515);
            this.TabControlToolBox.TabIndex = 2;
            // 
            // TabToolBoxTables
            // 
            this.TabToolBoxTables.Controls.Add(this.MesaRed);
            this.TabToolBoxTables.Controls.Add(this.label1);
            this.TabToolBoxTables.Controls.Add(this.label3);
            this.TabToolBoxTables.Controls.Add(this.label2);
            this.TabToolBoxTables.Controls.Add(this.MesaRect);
            this.TabToolBoxTables.Controls.Add(this.MesaCuad);
            this.TabToolBoxTables.Location = new System.Drawing.Point(4, 22);
            this.TabToolBoxTables.Name = "TabToolBoxTables";
            this.TabToolBoxTables.Padding = new System.Windows.Forms.Padding(3);
            this.TabToolBoxTables.Size = new System.Drawing.Size(134, 489);
            this.TabToolBoxTables.TabIndex = 0;
            this.TabToolBoxTables.Text = "Mesas";
            this.TabToolBoxTables.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "x4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x2";
            // 
            // MesaRect
            // 
            this.MesaRect.Image = ((System.Drawing.Image)(resources.GetObject("MesaRect.Image")));
            this.MesaRect.Location = new System.Drawing.Point(36, 258);
            this.MesaRect.Name = "MesaRect";
            this.MesaRect.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.RECTANGLE;
            this.MesaRect.Size = new System.Drawing.Size(60, 60);
            this.MesaRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRect.TabIndex = 1;
            this.MesaRect.TabStop = false;
            this.MesaRect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MesaCuad
            // 
            this.MesaCuad.Image = ((System.Drawing.Image)(resources.GetObject("MesaCuad.Image")));
            this.MesaCuad.Location = new System.Drawing.Point(36, 161);
            this.MesaCuad.Name = "MesaCuad";
            this.MesaCuad.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.SQUARE;
            this.MesaCuad.Size = new System.Drawing.Size(60, 60);
            this.MesaCuad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaCuad.TabIndex = 1;
            this.MesaCuad.TabStop = false;
            this.MesaCuad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WallHor);
            this.tabPage2.Controls.Add(this.WallVer);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(134, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paredes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WallHor
            // 
            this.WallHor.Image = ((System.Drawing.Image)(resources.GetObject("WallHor.Image")));
            this.WallHor.Location = new System.Drawing.Point(28, 263);
            this.WallHor.Name = "WallHor";
            this.WallHor.Size = new System.Drawing.Size(70, 70);
            this.WallHor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WallHor.TabIndex = 5;
            this.WallHor.TabStop = false;
            this.WallHor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // WallVer
            // 
            this.WallVer.Image = ((System.Drawing.Image)(resources.GetObject("WallVer.Image")));
            this.WallVer.Location = new System.Drawing.Point(28, 142);
            this.WallVer.Name = "WallVer";
            this.WallVer.Size = new System.Drawing.Size(70, 70);
            this.WallVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WallVer.TabIndex = 4;
            this.WallVer.TabStop = false;
            this.WallVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vertical";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.MissPool);
            this.tabPage1.Controls.Add(this.MissBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(134, 489);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Deco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 352);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissPool
            // 
            this.MissPool.Image = ((System.Drawing.Image)(resources.GetObject("MissPool.Image")));
            this.MissPool.Location = new System.Drawing.Point(18, 94);
            this.MissPool.Name = "MissPool";
            this.MissPool.Size = new System.Drawing.Size(92, 81);
            this.MissPool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissPool.TabIndex = 3;
            this.MissPool.TabStop = false;
            this.MissPool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissBar
            // 
            this.MissBar.Image = ((System.Drawing.Image)(resources.GetObject("MissBar.Image")));
            this.MissBar.Location = new System.Drawing.Point(18, 8);
            this.MissBar.Name = "MissBar";
            this.MissBar.Size = new System.Drawing.Size(92, 81);
            this.MissBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissBar.TabIndex = 1;
            this.MissBar.TabStop = false;
            this.MissBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // PnlMap
            // 
            this.PnlMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMap.Location = new System.Drawing.Point(151, 3);
            this.PnlMap.Name = "PnlMap";
            this.PnlMap.Size = new System.Drawing.Size(874, 515);
            this.PnlMap.TabIndex = 1;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnSave);
            this.PnlButtons.Controls.Add(this.BtnCancel);
            this.PnlButtons.Location = new System.Drawing.Point(3, 524);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(124, 40);
            this.PnlButtons.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(67, 9);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(54, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(6, 9);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(58, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(150, 521);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(876, 47);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Agregue mesas presionando sobre ellas!";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmenuStripTable
            // 
            this.cmenuStripTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmenuStripTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fijarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmenuStripTable.Name = "cmenuStripTable";
            this.cmenuStripTable.Size = new System.Drawing.Size(118, 48);
            // 
            // fijarToolStripMenuItem
            // 
            this.fijarToolStripMenuItem.Name = "fijarToolStripMenuItem";
            this.fijarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.fijarToolStripMenuItem.Text = "Fijar";
            this.fijarToolStripMenuItem.Click += new System.EventHandler(this.FijarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // MesaRed
            // 
            this.MesaRed.Image = ((System.Drawing.Image)(resources.GetObject("MesaRed.Image")));
            this.MesaRed.Location = new System.Drawing.Point(36, 75);
            this.MesaRed.Name = "MesaRed";
            this.MesaRed.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.CIRCLE;
            this.MesaRed.Size = new System.Drawing.Size(60, 60);
            this.MesaRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRed.TabIndex = 5;
            this.MesaRed.TabStop = false;
            this.MesaRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // FormMapEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.PnlLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMapEdition";
            this.Text = "Editar Mapa";
            this.PnlLayout.ResumeLayout(false);
            this.PnlToolBox.ResumeLayout(false);
            this.TabControlToolBox.ResumeLayout(false);
            this.TabToolBoxTables.ResumeLayout(false);
            this.TabToolBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.cmenuStripTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MesaRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Prog3.RestoDotNet.App.Custom_Items.ReferenceTable MesaRect;
        private Prog3.RestoDotNet.App.Custom_Items.ReferenceTable MesaCuad;
        private System.Windows.Forms.TableLayoutPanel PnlLayout;
        private System.Windows.Forms.Panel PnlToolBox;
        private System.Windows.Forms.TabControl TabControlToolBox;
        private System.Windows.Forms.TabPage TabToolBoxTables;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PnlMap;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem fijarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.PictureBox WallHor;
        private System.Windows.Forms.PictureBox WallVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox MissBar;
        private System.Windows.Forms.PictureBox MissPool;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label1;
        private Custom_Items.ReferenceTable MesaRed;
    }
}

