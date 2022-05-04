
namespace ApplicationCourseWork
{
    partial class Query1
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInsertForm9 = new System.Windows.Forms.Panel();
            this.textBoxQuery1 = new System.Windows.Forms.TextBox();
            this.dataGridViewQuery1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(791, 12);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(226, 74);
            this.buttonOK.TabIndex = 61;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перечень сотрудников, относящихся к указанному отделу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID отдела";
            // 
            // panelInsertForm9
            // 
            this.panelInsertForm9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsertForm9.BackColor = System.Drawing.Color.DimGray;
            this.panelInsertForm9.Location = new System.Drawing.Point(560, 85);
            this.panelInsertForm9.Name = "panelInsertForm9";
            this.panelInsertForm9.Size = new System.Drawing.Size(224, 1);
            this.panelInsertForm9.TabIndex = 58;
            // 
            // textBoxQuery1
            // 
            this.textBoxQuery1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery1.BackColor = System.Drawing.Color.Silver;
            this.textBoxQuery1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery1.Location = new System.Drawing.Point(560, 64);
            this.textBoxQuery1.Name = "textBoxQuery1";
            this.textBoxQuery1.Size = new System.Drawing.Size(224, 22);
            this.textBoxQuery1.TabIndex = 57;
            // 
            // dataGridViewQuery1
            // 
            this.dataGridViewQuery1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery1.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery1.Name = "dataGridViewQuery1";
            this.dataGridViewQuery1.RowTemplate.Height = 25;
            this.dataGridViewQuery1.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery1.TabIndex = 56;
            // 
            // Query1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelInsertForm9);
            this.Controls.Add(this.textBoxQuery1);
            this.Controls.Add(this.dataGridViewQuery1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Query1";
            this.Text = "Query1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelInsertForm9;
        private System.Windows.Forms.TextBox textBoxQuery1;
        private System.Windows.Forms.DataGridView dataGridViewQuery1;
    }
}