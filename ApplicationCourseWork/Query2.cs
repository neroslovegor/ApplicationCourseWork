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
    public partial class Query2 : Form
    {
        public Query2()
        {
            InitializeComponent();
            try
            {
                string query = $"SELECT * FROM employee WHERE id_employee in (SELECT id_employee FROM position WHERE id_position in (SELECT id_position FROM department_chief))";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewQuery2.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
