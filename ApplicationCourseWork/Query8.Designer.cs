﻿
namespace ApplicationCourseWork
{
    partial class Query8
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
            this.dataGridViewQuery8 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1Query8 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2Query8 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxQuery8 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery8
            // 
            this.dataGridViewQuery8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery8.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery8.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewQuery8.Name = "dataGridViewQuery8";
            this.dataGridViewQuery8.RowTemplate.Height = 25;
            this.dataGridViewQuery8.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery8.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(791, 12);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(226, 74);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сведения об участии указанной категории сотрудников в проектах за определенный пе" +
    "риод времени";
            // 
            // dateTimePicker1Query8
            // 
            this.dateTimePicker1Query8.Location = new System.Drawing.Point(346, 57);
            this.dateTimePicker1Query8.Name = "dateTimePicker1Query8";
            this.dateTimePicker1Query8.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1Query8.TabIndex = 11;
            // 
            // dateTimePicker2Query8
            // 
            this.dateTimePicker2Query8.Location = new System.Drawing.Point(584, 57);
            this.dateTimePicker2Query8.Name = "dateTimePicker2Query8";
            this.dateTimePicker2Query8.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2Query8.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "—";
            // 
            // comboBoxQuery8
            // 
            this.comboBoxQuery8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuery8.FormattingEnabled = true;
            this.comboBoxQuery8.Items.AddRange(new object[] {
            "constructor",
            "engineer",
            "technician",
            "laboratory_assist",
            "service_staff",
            "department_chief"});
            this.comboBoxQuery8.Location = new System.Drawing.Point(129, 57);
            this.comboBoxQuery8.Name = "comboBoxQuery8";
            this.comboBoxQuery8.Size = new System.Drawing.Size(195, 29);
            this.comboBoxQuery8.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Категория сотрудников";
            // 
            // Query8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxQuery8);
            this.Controls.Add(this.dateTimePicker1Query8);
            this.Controls.Add(this.dateTimePicker2Query8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewQuery8);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Query8";
            this.Text = "Query8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuery8;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Query8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Query8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxQuery8;
        private System.Windows.Forms.Label label3;
    }
}