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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableStatus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.tBoxClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rTBoxNotes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPickerReserved = new System.Windows.Forms.DateTimePicker();
            this.cBoxReserved = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxChair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBoxImageTable = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeletedMeal = new System.Windows.Forms.Button();
            this.btnAddMeals = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBoxState);
            this.groupBox1.Controls.Add(this.tBoxClient);
            this.groupBox1.Controls.Add(this.label6);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // cBoxState
            // 
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Items.AddRange(new object[] {
            "Libre",
            "Ocupado",
            "Reservado"});
            this.cBoxState.Location = new System.Drawing.Point(103, 114);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(145, 21);
            this.cBoxState.TabIndex = 13;
            // 
            // tBoxClient
            // 
            this.tBoxClient.Location = new System.Drawing.Point(103, 36);
            this.tBoxClient.Name = "tBoxClient";
            this.tBoxClient.Size = new System.Drawing.Size(145, 20);
            this.tBoxClient.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mesero:";
            // 
            // rTBoxNotes
            // 
            this.rTBoxNotes.Location = new System.Drawing.Point(6, 201);
            this.rTBoxNotes.Name = "rTBoxNotes";
            this.rTBoxNotes.Size = new System.Drawing.Size(313, 87);
            this.rTBoxNotes.TabIndex = 10;
            this.rTBoxNotes.Text = "";
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
            // dTPickerReserved
            // 
            this.dTPickerReserved.Location = new System.Drawing.Point(73, 154);
            this.dTPickerReserved.Name = "dTPickerReserved";
            this.dTPickerReserved.Size = new System.Drawing.Size(200, 20);
            this.dTPickerReserved.TabIndex = 8;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reservado:";
            // 
            // tBoxChair
            // 
            this.tBoxChair.Location = new System.Drawing.Point(6, 114);
            this.tBoxChair.Name = "tBoxChair";
            this.tBoxChair.Size = new System.Drawing.Size(63, 20);
            this.tBoxChair.TabIndex = 5;
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
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(6, 75);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(242, 20);
            this.tBoxDescription.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tBoxID
            // 
            this.tBoxID.Enabled = false;
            this.tBoxID.Location = new System.Drawing.Point(6, 36);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(63, 20);
            this.tBoxID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBoxImageTable);
            this.groupBox2.Location = new System.Drawing.Point(344, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // pBoxImageTable
            // 
            this.pBoxImageTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pBoxImageTable.Location = new System.Drawing.Point(7, 20);
            this.pBoxImageTable.Name = "pBoxImageTable";
            this.pBoxImageTable.Size = new System.Drawing.Size(188, 142);
            this.pBoxImageTable.TabIndex = 0;
            this.pBoxImageTable.TabStop = false;
            // 
            // groupBox3
            // 
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
            // btnDeletedMeal
            // 
            this.btnDeletedMeal.Location = new System.Drawing.Point(451, 187);
            this.btnDeletedMeal.Name = "btnDeletedMeal";
            this.btnDeletedMeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeletedMeal.TabIndex = 2;
            this.btnDeletedMeal.Text = "Borrar";
            this.btnDeletedMeal.UseVisualStyleBackColor = true;
            this.btnDeletedMeal.Click += new System.EventHandler(this.BtnDeletedMeal_Click);
            // 
            // btnAddMeals
            // 
            this.btnAddMeals.Location = new System.Drawing.Point(6, 186);
            this.btnAddMeals.Name = "btnAddMeals";
            this.btnAddMeals.Size = new System.Drawing.Size(129, 23);
            this.btnAddMeals.TabIndex = 1;
            this.btnAddMeals.Text = "Agregar Pedido";
            this.btnAddMeals.UseVisualStyleBackColor = true;
            this.btnAddMeals.Click += new System.EventHandler(this.BtnAddMeals_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseTable.Location = new System.Drawing.Point(291, 536);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(248, 27);
            this.btnCloseTable.TabIndex = 3;
            this.btnCloseTable.Text = "CERRAR PEDIDO";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTable.Location = new System.Drawing.Point(13, 536);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(194, 27);
            this.btnSaveTable.TabIndex = 4;
            this.btnSaveTable.Text = "GUARDAR CAMBIOS";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            // 
            // FormTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 575);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTableStatus";
            this.Text = "Seguimiento de Mesa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).EndInit();
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
        private System.Windows.Forms.PictureBox pBoxImageTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddMeals;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletedMeal;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.TextBox tBoxClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTable;
    }
}