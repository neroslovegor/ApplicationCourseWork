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
    public partial class Query3 : Form
    {
        public Query3()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM project WHERE date_of_start >= '{Convert.ToDateTime(dateTimePicker1Query3.Value.ToString("yyyy-MM-dd"))}' AND date_of_finish <= '{Convert.ToDateTime(dateTimePicker2Query3.Value.ToString("yyyy-MM-dd"))}'";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewQuery3.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
