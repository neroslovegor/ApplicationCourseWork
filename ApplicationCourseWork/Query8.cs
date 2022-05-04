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
    public partial class Query8 : Form
    {
        public Query8()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @$"SELECT * FROM project WHERE project.id_project in 
                                (SELECT _group.id_project FROM _group WHERE _group.id_group in 
                                (SELECT employee.id_group FROM employee WHERE employee.id_employee in 
                                (SELECT position.id_employee FROM position INNER JOIN {comboBoxQuery8.SelectedItem} ON {comboBoxQuery8.SelectedItem}.id_position = position.id_position))) AND project.date_of_start >= '{Convert.ToDateTime(dateTimePicker1Query8.Value.ToString("yyyy-MM-dd"))}' AND project.date_of_finish <= '{Convert.ToDateTime(dateTimePicker2Query8.Value.ToString("yyyy-MM-dd"))}'";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewQuery8.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
