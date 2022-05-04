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
    public partial class Query10 : Form
    {
        public Query10()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT employee.id_employee, employee.surname, employee.name, employee.patronymic, employee.education, employee.salary, employee.schedule, employee.id_department, employee.id_group FROM employee
                               INNER JOIN _group ON _group.id_group = employee.id_group WHERE _group.id_project = '{Convert.ToInt32(textBoxQuery10.Text)}'";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery10.DataSource = dataTable;

                query = @$"(SELECT COUNT(employee.id_employee) FROM employee
                        INNER JOIN _group ON _group.id_group = employee.id_group WHERE _group.id_project = '{Convert.ToInt32(textBoxQuery10.Text)}')";
                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                MessageBox.Show($"Всего сотрудников: {dataTable.Rows[0][0]}", "Результат запроса", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
