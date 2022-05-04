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
    public partial class InsertForm : Form
    {
        public InsertForm(string _nameTable, DataGridView _dataGridViewMainForm)
        {
            InitializeComponent();
            nameTable = _nameTable;
            dataGridViewMainForm = _dataGridViewMainForm;
        }

        private string nameTable;
        private DataGridView dataGridViewMainForm;
        DataTable dataTable;

        private void buttonInsertFormOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                NpgsqlCommand command;
                switch (nameTable)
                {
                    case "constructor":
                        {
                            query = $"CALL insert_constructor ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "contract":
                        {
                            if (Convert.ToDateTime(textBoxInsertForm1.Text) < Convert.ToDateTime(textBoxInsertForm2.Text))
                            {
                                query = $"CALL insert_contract ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}','{textBoxInsertForm5.Text}');";
                                command = new NpgsqlCommand(query, GlobalParameters.connection);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Неправильный ввод даты!");
                            }
                        }
                        break;
                    case "customer":
                        {
                            query = $"CALL insert_customer ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "department":
                        {
                            query = $"CALL insert_department ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "department_chief":
                        {
                            query = $"CALL insert_department_chief ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "employee":
                        {
                            query = $"CALL insert_employee ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}','{textBoxInsertForm5.Text}','{textBoxInsertForm6.Text}','{textBoxInsertForm7.Text}','{textBoxInsertForm8.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();

                            query = @$"SELECT COUNT(employee.id_employee) FROM employee WHERE employee.id_department = '{textBoxInsertForm7.Text}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            query = $"UPDATE department SET num_of_employees = '{dataTable.Rows[0][0]}' WHERE id_department = {textBoxInsertForm7.Text};";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());



                            query = @$"SELECT COUNT(employee.id_employee) FROM employee WHERE employee.id_group = '{textBoxInsertForm8.Text}'";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());

                            query = $"UPDATE _group SET num_of_people = '{dataTable.Rows[0][0]}' WHERE id_group = {textBoxInsertForm8.Text};";

                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            dataTable = new DataTable();
                            dataTable.Load(command.ExecuteReader());
                        }
                        break;
                    case "engineer":
                        {
                            query = $"CALL insert_engineer ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "equioment":
                        {
                            query = $"CALL insert_equioment ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "_group":
                        {
                            query = $"CALL insert_group ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "laboratory_assist":
                        {
                            query = $"CALL insert_laboratory_assist ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "manager":
                        {
                            query = $"CALL insert_managert ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "position":
                        {
                            query = $"CALL insert_position ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "project":
                        {
                            if (Convert.ToDateTime(textBoxInsertForm1.Text) < Convert.ToDateTime(textBoxInsertForm2.Text))
                            {
                                query = $"CALL insert_project ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}','{textBoxInsertForm5.Text}');";
                                command = new NpgsqlCommand(query, GlobalParameters.connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "service_staff":
                        {
                            query = $"CALL insert_service_staff ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "subcontractor":
                        {
                            query = $"CALL insert_subcontractor ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}','{textBoxInsertForm4.Text}','{textBoxInsertForm5.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "technician":
                        {
                            query = $"CALL insert_technician ('{textBoxInsertForm1.Text}','{textBoxInsertForm2.Text}','{textBoxInsertForm3.Text}');";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                }
                
                query = $"SELECT * FROM {nameTable}";
                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewMainForm.DataSource = dataTable;
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception exception)
            {

                GlobalParameters.MessageError(exception);
            }
        }
    }
}
