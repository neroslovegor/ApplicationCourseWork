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
    public partial class Query5 : Form
    {
        public Query5()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM contract WHERE date_of_conclusion >= '{Convert.ToDateTime(dateTimePicker1Query5.Value.ToString("yyyy-MM-dd"))}' AND date_of_completion <= '{Convert.ToDateTime(dateTimePicker2Query5.Value.ToString("yyyy-MM-dd"))}'";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                dataGridViewQuery5.DataSource = dataTable;

                query = $"SELECT sum(cost_of_work) FROM contract WHERE date_of_conclusion >= '{Convert.ToDateTime(dateTimePicker1Query5.Value.ToString("yyyy-MM-dd"))}' AND date_of_completion <= '{Convert.ToDateTime(dateTimePicker2Query5.Value.ToString("yyyy-MM-dd"))}'";
                command = new NpgsqlCommand(query, GlobalParameters.connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());

                MessageBox.Show($"Всего: {dataTable.Rows[0][0]}", "Результат запроса", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
