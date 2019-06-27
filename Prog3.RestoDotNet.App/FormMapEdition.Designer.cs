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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PnlMap = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.cmenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDraw = new System.Windows.Forms.Button();
            this.PnlLayout.SuspendLayout();
            this.PnlToolBox.SuspendLayout();
            this.TabControlToolBox.SuspendLayout();
            this.TabToolBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRec)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.cmenuStripTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLayout
            // 
            this.PnlLayout.ColumnCount = 2;
            this.PnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72242F));
            this.PnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.27758F));
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
            this.PnlToolBox.Size = new System.Drawing.Size(124, 515);
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
            this.TabControlToolBox.Size = new System.Drawing.Size(124, 515);
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
            this.TabToolBoxTables.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabToolBoxTables.Size = new System.Drawing.Size(116, 489);
            this.TabToolBoxTables.TabIndex = 0;
            this.TabToolBoxTables.Text = "Mesas";
            this.TabToolBoxTables.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red (4)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuad (2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rect (6)";
            // 
            // MesaRedo
            // 
            this.MesaRedo.Image = ((System.Drawing.Image)(resources.GetObject("MesaRedo.Image")));
            this.MesaRedo.Location = new System.Drawing.Point(36, 332);
            this.MesaRedo.Name = "MesaRedo";
            this.MesaRedo.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.CIRCLE;
            this.MesaRedo.Size = new System.Drawing.Size(53, 50);
            this.MesaRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRedo.TabIndex = 1;
            this.MesaRedo.TabStop = false;
            this.MesaRedo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MesaCuad
            // 
            this.MesaCuad.Image = ((System.Drawing.Image)(resources.GetObject("MesaCuad.Image")));
            this.MesaCuad.Location = new System.Drawing.Point(36, 210);
            this.MesaCuad.Name = "MesaCuad";
            this.MesaCuad.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.SQUARE;
            this.MesaCuad.Size = new System.Drawing.Size(53, 50);
            this.MesaCuad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaCuad.TabIndex = 1;
            this.MesaCuad.TabStop = false;
            this.MesaCuad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MesaRec
            // 
            this.MesaRec.Image = ((System.Drawing.Image)(resources.GetObject("MesaRec.Image")));
            this.MesaRec.Location = new System.Drawing.Point(36, 61);
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
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(116, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paredes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(29, 279);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(29, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vertical";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Columna";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(116, 489);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Deco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PnlMap
            // 
            this.PnlMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMap.Location = new System.Drawing.Point(133, 3);
            this.PnlMap.Name = "PnlMap";
            this.PnlMap.Size = new System.Drawing.Size(892, 515);
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
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(133, 524);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // FormMapEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.PnlLayout);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDraw;
    }
}

