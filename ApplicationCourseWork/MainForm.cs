using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ApplicationCourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void toolStripComboBoxMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBoxMainForm.Focused)
                {
                    string query = $"SELECT * FROM {toolStripComboBoxMainForm.SelectedItem}";
                    NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                    DataTable dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());
                    dataGridViewMainForm.DataSource = dataTable;
                }
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<InsertForm>().Count() == 0)
            {
                InsertForm insertForm = new InsertForm((string)toolStripComboBoxMainForm.SelectedItem, dataGridViewMainForm);

                #region
                insertForm.labelInsertForm1.Visible = false;
                insertForm.labelInsertForm2.Visible = false;
                insertForm.labelInsertForm3.Visible = false;
                insertForm.labelInsertForm4.Visible = false;
                insertForm.labelInsertForm5.Visible = false;
                insertForm.labelInsertForm6.Visible = false;
                insertForm.labelInsertForm7.Visible = false;
                insertForm.labelInsertForm8.Visible = false;

                insertForm.textBoxInsertForm1.Visible = false;
                insertForm.textBoxInsertForm2.Visible = false;
                insertForm.textBoxInsertForm3.Visible = false;
                insertForm.textBoxInsertForm4.Visible = false;
                insertForm.textBoxInsertForm5.Visible = false;
                insertForm.textBoxInsertForm6.Visible = false;
                insertForm.textBoxInsertForm7.Visible = false;
                insertForm.textBoxInsertForm8.Visible = false;

                insertForm.panelInsertForm1.Visible = false;
                insertForm.panelInsertForm2.Visible = false;
                insertForm.panelInsertForm3.Visible = false;
                insertForm.panelInsertForm4.Visible = false;
                insertForm.panelInsertForm5.Visible = false;
                insertForm.panelInsertForm6.Visible = false;
                insertForm.panelInsertForm7.Visible = false;
                insertForm.panelInsertForm8.Visible = false;
                #endregion
                switch (toolStripComboBoxMainForm.SelectedItem)
                {
                    case "constructor":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;

                            insertForm.labelInsertForm1.Text = "Специализация";
                            insertForm.labelInsertForm2.Text = "Количество патентов";
                            insertForm.labelInsertForm3.Text = "Ученая степень";
                            insertForm.labelInsertForm4.Text = "id_position";
                            #endregion
                            insertForm.Width = 660;
                            insertForm.Show();
                        }
                        break;
                    case "contract":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;
                            insertForm.labelInsertForm5.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;
                            insertForm.textBoxInsertForm5.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;
                            insertForm.panelInsertForm5.Visible = true;

                            insertForm.labelInsertForm1.Text = "Дата заключения";
                            insertForm.labelInsertForm2.Text = "Дата завершения";
                            insertForm.labelInsertForm3.Text = "Стоимость работ";
                            insertForm.labelInsertForm4.Text = "id_manager";
                            insertForm.labelInsertForm5.Text = "id_customer";
                            #endregion
                            insertForm.Width = 815;
                            insertForm.Show();
                        }
                        break;
                    case "customer":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;

                            insertForm.labelInsertForm1.Text = "Имя заказчика";
                            insertForm.labelInsertForm2.Text = "Номер телефона";
                            #endregion
                            insertForm.Width = 350;
                            insertForm.Show();
                        }
                        break;
                    case "department":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;

                            insertForm.labelInsertForm1.Text = "Вид деятельности";
                            insertForm.labelInsertForm2.Text = "Количество сотрудников";
                            insertForm.labelInsertForm3.Text = "id_chief";
                            #endregion
                            insertForm.Width = 500;
                            insertForm.Show();
                        }
                        break;
                    case "department_chief":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;

                            insertForm.labelInsertForm1.Text = "Дата назначения";
                            insertForm.labelInsertForm2.Text = "id_position";
                            #endregion
                            insertForm.Width = 350;
                            insertForm.Show();
                        }
                        break;
                    case "employee":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;
                            insertForm.labelInsertForm5.Visible = true;
                            insertForm.labelInsertForm6.Visible = true;
                            insertForm.labelInsertForm7.Visible = true;
                            insertForm.labelInsertForm8.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;
                            insertForm.textBoxInsertForm5.Visible = true;
                            insertForm.textBoxInsertForm6.Visible = true;
                            insertForm.textBoxInsertForm7.Visible = true;
                            insertForm.textBoxInsertForm8.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;
                            insertForm.panelInsertForm5.Visible = true;
                            insertForm.panelInsertForm6.Visible = true;
                            insertForm.panelInsertForm7.Visible = true;
                            insertForm.panelInsertForm8.Visible = true;

                            insertForm.labelInsertForm1.Text = "Фамилия";
                            insertForm.labelInsertForm2.Text = "Имя";
                            insertForm.labelInsertForm3.Text = "Отчество";
                            insertForm.labelInsertForm4.Text = "Образование";
                            insertForm.labelInsertForm5.Text = "Зарплата";
                            insertForm.labelInsertForm6.Text = "График работы";
                            insertForm.labelInsertForm7.Text = "id_department";
                            insertForm.labelInsertForm8.Text = "id_group";
                            #endregion
                            insertForm.Show();
                        }
                        break;
                    case "engineer":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;

                            insertForm.labelInsertForm1.Text = "Специализация";
                            insertForm.labelInsertForm2.Text = "Ученая степень";
                            insertForm.labelInsertForm3.Text = "id_position";
                            #endregion
                            insertForm.Width = 500;
                            insertForm.Show();
                        }
                        break;
                    case "equioment":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;

                            insertForm.labelInsertForm1.Text = "Тип оборудования";
                            insertForm.labelInsertForm2.Text = "Дата покупки";
                            insertForm.labelInsertForm3.Text = "id_department";
                            insertForm.labelInsertForm4.Text = "id_group";
                            #endregion
                            insertForm.Width = 660;
                            insertForm.Show();
                        }
                        break;
                    case "_group":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;

                            insertForm.labelInsertForm1.Text = "Количество человек";
                            insertForm.labelInsertForm2.Text = "id_project";
                            #endregion
                            insertForm.Width = 350;
                            insertForm.Show();
                        }
                        break;
                    case "laboratory_assist":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;

                            insertForm.labelInsertForm1.Text = "Специализация";
                            insertForm.labelInsertForm2.Text = "Количество исследований";
                            insertForm.labelInsertForm3.Text = "id_position";
                            #endregion
                            insertForm.Width = 500;
                            insertForm.Show();
                        }
                        break;
                    case "manager":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;

                            insertForm.labelInsertForm1.Text = "id_constructor";
                            insertForm.labelInsertForm2.Text = "id_engineer";
                            #endregion
                            insertForm.Width = 350;
                            insertForm.Show();
                        }
                        break;
                    case "position":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;

                            insertForm.labelInsertForm1.Text = "Название должности";
                            insertForm.labelInsertForm2.Text = "Стаж работы";
                            insertForm.labelInsertForm3.Text = "id_employee";
                            #endregion
                            insertForm.Width = 500;
                            insertForm.Show();
                        }
                        break;
                    case "project":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;
                            insertForm.labelInsertForm5.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;
                            insertForm.textBoxInsertForm5.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;
                            insertForm.panelInsertForm5.Visible = true;

                            insertForm.labelInsertForm1.Text = "Дата начала";
                            insertForm.labelInsertForm2.Text = "Дата окончания";
                            insertForm.labelInsertForm3.Text = "Стоимость";
                            insertForm.labelInsertForm4.Text = "id_manager";
                            insertForm.labelInsertForm5.Text = "id_contract";
                            #endregion
                            insertForm.Width = 815;
                            insertForm.Show();
                        }
                        break;
                    case "service_staff":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;

                            insertForm.labelInsertForm1.Text = "Область обслуживания";
                            insertForm.labelInsertForm2.Text = "id_position";
                            #endregion
                            insertForm.Width = 350;
                            insertForm.Show();
                        }
                        break;
                    case "subcontractor":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;
                            insertForm.labelInsertForm4.Visible = true;
                            insertForm.labelInsertForm5.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;
                            insertForm.textBoxInsertForm4.Visible = true;
                            insertForm.textBoxInsertForm5.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;
                            insertForm.panelInsertForm4.Visible = true;
                            insertForm.panelInsertForm5.Visible = true;

                            insertForm.labelInsertForm1.Text = "Название организации";
                            insertForm.labelInsertForm2.Text = "Стоимость работ";
                            insertForm.labelInsertForm3.Text = "Срок сдачи";
                            insertForm.labelInsertForm4.Text = "Объем работы";
                            insertForm.labelInsertForm5.Text = "id_project";
                            #endregion
                            insertForm.Width = 815;
                            insertForm.Show();
                        }
                        break;
                    case "technician":
                        {
                            #region
                            insertForm.labelInsertForm1.Visible = true;
                            insertForm.labelInsertForm2.Visible = true;
                            insertForm.labelInsertForm3.Visible = true;

                            insertForm.textBoxInsertForm1.Visible = true;
                            insertForm.textBoxInsertForm2.Visible = true;
                            insertForm.textBoxInsertForm3.Visible = true;

                            insertForm.panelInsertForm1.Visible = true;
                            insertForm.panelInsertForm2.Visible = true;
                            insertForm.panelInsertForm3.Visible = true;

                            insertForm.labelInsertForm1.Text = "Специализация";
                            insertForm.labelInsertForm2.Text = "Количество оборудования";
                            insertForm.labelInsertForm3.Text = "id_position";
                            #endregion
                            insertForm.Width = 500;
                            insertForm.Show();
                        }
                        break;
                }
            }
        }
        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateForm>().Count() == 0 && toolStripComboBoxMainForm.SelectedItem != null)
            {                
                string query = $"SELECT * FROM {toolStripComboBoxMainForm.SelectedItem} LIMIT 1 OFFSET {dataGridViewMainForm.SelectedCells[0].RowIndex};";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                UpdateForm updateForm = new UpdateForm((string)toolStripComboBoxMainForm.SelectedItem, dataGridViewMainForm, Convert.ToInt32(dataTable.Rows[0][0]));

                #region
                updateForm.labelUpdateForm1.Visible = false;
                updateForm.labelUpdateForm2.Visible = false;
                updateForm.labelUpdateForm3.Visible = false;
                updateForm.labelUpdateForm4.Visible = false;
                updateForm.labelUpdateForm5.Visible = false;
                updateForm.labelUpdateForm6.Visible = false;
                updateForm.labelUpdateForm7.Visible = false;
                updateForm.labelUpdateForm8.Visible = false;

                updateForm.textBoxUpdateForm1.Visible = false;
                updateForm.textBoxUpdateForm2.Visible = false;
                updateForm.textBoxUpdateForm3.Visible = false;
                updateForm.textBoxUpdateForm4.Visible = false;
                updateForm.textBoxUpdateForm5.Visible = false;
                updateForm.textBoxUpdateForm6.Visible = false;
                updateForm.textBoxUpdateForm7.Visible = false;
                updateForm.textBoxUpdateForm8.Visible = false;

                updateForm.panelUpdateForm1.Visible = false;
                updateForm.panelUpdateForm2.Visible = false;
                updateForm.panelUpdateForm3.Visible = false;
                updateForm.panelUpdateForm4.Visible = false;
                updateForm.panelUpdateForm5.Visible = false;
                updateForm.panelUpdateForm6.Visible = false;
                updateForm.panelUpdateForm7.Visible = false;
                updateForm.panelUpdateForm8.Visible = false;
                #endregion
                switch (toolStripComboBoxMainForm.SelectedItem)
                {
                    case "constructor":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Специализация";
                            updateForm.labelUpdateForm2.Text = "Количество патентов";
                            updateForm.labelUpdateForm3.Text = "Ученая степень";
                            updateForm.labelUpdateForm4.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            #endregion
                            updateForm.Width = 660;
                            updateForm.Show();
                        }
                        break;
                    case "contract":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;
                            updateForm.labelUpdateForm5.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;
                            updateForm.textBoxUpdateForm5.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;
                            updateForm.panelUpdateForm5.Visible = true;


                            updateForm.labelUpdateForm1.Text = "Дата заключения";
                            updateForm.labelUpdateForm2.Text = "Дата завершения";
                            updateForm.labelUpdateForm3.Text = "Стоимость работ";
                            updateForm.labelUpdateForm4.Text = "id_manager";
                            updateForm.labelUpdateForm5.Text = "id_customer";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            updateForm.textBoxUpdateForm5.Text = dataTable.Rows[0][5].ToString();
                            #endregion
                            updateForm.Width = 815;
                            updateForm.Show();
                        }
                        break;
                    case "customer":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Имя заказчика";
                            updateForm.labelUpdateForm2.Text = "Номер телефона";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            #endregion
                            updateForm.Width = 350;
                            updateForm.Show();
                        }
                        break;
                    case "department":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Вид деятельности";
                            updateForm.labelUpdateForm2.Text = "Количество сотрудников";
                            updateForm.labelUpdateForm3.Text = "id_chief";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            #endregion
                            updateForm.Width = 500;
                            updateForm.Show();
                        }
                        break;
                    case "department_chief":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Дата назначения";
                            updateForm.labelUpdateForm2.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            #endregion
                            updateForm.Width = 350;
                            updateForm.Show();
                        }
                        break;
                    case "employee":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;
                            updateForm.labelUpdateForm5.Visible = true;
                            updateForm.labelUpdateForm6.Visible = true;
                            updateForm.labelUpdateForm7.Visible = true;
                            updateForm.labelUpdateForm8.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;
                            updateForm.textBoxUpdateForm5.Visible = true;
                            updateForm.textBoxUpdateForm6.Visible = true;
                            updateForm.textBoxUpdateForm7.Visible = true;
                            updateForm.textBoxUpdateForm8.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;
                            updateForm.panelUpdateForm5.Visible = true;
                            updateForm.panelUpdateForm6.Visible = true;
                            updateForm.panelUpdateForm7.Visible = true;
                            updateForm.panelUpdateForm8.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Фамилия";
                            updateForm.labelUpdateForm2.Text = "Имя";
                            updateForm.labelUpdateForm3.Text = "Отчество";
                            updateForm.labelUpdateForm4.Text = "Образование";
                            updateForm.labelUpdateForm5.Text = "Зарплата";
                            updateForm.labelUpdateForm6.Text = "График работы";
                            updateForm.labelUpdateForm7.Text = "id_department";
                            updateForm.labelUpdateForm8.Text = "id_group";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            updateForm.textBoxUpdateForm5.Text = dataTable.Rows[0][5].ToString();
                            updateForm.textBoxUpdateForm6.Text = dataTable.Rows[0][6].ToString();
                            updateForm.textBoxUpdateForm7.Text = dataTable.Rows[0][7].ToString();
                            updateForm.textBoxUpdateForm8.Text = dataTable.Rows[0][8].ToString();
                            #endregion
                            updateForm.Show();
                        }
                        break;
                    case "engineer":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Специализация";
                            updateForm.labelUpdateForm2.Text = "Ученая степень";
                            updateForm.labelUpdateForm3.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            #endregion
                            updateForm.Width = 500;
                            updateForm.Show();
                        }
                        break;
                    case "equioment":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Тип оборудования";
                            updateForm.labelUpdateForm2.Text = "Дата покупки";
                            updateForm.labelUpdateForm3.Text = "id_department";
                            updateForm.labelUpdateForm4.Text = "id_group";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            #endregion
                            updateForm.Width = 660;
                            updateForm.Show();
                        }
                        break;
                    case "_group":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Количество человек";
                            updateForm.labelUpdateForm2.Text = "id_project";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            #endregion
                            updateForm.Width = 350;
                            updateForm.Show();
                        }
                        break;
                    case "laboratory_assist":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Специализация";
                            updateForm.labelUpdateForm2.Text = "Количество исследований";
                            updateForm.labelUpdateForm3.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            #endregion
                            updateForm.Width = 500;
                            updateForm.Show();
                        }
                        break;
                    case "manager":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;

                            updateForm.labelUpdateForm1.Text = "id_constructor";
                            updateForm.labelUpdateForm2.Text = "id_engineer";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            #endregion
                            updateForm.Width = 350;
                            updateForm.Show();
                        }
                        break;
                    case "position":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Название должности";
                            updateForm.labelUpdateForm2.Text = "Стаж работы";
                            updateForm.labelUpdateForm3.Text = "id_employee";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            #endregion
                            updateForm.Width = 500;
                            updateForm.Show();
                        }
                        break;
                    case "project":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;
                            updateForm.labelUpdateForm5.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;
                            updateForm.textBoxUpdateForm5.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;
                            updateForm.panelUpdateForm5.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Дата начала";
                            updateForm.labelUpdateForm2.Text = "Дата окончания";
                            updateForm.labelUpdateForm3.Text = "Стоимость";
                            updateForm.labelUpdateForm4.Text = "id_manager";
                            updateForm.labelUpdateForm5.Text = "id_contract";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            #endregion
                            updateForm.Width = 815;
                            updateForm.Show();
                        }
                        break;
                    case "service_staff":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Область обслуживания";
                            updateForm.labelUpdateForm2.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            #endregion
                            updateForm.Width = 350;
                            updateForm.Show();
                        }
                        break;
                    case "subcontractor":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;
                            updateForm.labelUpdateForm4.Visible = true;
                            updateForm.labelUpdateForm5.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;
                            updateForm.textBoxUpdateForm4.Visible = true;
                            updateForm.textBoxUpdateForm5.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;
                            updateForm.panelUpdateForm4.Visible = true;
                            updateForm.panelUpdateForm5.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Название организации";
                            updateForm.labelUpdateForm2.Text = "Стоимость работ";
                            updateForm.labelUpdateForm3.Text = "Срок сдачи";
                            updateForm.labelUpdateForm4.Text = "Объем работы";
                            updateForm.labelUpdateForm5.Text = "id_project";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            updateForm.textBoxUpdateForm4.Text = dataTable.Rows[0][4].ToString();
                            updateForm.textBoxUpdateForm5.Text = dataTable.Rows[0][5].ToString();
                            #endregion
                            updateForm.Width = 815;
                            updateForm.Show();
                        }
                        break;
                    case "technician":
                        {
                            #region
                            updateForm.labelUpdateForm1.Visible = true;
                            updateForm.labelUpdateForm2.Visible = true;
                            updateForm.labelUpdateForm3.Visible = true;

                            updateForm.textBoxUpdateForm1.Visible = true;
                            updateForm.textBoxUpdateForm2.Visible = true;
                            updateForm.textBoxUpdateForm3.Visible = true;

                            updateForm.panelUpdateForm1.Visible = true;
                            updateForm.panelUpdateForm2.Visible = true;
                            updateForm.panelUpdateForm3.Visible = true;

                            updateForm.labelUpdateForm1.Text = "Специализация";
                            updateForm.labelUpdateForm2.Text = "Количество оборудования";
                            updateForm.labelUpdateForm3.Text = "id_position";

                            updateForm.textBoxUpdateForm1.Text = dataTable.Rows[0][1].ToString();
                            updateForm.textBoxUpdateForm2.Text = dataTable.Rows[0][2].ToString();
                            updateForm.textBoxUpdateForm3.Text = dataTable.Rows[0][3].ToString();
                            #endregion
                            updateForm.Width = 500;
                            updateForm.Show();
                        }
                        break;
                }
            }
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxMainForm.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                string query = $"SELECT * FROM {toolStripComboBoxMainForm.SelectedItem} LIMIT 1 OFFSET {dataGridViewMainForm.SelectedCells[0].RowIndex};";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                var indexDel = dataTable.Rows[0][0];

                try
                {
                    if (toolStripComboBoxMainForm.SelectedItem.ToString() != "_group")
                    {
                        if (toolStripComboBoxMainForm.SelectedItem.ToString() == "employee")
                        {
                            query = @$"SELECT employee.id_department FROM employee WHERE employee.id_employee = '{indexDel}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            var idDepartment = dataTable.Rows[0][0];

                            query = @$"SELECT COUNT(employee.id_employee) FROM employee WHERE employee.id_department = '{idDepartment}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            query = $"UPDATE department SET num_of_employees = '{dataTable.Rows[0][0]}' WHERE id_department = {idDepartment};";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());



                            query = @$"SELECT employee.id_group FROM employee WHERE employee.id_employee = '{indexDel}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            var idGroup = dataTable.Rows[0][0];

                            query = @$"SELECT COUNT(employee.id_employee) FROM employee WHERE employee.id_group = '{idGroup}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            query = $"UPDATE _group SET num_of_people = '{dataTable.Rows[0][0]}' WHERE id_group = {idGroup};";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());
                        }
                        query = $"DELETE FROM {toolStripComboBoxMainForm.SelectedItem} WHERE id_{toolStripComboBoxMainForm.SelectedItem} = {indexDel};";
                        command = new NpgsqlCommand(query, GlobalParameters.connection);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        query = $"DELETE FROM {toolStripComboBoxMainForm.SelectedItem} WHERE id_group = {dataTable.Rows[0][0]};";
                        command = new NpgsqlCommand(query, GlobalParameters.connection);
                        command.ExecuteNonQuery();
                    }

                    query = $"SELECT * FROM {toolStripComboBoxMainForm.SelectedItem}";
                    command = new NpgsqlCommand(query, GlobalParameters.connection);
                    dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());
                    dataGridViewMainForm.DataSource = dataTable;
                    MessageBox.Show("Запись удалена!");
                }
                catch (Exception exception)
                {
                    GlobalParameters.MessageError(exception);
                }
            }
        }

        private void ToolStripMenuItemQuery2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query2>().Count() == 0)
            {
                new Query2().Show();
            }
        }
        private void ToolStripMenuItemQuery3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query3>().Count() == 0)
            {
                new Query3().Show();
            }
        }
        private void ToolStripMenuItemQuery4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query4>().Count() == 0)
            {
                new Query4().Show();
            }
        }
        private void ToolStripMenuItemQuery5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query5>().Count() == 0)
            {
                new Query5().Show();
            }
        }
        private void ToolStripMenuItemQuery7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query7>().Count() == 0)
            {
                new Query7().Show();
            }
        }
        private void ToolStripMenuItemQuery8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query8>().Count() == 0)
            {
                new Query8().Show();
            }
        }
        private void ToolStripMenuItemQuery9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query9>().Count() == 0)
            {
                new Query9().Show();
            }
        }
        private void toolStripMenuItemQuery10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query10>().Count() == 0)
            {
                new Query10().Show();
            }
        }
        private void ToolStripMenuItemQuery11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query11>().Count() == 0)
            {
                new Query11().Show();
            }
        }
        private void ToolStripMenuItemQuery12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query12>().Count() == 0)
            {
                new Query12().Show();
            }
        }
        private void ToolStripMenuItemQuery14_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query14>().Count() == 0)
            {
                new Query14().Show();
            }
        }
        private void ToolStripMenuItemQuery6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query6>().Count() == 0)
            {
                new Query6().Show();
            }
        }
        private void toolStripMenuItemQuery1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Query1>().Count() == 0)
            {
                new Query1().Show();
            }
        }

        private void toolStripButtonChangeUser_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }
    }
}
