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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.CmbComidas = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.mealDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDtoBindingSource)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(433, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de Mesa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
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
            this.cBoxState.Location = new System.Drawing.Point(214, 92);
            this.cBoxState.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(192, 24);
            this.cBoxState.TabIndex = 13;
            // 
            // tBoxClient
            // 
            this.tBoxClient.Location = new System.Drawing.Point(7, 139);
            this.tBoxClient.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxClient.Name = "tBoxClient";
            this.tBoxClient.Size = new System.Drawing.Size(399, 22);
            this.tBoxClient.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mesero:";
            // 
            // rTBoxNotes
            // 
            this.rTBoxNotes.Location = new System.Drawing.Point(8, 247);
            this.rTBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rTBoxNotes.Name = "rTBoxNotes";
            this.rTBoxNotes.Size = new System.Drawing.Size(416, 106);
            this.rTBoxNotes.TabIndex = 10;
            this.rTBoxNotes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notas:";
            // 
            // dTPickerReserved
            // 
            this.dTPickerReserved.Location = new System.Drawing.Point(141, 186);
            this.dTPickerReserved.Margin = new System.Windows.Forms.Padding(4);
            this.dTPickerReserved.Name = "dTPickerReserved";
            this.dTPickerReserved.Size = new System.Drawing.Size(265, 22);
            this.dTPickerReserved.TabIndex = 8;
            // 
            // cBoxReserved
            // 
            this.cBoxReserved.AutoSize = true;
            this.cBoxReserved.Location = new System.Drawing.Point(8, 190);
            this.cBoxReserved.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxReserved.Name = "cBoxReserved";
            this.cBoxReserved.Size = new System.Drawing.Size(72, 21);
            this.cBoxReserved.TabIndex = 7;
            this.cBoxReserved.Text = "Si / No";
            this.cBoxReserved.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reservado:";
            // 
            // tBoxChair
            // 
            this.tBoxChair.Enabled = false;
            this.tBoxChair.Location = new System.Drawing.Point(214, 44);
            this.tBoxChair.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxChair.Name = "tBoxChair";
            this.tBoxChair.Size = new System.Drawing.Size(83, 22);
            this.tBoxChair.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sillas:";
            // 
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(8, 92);
            this.tBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(184, 22);
            this.tBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tBoxID
            // 
            this.tBoxID.Enabled = false;
            this.tBoxID.Location = new System.Drawing.Point(8, 44);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(83, 22);
            this.tBoxID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBoxImageTable);
            this.groupBox2.Location = new System.Drawing.Point(459, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(268, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // pBoxImageTable
            // 
            this.pBoxImageTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pBoxImageTable.Location = new System.Drawing.Point(9, 25);
            this.pBoxImageTable.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxImageTable.Name = "pBoxImageTable";
            this.pBoxImageTable.Size = new System.Drawing.Size(251, 175);
            this.pBoxImageTable.TabIndex = 0;
            this.pBoxImageTable.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAgregar);
            this.groupBox3.Controls.Add(this.btnDeletedMeal);
            this.groupBox3.Controls.Add(this.CmbComidas);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(17, 386);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(709, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comidas:";
            // 
            // btnDeletedMeal
            // 
            this.btnDeletedMeal.Location = new System.Drawing.Point(601, 230);
            this.btnDeletedMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletedMeal.Name = "btnDeletedMeal";
            this.btnDeletedMeal.Size = new System.Drawing.Size(100, 28);
            this.btnDeletedMeal.TabIndex = 2;
            this.btnDeletedMeal.Text = "Borrar";
            this.btnDeletedMeal.UseVisualStyleBackColor = true;
            this.btnDeletedMeal.Click += new System.EventHandler(this.BtnDeletedMeal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mealDtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(693, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseTable.Location = new System.Drawing.Point(388, 660);
            this.btnCloseTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(331, 33);
            this.btnCloseTable.TabIndex = 3;
            this.btnCloseTable.Text = "CERRAR PEDIDO";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTable.Location = new System.Drawing.Point(17, 660);
            this.btnSaveTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(259, 33);
            this.btnSaveTable.TabIndex = 4;
            this.btnSaveTable.Text = "GUARDAR CAMBIOS";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.BtnSaveTable_Click);
            // 
            // CmbComidas
            // 
            this.CmbComidas.FormattingEnabled = true;
            this.CmbComidas.Items.AddRange(new object[] {
            "Libre",
            "Ocupado",
            "Reservado"});
            this.CmbComidas.Location = new System.Drawing.Point(8, 230);
            this.CmbComidas.Margin = new System.Windows.Forms.Padding(4);
            this.CmbComidas.Name = "CmbComidas";
            this.CmbComidas.Size = new System.Drawing.Size(192, 24);
            this.CmbComidas.TabIndex = 13;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(493, 230);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 28);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // mealDtoBindingSource
            // 
            this.mealDtoBindingSource.DataSource = typeof(Prog3.RestoDotNet.Model.Dtos.MealDto);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // FormTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 708);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTableStatus";
            this.Text = "Seguimiento de Mesa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDtoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletedMeal;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.TextBox tBoxClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mealDtoBindingSource;
    }
}