
namespace ApplicationCourseWork
{
    partial class Query2
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
            this.dataGridViewQuery2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery2
            // 
            this.dataGridViewQuery2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery2.Location = new System.Drawing.Point(1, 45);
            this.dataGridViewQuery2.Name = "dataGridViewQuery2";
            this.dataGridViewQuery2.RowTemplate.Height = 25;
            this.dataGridViewQuery2.Size = new System.Drawing.Size(1028, 586);
            this.dataGridViewQuery2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перечень руководителей отделов";
            // 
            // Query2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewQuery2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1045, 669);
            this.MinimumSize = new System.Drawing.Size(1045, 669);
            this.Name = "Query2";
            this.Text = "Query2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuery2;
        private System.Windows.Forms.Label label1;
    }
}