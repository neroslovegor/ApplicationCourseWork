
namespace ApplicationCourseWork
{
    partial class Query3
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
            this.dataGridViewQuery3 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2Query3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1Query3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery3
            // 
            this.dataGridViewQuery3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery3.Location = new System.Drawing.Point(1, 92);
            this.dataGridViewQuery3.Name = "dataGridViewQuery3";
            this.dataGridViewQuery3.RowTemplate.Height = 25;
            this.dataGridViewQuery3.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery3.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(791, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(226, 74);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перечень проектов, выполняемых в указанный период времени";
            // 
            // dateTimePicker2Query3
            // 
            this.dateTimePicker2Query3.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePicker2Query3.Location = new System.Drawing.Point(585, 57);
            this.dateTimePicker2Query3.Name = "dateTimePicker2Query3";
            this.dateTimePicker2Query3.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2Query3.TabIndex = 3;
            // 
            // dateTimePicker1Query3
            // 
            this.dateTimePicker1Query3.Location = new System.Drawing.Point(347, 57);
            this.dateTimePicker1Query3.Name = "dateTimePicker1Query3";
            this.dateTimePicker1Query3.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1Query3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "—";
            // 
            // Query3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1Query3);
            this.Controls.Add(this.dateTimePicker2Query3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewQuery3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1045, 669);
            this.MinimumSize = new System.Drawing.Size(1045, 669);
            this.Name = "Query3";
            this.Text = "Query3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuery3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Query3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Query3;
        private System.Windows.Forms.Label label2;
    }
}