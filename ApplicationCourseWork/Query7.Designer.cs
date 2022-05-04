
namespace ApplicationCourseWork
{
    partial class Query7
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
            this.dataGridViewQuery7 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuery7 = new System.Windows.Forms.TextBox();
            this.panelInsertForm8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery7
            // 
            this.dataGridViewQuery7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery7.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewQuery7.Name = "dataGridViewQuery7";
            this.dataGridViewQuery7.Size = new System.Drawing.Size(1028, 539);
            this.dataGridViewQuery7.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(479, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сведения об использовании оборудования указанным проектом";
            // 
            // textBoxQuery7
            // 
            this.textBoxQuery7.BackColor = System.Drawing.Color.Silver;
            this.textBoxQuery7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery7.Location = new System.Drawing.Point(585, 64);
            this.textBoxQuery7.Name = "textBoxQuery7";
            this.textBoxQuery7.Size = new System.Drawing.Size(200, 22);
            this.textBoxQuery7.TabIndex = 3;
            // 
            // panelInsertForm8
            // 
            this.panelInsertForm8.BackColor = System.Drawing.Color.DimGray;
            this.panelInsertForm8.Location = new System.Drawing.Point(585, 85);
            this.panelInsertForm8.Name = "panelInsertForm8";
            this.panelInsertForm8.Size = new System.Drawing.Size(200, 1);
            this.panelInsertForm8.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID проекта";
            // 
            // Query7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelInsertForm8);
            this.Controls.Add(this.textBoxQuery7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewQuery7);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Query7";
            this.Text = "Query7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuery7;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuery7;
        public System.Windows.Forms.Panel panelInsertForm8;
        private System.Windows.Forms.Label label2;
    }
}