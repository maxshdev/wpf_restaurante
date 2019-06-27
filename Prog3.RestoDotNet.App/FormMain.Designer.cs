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
            this.btnMapEdit = new System.Windows.Forms.Button();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.PnlMapLoad = new System.Windows.Forms.Panel();
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
            this.PnlMapLoad.Location = new System.Drawing.Point(12, 41);
            this.PnlMapLoad.Name = "PnlMapLoad";
            this.PnlMapLoad.Size = new System.Drawing.Size(892, 515);
            this.PnlMapLoad.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 572);
            this.Controls.Add(this.PnlMapLoad);
            this.Controls.Add(this.btnMapLoad);
            this.Controls.Add(this.btnMapEdit);
            this.Name = "FormMain";
            this.Text = "Resto DotNet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMapEdit;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.Panel PnlMapLoad;
    }
}