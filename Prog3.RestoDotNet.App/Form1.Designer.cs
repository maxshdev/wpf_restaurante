namespace wf_restaurante
{
    partial class Form1
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mesaRed = new System.Windows.Forms.PictureBox();
            this.mesaRec = new System.Windows.Forms.PictureBox();
            this.btn_addTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaRec)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer.Panel1.Controls.Add(this.groupBoxTools);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.button1);
            this.splitContainer.Panel2.Controls.Add(this.Map);
            this.splitContainer.Size = new System.Drawing.Size(784, 451);
            this.splitContainer.SplitterDistance = 166;
            this.splitContainer.TabIndex = 0;
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.pictureBox3);
            this.groupBoxTools.Controls.Add(this.mesaRed);
            this.groupBoxTools.Controls.Add(this.mesaRec);
            this.groupBoxTools.Controls.Add(this.btn_addTable);
            this.groupBoxTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTools.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(162, 442);
            this.groupBoxTools.TabIndex = 0;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Herramientas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::wf_restaurante.Properties.Resources.woodfloor;
            this.pictureBox3.Location = new System.Drawing.Point(28, 276);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // mesaRed
            // 
            this.mesaRed.Image = global::wf_restaurante.Properties.Resources.woodfloor;
            this.mesaRed.Location = new System.Drawing.Point(28, 197);
            this.mesaRed.Name = "mesaRed";
            this.mesaRed.Size = new System.Drawing.Size(53, 50);
            this.mesaRed.TabIndex = 1;
            this.mesaRed.TabStop = false;
            this.mesaRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.mesaRed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // mesaRec
            // 
            this.mesaRec.Image = global::wf_restaurante.Properties.Resources.woodfloor;
            this.mesaRec.Location = new System.Drawing.Point(28, 114);
            this.mesaRec.Name = "mesaRec";
            this.mesaRec.Size = new System.Drawing.Size(100, 50);
            this.mesaRec.TabIndex = 1;
            this.mesaRec.TabStop = false;
            this.mesaRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.mesaRec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // btn_addTable
            // 
            this.btn_addTable.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_addTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTable.Location = new System.Drawing.Point(8, 42);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(148, 27);
            this.btn_addTable.TabIndex = 0;
            this.btn_addTable.Text = "Mesa";
            this.btn_addTable.UseVisualStyleBackColor = false;
            this.btn_addTable.Click += new System.EventHandler(this.Btn_addTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "mesa_1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.Map.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Map.AutoSize = true;
            this.Map.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map.Location = new System.Drawing.Point(249, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(96, 17);
            this.Map.TabIndex = 0;
            this.Map.Text = "---PLANO---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label Map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button btn_addTable;
        private System.Windows.Forms.PictureBox mesaRec;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox mesaRed;
    }
}

