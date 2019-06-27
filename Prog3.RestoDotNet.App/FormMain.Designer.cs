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
            this.SuspendLayout();
            // 
            // btnMapEdit
            // 
            this.btnMapEdit.Location = new System.Drawing.Point(373, 174);
            this.btnMapEdit.Name = "btnMapEdit";
            this.btnMapEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMapEdit.TabIndex = 0;
            this.btnMapEdit.Text = "Editar Mapa";
            this.btnMapEdit.UseVisualStyleBackColor = true;
            this.btnMapEdit.Click += new System.EventHandler(this.BtnMapEdit_Click);
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.Location = new System.Drawing.Point(369, 218);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(84, 23);
            this.btnMapLoad.TabIndex = 1;
            this.btnMapLoad.Text = "Cargar Mapa";
            this.btnMapLoad.UseVisualStyleBackColor = true;
            this.btnMapLoad.Click += new System.EventHandler(this.BtnMapLoad_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMapLoad);
            this.Controls.Add(this.btnMapEdit);
            this.Name = "FormMain";
            this.Text = "Resto DotNet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMapEdit;
        private System.Windows.Forms.Button btnMapLoad;
    }
}