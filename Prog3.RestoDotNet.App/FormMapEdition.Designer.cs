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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MesaRedo = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.MesaCuad = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.MesaRec = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WallHor = new System.Windows.Forms.PictureBox();
            this.WallVer = new System.Windows.Forms.PictureBox();
            this.WallCol = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MissPool = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MissBar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PnlMap = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cmenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlLayout.SuspendLayout();
            this.PnlToolBox.SuspendLayout();
            this.TabControlToolBox.SuspendLayout();
            this.TabToolBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRec)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallCol)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.cmenuStripTable.SuspendLayout();
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
            this.PnlLayout.Controls.Add(this.btnDraw, 1, 1);
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
            this.TabToolBoxTables.Controls.Add(this.label3);
            this.TabToolBoxTables.Controls.Add(this.label2);
            this.TabToolBoxTables.Controls.Add(this.label1);
            this.TabToolBoxTables.Controls.Add(this.MesaRedo);
            this.TabToolBoxTables.Controls.Add(this.MesaCuad);
            this.TabToolBoxTables.Controls.Add(this.MesaRec);
            this.TabToolBoxTables.Location = new System.Drawing.Point(4, 22);
            this.TabToolBoxTables.Name = "TabToolBoxTables";
            this.TabToolBoxTables.Padding = new System.Windows.Forms.Padding(3);
            this.TabToolBoxTables.Size = new System.Drawing.Size(134, 489);
            this.TabToolBoxTables.TabIndex = 0;
            this.TabToolBoxTables.Text = "Mesas";
            this.TabToolBoxTables.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red (4)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuad (2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rect (6)";
            // 
            // MesaRedo
            // 
            this.MesaRedo.Image = ((System.Drawing.Image)(resources.GetObject("MesaRedo.Image")));
            this.MesaRedo.Location = new System.Drawing.Point(36, 258);
            this.MesaRedo.Name = "MesaRedo";
            this.MesaRedo.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.CIRCLE;
            this.MesaRedo.Size = new System.Drawing.Size(60, 60);
            this.MesaRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRedo.TabIndex = 1;
            this.MesaRedo.TabStop = false;
            this.MesaRedo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
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
            // MesaRec
            // 
            this.MesaRec.Image = ((System.Drawing.Image)(resources.GetObject("MesaRec.Image")));
            this.MesaRec.Location = new System.Drawing.Point(36, 38);
            this.MesaRec.Name = "MesaRec";
            this.MesaRec.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.RECTANGLE;
            this.MesaRec.Size = new System.Drawing.Size(53, 86);
            this.MesaRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRec.TabIndex = 1;
            this.MesaRec.TabStop = false;
            this.MesaRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WallHor);
            this.tabPage2.Controls.Add(this.WallVer);
            this.tabPage2.Controls.Add(this.WallCol);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
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
            this.WallHor.Location = new System.Drawing.Point(40, 263);
            this.WallHor.Name = "WallHor";
            this.WallHor.Size = new System.Drawing.Size(51, 50);
            this.WallHor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallHor.TabIndex = 5;
            this.WallHor.TabStop = false;
            this.WallHor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // WallVer
            // 
            this.WallVer.Image = ((System.Drawing.Image)(resources.GetObject("WallVer.Image")));
            this.WallVer.Location = new System.Drawing.Point(40, 142);
            this.WallVer.Name = "WallVer";
            this.WallVer.Size = new System.Drawing.Size(51, 50);
            this.WallVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallVer.TabIndex = 4;
            this.WallVer.TabStop = false;
            this.WallVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // WallCol
            // 
            this.WallCol.Image = ((System.Drawing.Image)(resources.GetObject("WallCol.Image")));
            this.WallCol.Location = new System.Drawing.Point(40, 40);
            this.WallCol.Name = "WallCol";
            this.WallCol.Size = new System.Drawing.Size(51, 50);
            this.WallCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallCol.TabIndex = 3;
            this.WallCol.TabStop = false;
            this.WallCol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 247);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Columna";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MissPool);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.MissBar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(134, 489);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Deco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MissPool
            // 
            this.MissPool.Image = ((System.Drawing.Image)(resources.GetObject("MissPool.Image")));
            this.MissPool.Location = new System.Drawing.Point(21, 170);
            this.MissPool.Name = "MissPool";
            this.MissPool.Size = new System.Drawing.Size(92, 81);
            this.MissPool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissPool.TabIndex = 3;
            this.MissPool.TabStop = false;
            this.MissPool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Pool";
            // 
            // MissBar
            // 
            this.MissBar.Image = ((System.Drawing.Image)(resources.GetObject("MissBar.Image")));
            this.MissBar.Location = new System.Drawing.Point(18, 48);
            this.MissBar.Name = "MissBar";
            this.MissBar.Size = new System.Drawing.Size(92, 81);
            this.MissBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissBar.TabIndex = 1;
            this.MissBar.TabStop = false;
            this.MissBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "BarTender";
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
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(151, 524);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.MesaRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRec)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallCol)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.cmenuStripTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Prog3.RestoDotNet.App.Custom_Items.ReferenceTable MesaRec;
        private Prog3.RestoDotNet.App.Custom_Items.ReferenceTable MesaRedo;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem fijarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.PictureBox WallHor;
        private System.Windows.Forms.PictureBox WallVer;
        private System.Windows.Forms.PictureBox WallCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox MissBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox MissPool;
        private System.Windows.Forms.Label label8;
    }
}

