﻿namespace Prog3.RestoDotNet.App
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
            this.btnMapEdit = new System.Windows.Forms.Button();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.PnlMapLoad = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMapEdit
            // 
            this.btnMapEdit.Location = new System.Drawing.Point(136, 15);
            this.btnMapEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMapEdit.Name = "btnMapEdit";
            this.btnMapEdit.Size = new System.Drawing.Size(100, 28);
            this.btnMapEdit.TabIndex = 0;
            this.btnMapEdit.Text = "Editar Mapa";
            this.btnMapEdit.UseVisualStyleBackColor = true;
            this.btnMapEdit.Click += new System.EventHandler(this.BtnMapEdit_Click);
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.Location = new System.Drawing.Point(16, 15);
            this.btnMapLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(112, 28);
            this.btnMapLoad.TabIndex = 1;
            this.btnMapLoad.Text = "Cargar Mapa";
            this.btnMapLoad.UseVisualStyleBackColor = true;
            this.btnMapLoad.Click += new System.EventHandler(this.BtnMapLoad_Click);
            // 
            // PnlMapLoad
            // 
            this.PnlMapLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlMapLoad.Location = new System.Drawing.Point(16, 50);
            this.PnlMapLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlMapLoad.Name = "PnlMapLoad";
            this.PnlMapLoad.Size = new System.Drawing.Size(1189, 634);
            this.PnlMapLoad.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 704);
            this.Controls.Add(this.PnlMapLoad);
            this.Controls.Add(this.btnMapLoad);
            this.Controls.Add(this.btnMapEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Resto DotNet";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMapEdit;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.Panel PnlMapLoad;
    }
}