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
    public partial class Query11 : Form
    {
        public Query11()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT * FROM project WHERE project.id_project in
                               (SELECT _group.id_project FROM _group
                               INNER JOIN equioment ON _group.id_group = equioment.id_group WHERE equioment.id_equioment = '{Convert.ToInt32(textBoxQuery11.Text)}')";

                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery11.DataSource = dataTable;

                query = @$"SELECT  COUNT(project.id_project) FROM project WHERE project.id_project in
                        (SELECT _group.id_project FROM _group
                        INNER JOIN equioment ON _group.id_group = equioment.id_group WHERE equioment.id_equioment = '{Convert.ToInt32(textBoxQuery11.Text)}')";

                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                MessageBox.Show($"Всего проектов с участием этого оборудования: {dataTable.Rows[0][0]}", "Результат запроса", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
