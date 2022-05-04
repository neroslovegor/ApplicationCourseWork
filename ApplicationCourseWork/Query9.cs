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
    public partial class Query9 : Form
    {
        public Query9()
        {
            InitializeComponent();

            try
            {
                string query = @$"SELECT project.id_project, project.date_of_start, project.date_of_finish, project.cost, project.id_manager, project.id_contract, subcontractor.cost_of_work FROM project
                               INNER JOIN subcontractor ON subcontractor.id_project = project.id_project";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery9.DataSource = dataTable;

                query = @$"SELECT sum(subcontractor.cost_of_work) FROM project
                        INNER JOIN subcontractor ON subcontractor.id_project = project.id_project";
                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                textBoxQuery9.Text = dataTable.Rows[0][0].ToString();
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
