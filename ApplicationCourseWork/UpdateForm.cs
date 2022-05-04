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
    public partial class UpdateForm : Form
    {
        public UpdateForm(string _nameTable, DataGridView _dataGridViewMainForm, int _index)
        {
            InitializeComponent();
            nameTable = _nameTable;
            dataGridViewMainForm = _dataGridViewMainForm;
            index = _index;
        }

        private string nameTable;
        private DataGridView dataGridViewMainForm;
        private int index;

        private void buttonUpdateFormOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                NpgsqlCommand command;
                switch (nameTable)
                {
                    case "constructor":
                        {
                            //query = $"CALL update_constructor ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}');";
                            query = $"UPDATE constructor SET(specialization, num_of_patents, science_degree, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}') WHERE id_constructor = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "contract":
                        {
                            if (Convert.ToDateTime(textBoxUpdateForm1.Text) < Convert.ToDateTime(textBoxUpdateForm2.Text))
                            {
                                //query = $"CALL update_contract ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}');";
                                query = $"UPDATE contract SET(date_of_conclusion, date_of_completion, cost_of_work, id_manager, id_customer) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}') WHERE id_contract = {index};";
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
                            //query = $"CALL update_customer ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}');";
                            query = $"UPDATE customer SET(customer_name, phone_number) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}') WHERE id_customer = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "department":
                        {
                            //query = $"CALL update_department ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}');";
                            query = $"UPDATE department SET(type_of_activity, num_of_employees, id_chief) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}') WHERE id_department = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "department_chief":
                        {
                            //query = $"CALL update_department_chief ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}');";
                            query = $"UPDATE department_chief SET(date_of_appointment, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}') WHERE id_chief = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "employee":
                        {
                            //query = $"CALL update_employee ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}','{textBoxUpdateForm6.Text}','{textBoxUpdateForm7.Text}','{textBoxUpdateForm8.Text}');";
                            query = $"UPDATE employee SET(surname, name, patronymic, education, salary, schedule, id_department, id_group) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}','{textBoxUpdateForm6.Text}','{textBoxUpdateForm7.Text}','{textBoxUpdateForm8.Text}') WHERE id_employee = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "engineer":
                        {
                            //query = $"CALL update_engineer ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}');";
                            query = $"UPDATE engineer SET(specialization, science_degree, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}') WHERE id_engineer = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "equioment":
                        {
                            //query = $"CALL update_equioment ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}');";
                            query = $"UPDATE equioment SET(equioment_type, purchase_date, id_department, id_group) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}') WHERE id_equioment = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "_group":
                        {
                            //query = $"CALL update_group ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}');";
                            query = $"UPDATE _group SET(num_of_people, id_project) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}') WHERE id_group = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "laboratory_assist":
                        {
                            //query = $"CALL update_laboratory_assist ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}');";
                            query = $"UPDATE laboratory_assist SET(specialization, num_of_studies, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}') WHERE id_laboratory_assist = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "manager":
                        {
                            //query = $"CALL update_managert ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}');";
                            query = $"UPDATE manager SET(id_constructor, id_engineer) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}') WHERE id_manager = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "position":
                        {
                            //query = $"CALL update_position ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}');";
                            query = $"UPDATE position SET(position_name, work_experience, id_employee) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}') WHERE id_position = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "project":
                        {
                            if (Convert.ToDateTime(textBoxUpdateForm1.Text) < Convert.ToDateTime(textBoxUpdateForm2.Text))
                            {
                                //query = $"CALL update_project ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}');";
                                query = $"UPDATE project SET(date_of_start, date_of_finish, cost, id_manager, id_contract) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}') WHERE id_project = {index};";
                                command = new NpgsqlCommand(query, GlobalParameters.connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "service_staff":
                        {
                            //query = $"CALL update_service_staff ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}');";
                            query = $"UPDATE service_staff SET(service_area, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}') WHERE id_service_staff = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "subcontractor":
                        {
                            //query = $"CALL update_subcontractor ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}');";
                            query = $"UPDATE subcontractor SET(name_of_org, cost_of_work, deadline, amount_of_work_transferred, id_project) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}','{textBoxUpdateForm4.Text}','{textBoxUpdateForm5.Text}') WHERE id_subcontractor = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                    case "technician":
                        {
                            //query = $"CALL update_technician ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}');";
                            query = $"UPDATE subcontractor SET(specialization, num_of_equipment, id_position) = ('{textBoxUpdateForm1.Text}','{textBoxUpdateForm2.Text}','{textBoxUpdateForm3.Text}') WHERE id_technician = {index};";
                            command = new NpgsqlCommand(query, GlobalParameters.connection);
                            command.ExecuteNonQuery();
                        }
                        break;
                }

                query = $"SELECT * FROM {nameTable}";
                command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewMainForm.DataSource = dataTable;
                MessageBox.Show("Запись обновлена!");
            }
            catch (Exception exception)
            {

                GlobalParameters.MessageError(exception);
            }
        }
    }
}
