
namespace ApplicationCourseWork
{
    partial class Query10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInsertForm9 = new System.Windows.Forms.Panel();
            this.textBoxQuery10 = new System.Windows.Forms.TextBox();
            this.dataGridViewQuery10 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Получите перечень и стоимость работ, выполненных субподрядными организациями";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID проекта";
            // 
            // panelInsertForm9
            // 
            this.panelInsertForm9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsertForm9.BackColor = System.Drawing.Color.DimGray;
            this.panelInsertForm9.Location = new System.Drawing.Point(560, 85);
            this.panelInsertForm9.Name = "panelInsertForm9";
            this.panelInsertForm9.Size = new System.Drawing.Size(224, 1);
            this.panelInsertForm9.TabIndex = 34;
            // 
            // textBoxQuery10
            // 
            this.textBoxQuery10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery10.BackColor = System.Drawing.Color.Silver;
            this.textBoxQuery10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery10.Location = new System.Drawing.Point(560, 64);
            this.textBoxQuery10.Name = "textBoxQuery10";
            this.textBoxQuery10.Size = new System.Drawing.Size(224, 22);
            this.textBoxQuery10.TabIndex = 33;
            // 
            // dataGridViewQuery10
            // 
            this.dataGridViewQuery10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery10.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery10.Name = "dataGridViewQuery10";
            this.dataGridViewQuery10.RowTemplate.Height = 25;
            this.dataGridViewQuery10.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery10.TabIndex = 32;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(791, 12);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(226, 74);
            this.buttonOK.TabIndex = 37;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Query10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelInsertForm9);
            this.Controls.Add(this.textBoxQuery10);
            this.Controls.Add(this.dataGridViewQuery10);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Query10";
            this.Text = "Query10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelInsertForm9;
        private System.Windows.Forms.TextBox textBoxQuery10;
        private System.Windows.Forms.DataGridView dataGridViewQuery10;
        private System.Windows.Forms.Button buttonOK;
    }
}