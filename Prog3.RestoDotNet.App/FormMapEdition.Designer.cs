﻿namespace Prog3.RestoDotNet.App
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WallHor = new System.Windows.Forms.PictureBox();
            this.WallVer = new System.Windows.Forms.PictureBox();
            this.WallCol = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.cmenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblEstado = new System.Windows.Forms.Label();
            this.MesaRedo = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.MesaCuad = new Prog3.RestoDotNet.App.Custom_Items.ReferenceTable();
            this.PnlLayout.SuspendLayout();
            this.PnlToolBox.SuspendLayout();
            this.TabControlToolBox.SuspendLayout();
            this.TabToolBoxTables.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallCol)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.cmenuStripTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesaRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).BeginInit();
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
            this.PnlLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlLayout.Name = "PnlLayout";
            this.PnlLayout.RowCount = 2;
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.84862F));
            this.PnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.151382F));
            this.PnlLayout.Size = new System.Drawing.Size(1371, 699);
            this.PnlLayout.TabIndex = 1;
            // 
            // PnlToolBox
            // 
            this.PnlToolBox.Controls.Add(this.TabControlToolBox);
            this.PnlToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlToolBox.Location = new System.Drawing.Point(4, 4);
            this.PnlToolBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlToolBox.Name = "PnlToolBox";
            this.PnlToolBox.Size = new System.Drawing.Size(189, 634);
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
            this.TabControlToolBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControlToolBox.Name = "TabControlToolBox";
            this.TabControlToolBox.SelectedIndex = 0;
            this.TabControlToolBox.Size = new System.Drawing.Size(189, 634);
            this.TabControlToolBox.TabIndex = 2;
            // 
            // TabToolBoxTables
            // 
            this.TabToolBoxTables.Controls.Add(this.label3);
            this.TabToolBoxTables.Controls.Add(this.label2);
            this.TabToolBoxTables.Controls.Add(this.MesaRedo);
            this.TabToolBoxTables.Controls.Add(this.MesaCuad);
            this.TabToolBoxTables.Location = new System.Drawing.Point(4, 25);
            this.TabToolBoxTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabToolBoxTables.Name = "TabToolBoxTables";
            this.TabToolBoxTables.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabToolBoxTables.Size = new System.Drawing.Size(181, 605);
            this.TabToolBoxTables.TabIndex = 0;
            this.TabToolBoxTables.Text = "Mesas";
            this.TabToolBoxTables.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "x4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WallHor);
            this.tabPage2.Controls.Add(this.WallVer);
            this.tabPage2.Controls.Add(this.WallCol);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(181, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paredes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WallHor
            // 
            this.WallHor.Image = ((System.Drawing.Image)(resources.GetObject("WallHor.Image")));
            this.WallHor.Location = new System.Drawing.Point(53, 324);
            this.WallHor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallHor.Name = "WallHor";
            this.WallHor.Size = new System.Drawing.Size(68, 62);
            this.WallHor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallHor.TabIndex = 5;
            this.WallHor.TabStop = false;
            this.WallHor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // WallVer
            // 
            this.WallVer.Image = ((System.Drawing.Image)(resources.GetObject("WallVer.Image")));
            this.WallVer.Location = new System.Drawing.Point(53, 175);
            this.WallVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallVer.Name = "WallVer";
            this.WallVer.Size = new System.Drawing.Size(68, 62);
            this.WallVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallVer.TabIndex = 4;
            this.WallVer.TabStop = false;
            this.WallVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // WallCol
            // 
            this.WallCol.Image = ((System.Drawing.Image)(resources.GetObject("WallCol.Image")));
            this.WallCol.Location = new System.Drawing.Point(53, 49);
            this.WallCol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallCol.Name = "WallCol";
            this.WallCol.Size = new System.Drawing.Size(68, 62);
            this.WallCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WallCol.TabIndex = 3;
            this.WallCol.TabStop = false;
            this.WallCol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vertical";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Columna";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.MissPool);
            this.tabPage1.Controls.Add(this.MissBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(181, 605);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Deco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 433);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 326);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 220);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissPool
            // 
            this.MissPool.Image = ((System.Drawing.Image)(resources.GetObject("MissPool.Image")));
            this.MissPool.Location = new System.Drawing.Point(24, 116);
            this.MissPool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MissPool.Name = "MissPool";
            this.MissPool.Size = new System.Drawing.Size(123, 100);
            this.MissPool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MissPool.TabIndex = 3;
            this.MissPool.TabStop = false;
            this.MissPool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MissBar
            // 
            this.MissBar.Image = ((System.Drawing.Image)(resources.GetObject("MissBar.Image")));
            this.MissBar.Location = new System.Drawing.Point(24, 10);
            this.MissBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MissBar.Name = "MissBar";
            this.MissBar.Size = new System.Drawing.Size(123, 100);
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
            this.PnlMap.Location = new System.Drawing.Point(201, 4);
            this.PnlMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlMap.Name = "PnlMap";
            this.PnlMap.Size = new System.Drawing.Size(1166, 634);
            this.PnlMap.TabIndex = 1;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnSave);
            this.PnlButtons.Controls.Add(this.BtnCancel);
            this.PnlButtons.Location = new System.Drawing.Point(4, 646);
            this.PnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(165, 49);
            this.PnlButtons.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(89, 11);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(72, 28);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(8, 11);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(77, 28);
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
            this.cmenuStripTable.Size = new System.Drawing.Size(133, 52);
            // 
            // fijarToolStripMenuItem
            // 
            this.fijarToolStripMenuItem.Name = "fijarToolStripMenuItem";
            this.fijarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.fijarToolStripMenuItem.Text = "Fijar";
            this.fijarToolStripMenuItem.Click += new System.EventHandler(this.FijarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(200, 642);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(1168, 57);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Agregue mesas presionando sobre ellas!";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MesaRedo
            // 
            this.MesaRedo.Image = ((System.Drawing.Image)(resources.GetObject("MesaRedo.Image")));
            this.MesaRedo.Location = new System.Drawing.Point(48, 318);
            this.MesaRedo.Margin = new System.Windows.Forms.Padding(4);
            this.MesaRedo.Name = "MesaRedo";
            this.MesaRedo.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.CIRCLE;
            this.MesaRedo.Size = new System.Drawing.Size(80, 74);
            this.MesaRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaRedo.TabIndex = 1;
            this.MesaRedo.TabStop = false;
            this.MesaRedo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // MesaCuad
            // 
            this.MesaCuad.Image = ((System.Drawing.Image)(resources.GetObject("MesaCuad.Image")));
            this.MesaCuad.Location = new System.Drawing.Point(48, 198);
            this.MesaCuad.Margin = new System.Windows.Forms.Padding(4);
            this.MesaCuad.Name = "MesaCuad";
            this.MesaCuad.Shape = Prog3.RestoDotNet.Model.Enums.TableShapeEnum.SQUARE;
            this.MesaCuad.Size = new System.Drawing.Size(80, 74);
            this.MesaCuad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesaCuad.TabIndex = 1;
            this.MesaCuad.TabStop = false;
            this.MesaCuad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            // 
            // FormMapEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 699);
            this.Controls.Add(this.PnlLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMapEdition";
            this.Text = "Editar Mapa";
            this.PnlLayout.ResumeLayout(false);
            this.PnlToolBox.ResumeLayout(false);
            this.TabControlToolBox.ResumeLayout(false);
            this.TabToolBoxTables.ResumeLayout(false);
            this.TabToolBoxTables.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallCol)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissBar)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.cmenuStripTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MesaRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaCuad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.PictureBox MissBar;
        private System.Windows.Forms.PictureBox MissPool;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblEstado;
    }
}

