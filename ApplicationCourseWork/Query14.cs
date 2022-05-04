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
    public partial class Query14 : Form
    {
        public Query14()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT project.id_project, project.date_of_start, project.date_of_finish, project.cost, project.id_manager, project.id_contract, subcontractor.id_subcontractor, subcontractor.name_of_org, subcontractor.cost_of_work, subcontractor.deadline, subcontractor.amount_of_work_transferred FROM project
                               INNER JOIN subcontractor ON project.id_project = subcontractor.id_project WHERE project.id_project = '{Convert.ToInt32(textBoxQuery14.Text)}'";

                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery14.DataSource = dataTable;

                query = @$"SELECT COUNT(employee.id_employee) FROM employee
                        INNER JOIN _group ON _group.id_group = employee.id_group WHERE _group.id_project = '{Convert.ToInt32(textBoxQuery14.Text)}'";

                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                MessageBox.Show($"Всего учатников в данном проекте: {dataTable.Rows[0][0]}", "Результат запроса", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
