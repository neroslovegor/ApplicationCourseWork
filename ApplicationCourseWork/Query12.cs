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
    public partial class Query12 : Form
    {
        public Query12()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT * FROM contract WHERE id_contract = '{Convert.ToInt32(textBoxQuery12.Text)}'";

                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery12.DataSource = dataTable;

                query = @$"SELECT COUNT(employee.id_employee) FROM employee
                        INNER JOIN _group ON _group.id_group = employee.id_group WHERE _group.id_project in
                        (SELECT project.id_project FROM project WHERE project.id_contract = '{Convert.ToInt32(textBoxQuery12.Text)}')";

                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                MessageBox.Show($"Всего учатников в данном договоре: {dataTable.Rows[0][0]}", "Результат запроса", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
