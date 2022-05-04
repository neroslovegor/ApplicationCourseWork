
namespace ApplicationCourseWork
{
    partial class Query9
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
            this.dataGridViewQuery9 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInsertForm9 = new System.Windows.Forms.Panel();
            this.textBoxQuery9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery9
            // 
            this.dataGridViewQuery9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery9.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery9.Name = "dataGridViewQuery9";
            this.dataGridViewQuery9.RowTemplate.Height = 25;
            this.dataGridViewQuery9.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery9.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Общая сумма работ";
            // 
            // panelInsertForm9
            // 
            this.panelInsertForm9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsertForm9.BackColor = System.Drawing.Color.DimGray;
            this.panelInsertForm9.Location = new System.Drawing.Point(161, 84);
            this.panelInsertForm9.Name = "panelInsertForm9";
            this.panelInsertForm9.Size = new System.Drawing.Size(224, 1);
            this.panelInsertForm9.TabIndex = 29;
            // 
            // textBoxQuery9
            // 
            this.textBoxQuery9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery9.BackColor = System.Drawing.Color.Silver;
            this.textBoxQuery9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery9.Location = new System.Drawing.Point(161, 63);
            this.textBoxQuery9.Name = "textBoxQuery9";
            this.textBoxQuery9.Size = new System.Drawing.Size(224, 22);
            this.textBoxQuery9.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Получите перечень и стоимость работ, выполненных субподрядными организациями";
            // 
            // Query9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelInsertForm9);
            this.Controls.Add(this.textBoxQuery9);
            this.Controls.Add(this.dataGridViewQuery9);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Query9";
            this.Text = "Query9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuery9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelInsertForm9;
        private System.Windows.Forms.TextBox textBoxQuery9;
        private System.Windows.Forms.Label label1;
    }
}