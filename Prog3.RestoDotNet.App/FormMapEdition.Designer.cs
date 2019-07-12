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
            this.MesaRed = new Prog3.RestoDotNet.App.ReferenceTable();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MesaRect = new Prog3.RestoDotNet.App.ReferenceTable();
            this.MesaCuad = new Prog3.RestoDotNet.App.ReferenceTable();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WallHor = new Prog3.RestoDotNet.App.ReferenceObject();
            this.WallVer = new Prog3.RestoDotNet.App.ReferenceObject();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MissTV = new Prog3.RestoDotNet.App.ReferenceObject();
            this.MissCash = new Prog3.RestoDotNet.App.ReferenceObject();
            this.MissBar = new Prog3.RestoDotNet.App.ReferenceObject();
            this.MissMenu = new Prog3.RestoDotNet.App.ReferenceObject();
            this.PnlMap = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.cmenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlLayout.SuspendLayout();
            this.PnlToolBox.SuspendLayout();
            this.TabControlToolBox.SuspendLayout();
            this.TabToolBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissMenu)).BeginInit();
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
            this.PnlLayout.Controls.Add(this.PnlButtons, 0, 1);
            this.PnlLayout.Controls.Add(this.LblEstado, 1, 1);
            this.PnlLayout.Controls.Add(this.PnlMap, 1, 0);
            this.PnlLayout.Location = new System.Drawing.Point(0, 0);
            this.PnlLayout.Name = "PnlLayout";
            this.PnlLayout.RowCount = 2;
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.84862F));
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.151382F));
            this.PnlLayout.Size = new System.Drawing.Size(1423, 715);
            this.PnlLayout.TabIndex = 1;
            // 
            // PnlToolBox
            // 
            this.PnlToolBox.Controls.Add(this.TabControlToolBox);
            this.PnlToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlToolBox.Location = new System.Drawing.Point(3, 3);
            this.PnlToolBox.Name = "PnlToolBox";
            this.PnlToolBox.Size = new System.Drawing.Size(198, 650);
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
            this.TabControlToolBox.Size = new System.Drawing.Size(198, 650);
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
            this.TabToolBoxTables.Size = new System.Drawing.Size(190, 624);
            this.TabToolBoxTables.TabIndex = 0;
            this.TabToolBoxTables.Text = "Mesas";
            this.TabToolBoxTables.UseVisualStyleBackColor = true;
            // 
            // MesaRed
            // 
            this.MesaRed.Image = ((System.Drawing.Image)(resources.GetObject("MesaRed.Image")));
            this.MesaRed.Location = new System.Drawing.Point(36, 75);
            this.MesaRed.Name = "MesaRed";
            this.MesaRed.ResizeTo = new System.Drawing.Size(90, 90);
            this.MesaRed.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.CIRCLE;
            this.MesaRed.Size = new System.Drawing.Size(60, 60);
            this.MesaRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRed.TabIndex = 5;
            this.MesaRed.TabStop = false;
            this.MesaRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
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
            this.MesaRect.ResizeTo = new System.Drawing.Size(180, 150);
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
            this.MesaCuad.ResizeTo = new System.Drawing.Size(120, 120);
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
            this.tabPage2.Size = new System.Drawing.Size(160, 768);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paredes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WallHor
            // 
            this.WallHor.Image = ((System.Drawing.Image)(resources.GetObject("WallHor.Image")));
            this.WallHor.Location = new System.Drawing.Point(28, 263);
            this.WallHor.Name = "WallHor";
            this.WallHor.ResizeTo = new System.Drawing.Size(110, 100);
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
            this.WallVer.ResizeTo = new System.Drawing.Size(110, 100);
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
            this.tabPage1.Controls.Add(this.MissTV);
            this.tabPage1.Controls.Add(this.MissCash);
            this.tabPage1.Controls.Add(this.MissBar);
            this.tabPage1.Controls.Add(this.MissMenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 768);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Deco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MissTV
            // 
            this.MissTV.Image = ((System.Drawing.Image)(resources.GetObject("MissTV.Image")));
            this.MissTV.Location = new System.Drawing.Point(18, 352);
            this.MissTV.Name = "MissTV";
            this.MissTV.ResizeTo = new System.Drawing.Size(90, 90);
            this.MissTV.Size = new System.Drawing.Size(92, 81);
            this.MissTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissTV.TabIndex = 8;
            this.MissTV.TabStop = false;
            this.MissTV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissCash
            // 
            this.MissCash.Image = ((System.Drawing.Image)(resources.GetObject("MissCash.Image")));
            this.MissCash.Location = new System.Drawing.Point(18, 252);
            this.MissCash.Name = "MissCash";
            this.MissCash.ResizeTo = new System.Drawing.Size(200, 180);
            this.MissCash.Size = new System.Drawing.Size(92, 81);
            this.MissCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissCash.TabIndex = 7;
            this.MissCash.TabStop = false;
            this.MissCash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissBar
            // 
            this.MissBar.Image = ((System.Drawing.Image)(resources.GetObject("MissBar.Image")));
            this.MissBar.Location = new System.Drawing.Point(18, 155);
            this.MissBar.Name = "MissBar";
            this.MissBar.ResizeTo = new System.Drawing.Size(350, 380);
            this.MissBar.Size = new System.Drawing.Size(92, 81);
            this.MissBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissBar.TabIndex = 5;
            this.MissBar.TabStop = false;
            this.MissBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissMenu
            // 
            this.MissMenu.Image = ((System.Drawing.Image)(resources.GetObject("MissMenu.Image")));
            this.MissMenu.Location = new System.Drawing.Point(18, 55);
            this.MissMenu.Name = "MissMenu";
            this.MissMenu.ResizeTo = new System.Drawing.Size(90, 90);
            this.MissMenu.Size = new System.Drawing.Size(92, 81);
            this.MissMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissMenu.TabIndex = 1;
            this.MissMenu.TabStop = false;
            this.MissMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // PnlMap
            // 
            this.PnlMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlMap.BackgroundImage")));
            this.PnlMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlMap.Location = new System.Drawing.Point(207, 3);
            this.PnlMap.Name = "PnlMap";
            this.PnlMap.Size = new System.Drawing.Size(1210, 649);
            this.PnlMap.TabIndex = 1;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnSave);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButtons.Location = new System.Drawing.Point(3, 659);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(198, 53);
            this.PnlButtons.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(10, 9);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "GUARDAR";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(206, 656);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(1215, 59);
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
            // FormMapEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 721);
            this.Controls.Add(this.PnlLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMapEdition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Mapa";
            this.PnlLayout.ResumeLayout(false);
            this.PnlToolBox.ResumeLayout(false);
            this.TabControlToolBox.ResumeLayout(false);
            this.TabToolBoxTables.ResumeLayout(false);
            this.TabToolBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MissTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissMenu)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.cmenuStripTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReferenceTable MesaRect;
        private ReferenceTable MesaCuad;
        private System.Windows.Forms.TableLayoutPanel PnlLayout;
        private System.Windows.Forms.Panel PnlToolBox;
        private System.Windows.Forms.TabControl TabControlToolBox;
        private System.Windows.Forms.TabPage TabToolBoxTables;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PnlMap;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem fijarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private ReferenceObject WallHor;
        private ReferenceObject WallVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private ReferenceObject MissMenu;
        private ReferenceObject MissTV;
        private ReferenceObject MissCash;
        private ReferenceObject MissBar;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label1;
        private ReferenceTable MesaRed;
    }
}

