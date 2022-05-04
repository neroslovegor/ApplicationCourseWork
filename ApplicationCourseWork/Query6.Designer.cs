
namespace ApplicationCourseWork
{
    partial class Query6
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
            this.dateTimePicker2Query6 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dataGridViewQuery6 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery6)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2Query6
            // 
            this.dateTimePicker2Query6.Location = new System.Drawing.Point(584, 57);
            this.dateTimePicker2Query6.Name = "dateTimePicker2Query6";
            this.dateTimePicker2Query6.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2Query6.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Получите данные о распределении оборудования на некоторую указанную дату";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(791, 12);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(226, 74);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dataGridViewQuery6
            // 
            this.dataGridViewQuery6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery6.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery6.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewQuery6.Name = "dataGridViewQuery6";
            this.dataGridViewQuery6.RowTemplate.Height = 25;
            this.dataGridViewQuery6.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery6.TabIndex = 14;
            // 
            // Query6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.dateTimePicker2Query6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewQuery6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1045, 669);
            this.MinimumSize = new System.Drawing.Size(1045, 669);
            this.Name = "Query6";
            this.Text = "Query6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2Query6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridView dataGridViewQuery6;
    }
}