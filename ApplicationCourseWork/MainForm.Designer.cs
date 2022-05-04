
namespace ApplicationCourseWork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMainForm = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxMainForm = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonQuery = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemQuery2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuery10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery12 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery14 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuery6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuery1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonChangeUser = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMainForm
            // 
            this.dataGridViewMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMainForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMainForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainForm.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMainForm.Name = "dataGridViewMainForm";
            this.dataGridViewMainForm.ReadOnly = true;
            this.dataGridViewMainForm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewMainForm.RowTemplate.Height = 25;
            this.dataGridViewMainForm.Size = new System.Drawing.Size(1079, 514);
            this.dataGridViewMainForm.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxMainForm,
            this.toolStripButtonInsert,
            this.toolStripButtonUpdate,
            this.toolStripButtonDelete,
            this.toolStripDropDownButtonQuery,
            this.toolStripButtonChangeUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 29);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxMainForm
            // 
            this.toolStripComboBoxMainForm.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxMainForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripComboBoxMainForm.Items.AddRange(new object[] {
            "constructor",
            "contract",
            "customer",
            "department",
            "department_chief",
            "employee",
            "engineer",
            "equioment",
            "_group",
            "laboratory_assist",
            "manager",
            "position",
            "project",
            "service_staff",
            "subcontractor",
            "technician"});
            this.toolStripComboBoxMainForm.Name = "toolStripComboBoxMainForm";
            this.toolStripComboBoxMainForm.Size = new System.Drawing.Size(200, 29);
            this.toolStripComboBoxMainForm.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxMainForm_SelectedIndexChanged);
            // 
            // toolStripButtonInsert
            // 
            this.toolStripButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsert.Image")));
            this.toolStripButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsert.Name = "toolStripButtonInsert";
            this.toolStripButtonInsert.Size = new System.Drawing.Size(53, 26);
            this.toolStripButtonInsert.Text = "Insert";
            this.toolStripButtonInsert.Click += new System.EventHandler(this.toolStripButtonInsert_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(64, 26);
            this.toolStripButtonUpdate.Text = "Update";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(58, 26);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripDropDownButtonQuery
            // 
            this.toolStripDropDownButtonQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemQuery2,
            this.ToolStripMenuItemQuery3,
            this.ToolStripMenuItemQuery4,
            this.ToolStripMenuItemQuery5,
            this.ToolStripMenuItemQuery7,
            this.ToolStripMenuItemQuery8,
            this.ToolStripMenuItemQuery9,
            this.toolStripMenuItemQuery10,
            this.ToolStripMenuItemQuery11,
            this.ToolStripMenuItemQuery12,
            this.ToolStripMenuItemQuery14,
            this.ToolStripMenuItemQuery6,
            this.toolStripMenuItemQuery1});
            this.toolStripDropDownButtonQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonQuery.Image")));
            this.toolStripDropDownButtonQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonQuery.Name = "toolStripDropDownButtonQuery";
            this.toolStripDropDownButtonQuery.Size = new System.Drawing.Size(66, 26);
            this.toolStripDropDownButtonQuery.Text = "Query";
            // 
            // ToolStripMenuItemQuery2
            // 
            this.ToolStripMenuItemQuery2.Name = "ToolStripMenuItemQuery2";
            this.ToolStripMenuItemQuery2.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery2.Text = "2. Перечень руководителей отделов";
            this.ToolStripMenuItemQuery2.Click += new System.EventHandler(this.ToolStripMenuItemQuery2_Click);
            // 
            // ToolStripMenuItemQuery3
            // 
            this.ToolStripMenuItemQuery3.Name = "ToolStripMenuItemQuery3";
            this.ToolStripMenuItemQuery3.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery3.Text = "3. Перечень проектов, выполняемых в указанный период времени";
            this.ToolStripMenuItemQuery3.Click += new System.EventHandler(this.ToolStripMenuItemQuery3_Click);
            // 
            // ToolStripMenuItemQuery4
            // 
            this.ToolStripMenuItemQuery4.Name = "ToolStripMenuItemQuery4";
            this.ToolStripMenuItemQuery4.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery4.Text = "4. Проекты, которые выполняются (выполнялись) в рамках указанного договора";
            this.ToolStripMenuItemQuery4.Click += new System.EventHandler(this.ToolStripMenuItemQuery4_Click);
            // 
            // ToolStripMenuItemQuery5
            // 
            this.ToolStripMenuItemQuery5.Name = "ToolStripMenuItemQuery5";
            this.ToolStripMenuItemQuery5.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery5.Text = "5. Данные о стоимости выполненных договоров в течение указанного периода времени";
            this.ToolStripMenuItemQuery5.Click += new System.EventHandler(this.ToolStripMenuItemQuery5_Click);
            // 
            // ToolStripMenuItemQuery7
            // 
            this.ToolStripMenuItemQuery7.Name = "ToolStripMenuItemQuery7";
            this.ToolStripMenuItemQuery7.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery7.Text = "7. Сведения об использовании оборудования указанным проектом";
            this.ToolStripMenuItemQuery7.Click += new System.EventHandler(this.ToolStripMenuItemQuery7_Click);
            // 
            // ToolStripMenuItemQuery8
            // 
            this.ToolStripMenuItemQuery8.Name = "ToolStripMenuItemQuery8";
            this.ToolStripMenuItemQuery8.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery8.Text = "8. Сведения об участии указанной категории сотрудников в проектах за определенный" +
    " период времени";
            this.ToolStripMenuItemQuery8.Click += new System.EventHandler(this.ToolStripMenuItemQuery8_Click);
            // 
            // ToolStripMenuItemQuery9
            // 
            this.ToolStripMenuItemQuery9.Name = "ToolStripMenuItemQuery9";
            this.ToolStripMenuItemQuery9.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery9.Text = "9. Перечень и стоимость работ, выполненных субподрядными организациями";
            this.ToolStripMenuItemQuery9.Click += new System.EventHandler(this.ToolStripMenuItemQuery9_Click);
            // 
            // toolStripMenuItemQuery10
            // 
            this.toolStripMenuItemQuery10.Name = "toolStripMenuItemQuery10";
            this.toolStripMenuItemQuery10.Size = new System.Drawing.Size(833, 26);
            this.toolStripMenuItemQuery10.Text = "10. Данные о численности и составе сотрудников, участвующих в указанном проекте";
            this.toolStripMenuItemQuery10.Click += new System.EventHandler(this.toolStripMenuItemQuery10_Click);
            // 
            // ToolStripMenuItemQuery11
            // 
            this.ToolStripMenuItemQuery11.Name = "ToolStripMenuItemQuery11";
            this.ToolStripMenuItemQuery11.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery11.Text = "11. Данные об эффективности использования оборудования";
            this.ToolStripMenuItemQuery11.Click += new System.EventHandler(this.ToolStripMenuItemQuery11_Click);
            // 
            // ToolStripMenuItemQuery12
            // 
            this.ToolStripMenuItemQuery12.Name = "ToolStripMenuItemQuery12";
            this.ToolStripMenuItemQuery12.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery12.Text = "12. Сведения об эффективности договоров с учетом привлеченных людских ресурсов";
            this.ToolStripMenuItemQuery12.Click += new System.EventHandler(this.ToolStripMenuItemQuery12_Click);
            // 
            // ToolStripMenuItemQuery14
            // 
            this.ToolStripMenuItemQuery14.Name = "ToolStripMenuItemQuery14";
            this.ToolStripMenuItemQuery14.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery14.Text = "14. Сведения об эффективности проектов";
            this.ToolStripMenuItemQuery14.Click += new System.EventHandler(this.ToolStripMenuItemQuery14_Click);
            // 
            // ToolStripMenuItemQuery6
            // 
            this.ToolStripMenuItemQuery6.Name = "ToolStripMenuItemQuery6";
            this.ToolStripMenuItemQuery6.Size = new System.Drawing.Size(833, 26);
            this.ToolStripMenuItemQuery6.Text = "6. Данные о распределении оборудования на некоторую указанную дату";
            this.ToolStripMenuItemQuery6.Click += new System.EventHandler(this.ToolStripMenuItemQuery6_Click);
            // 
            // toolStripMenuItemQuery1
            // 
            this.toolStripMenuItemQuery1.Name = "toolStripMenuItemQuery1";
            this.toolStripMenuItemQuery1.Size = new System.Drawing.Size(833, 26);
            this.toolStripMenuItemQuery1.Text = "1. Перечень сотрудников, относящихся к указанному отделу";
            this.toolStripMenuItemQuery1.Click += new System.EventHandler(this.toolStripMenuItemQuery1_Click);
            // 
            // toolStripButtonChangeUser
            // 
            this.toolStripButtonChangeUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangeUser.Image")));
            this.toolStripButtonChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeUser.Name = "toolStripButtonChangeUser";
            this.toolStripButtonChangeUser.Size = new System.Drawing.Size(177, 26);
            this.toolStripButtonChangeUser.Text = "Сменить пользователя";
            this.toolStripButtonChangeUser.Click += new System.EventHandler(this.toolStripButtonChangeUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 547);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewMainForm);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMainForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMainForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonQuery;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery7;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery8;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuery10;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery11;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery12;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery14;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuery6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuery1;
    }
}