namespace Prog3.RestoDotNet.App
{
    partial class FormTableStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxChair = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxReserved = new System.Windows.Forms.CheckBox();
            this.dTPickerReserved = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rTBoxNotes = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddMeals = new System.Windows.Forms.Button();
            this.btnDeletedMeal = new System.Windows.Forms.Button();
            this.btnChangeMeal = new System.Windows.Forms.Button();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTBoxNotes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dTPickerReserved);
            this.groupBox1.Controls.Add(this.cBoxReserved);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBoxChair);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBoxID);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de Mesa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(344, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(6, 36);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(214, 20);
            this.tBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(6, 75);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(214, 20);
            this.tBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sillas:";
            // 
            // tBoxChair
            // 
            this.tBoxChair.Location = new System.Drawing.Point(6, 114);
            this.tBoxChair.Name = "tBoxChair";
            this.tBoxChair.Size = new System.Drawing.Size(214, 20);
            this.tBoxChair.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reservado:";
            // 
            // cBoxReserved
            // 
            this.cBoxReserved.AutoSize = true;
            this.cBoxReserved.Location = new System.Drawing.Point(6, 154);
            this.cBoxReserved.Name = "cBoxReserved";
            this.cBoxReserved.Size = new System.Drawing.Size(60, 17);
            this.cBoxReserved.TabIndex = 7;
            this.cBoxReserved.Text = "Si / No";
            this.cBoxReserved.UseVisualStyleBackColor = true;
            // 
            // dTPickerReserved
            // 
            this.dTPickerReserved.Location = new System.Drawing.Point(73, 154);
            this.dTPickerReserved.Name = "dTPickerReserved";
            this.dTPickerReserved.Size = new System.Drawing.Size(200, 20);
            this.dTPickerReserved.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notas:";
            // 
            // rTBoxNotes
            // 
            this.rTBoxNotes.Location = new System.Drawing.Point(6, 201);
            this.rTBoxNotes.Name = "rTBoxNotes";
            this.rTBoxNotes.Size = new System.Drawing.Size(313, 87);
            this.rTBoxNotes.TabIndex = 10;
            this.rTBoxNotes.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChangeMeal);
            this.groupBox3.Controls.Add(this.btnDeletedMeal);
            this.groupBox3.Controls.Add(this.btnAddMeals);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comidas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddMeals
            // 
            this.btnAddMeals.Location = new System.Drawing.Point(6, 186);
            this.btnAddMeals.Name = "btnAddMeals";
            this.btnAddMeals.Size = new System.Drawing.Size(129, 23);
            this.btnAddMeals.TabIndex = 1;
            this.btnAddMeals.Text = "Agregar Pedido";
            this.btnAddMeals.UseVisualStyleBackColor = true;
            // 
            // btnDeletedMeal
            // 
            this.btnDeletedMeal.Location = new System.Drawing.Point(451, 187);
            this.btnDeletedMeal.Name = "btnDeletedMeal";
            this.btnDeletedMeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeletedMeal.TabIndex = 2;
            this.btnDeletedMeal.Text = "Borrar";
            this.btnDeletedMeal.UseVisualStyleBackColor = true;
            // 
            // btnChangeMeal
            // 
            this.btnChangeMeal.Location = new System.Drawing.Point(370, 187);
            this.btnChangeMeal.Name = "btnChangeMeal";
            this.btnChangeMeal.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMeal.TabIndex = 3;
            this.btnChangeMeal.Text = "Cambiar";
            this.btnChangeMeal.UseVisualStyleBackColor = true;
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.Location = new System.Drawing.Point(291, 536);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(248, 23);
            this.btnCloseTable.TabIndex = 3;
            this.btnCloseTable.Text = "CERRAR PEDIDO";
            this.btnCloseTable.UseVisualStyleBackColor = true;
            // 
            // FormTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 565);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTableStatus";
            this.Text = "FormTableStatus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rTBoxNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPickerReserved;
        private System.Windows.Forms.CheckBox cBoxReserved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxChair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddMeals;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChangeMeal;
        private System.Windows.Forms.Button btnDeletedMeal;
        private System.Windows.Forms.Button btnCloseTable;
    }
}