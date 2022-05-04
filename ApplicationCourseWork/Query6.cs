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
    public partial class Query6 : Form
    {
        public Query6()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT * FROM _group
                               INNER JOIN equioment ON _group.id_group = equioment.id_group WHERE _group.id_project in 
                               (SELECT project.id_project FROM project WHERE date_of_start <= '{Convert.ToDateTime(dateTimePicker2Query6.Value.ToString("yyyy-MM-dd"))}' AND date_of_finish >= '{Convert.ToDateTime(dateTimePicker2Query6.Value.ToString("yyyy-MM-dd"))}')";

                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewQuery6.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
