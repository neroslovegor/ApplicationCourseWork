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
    public partial class Query7 : Form
    {
        public Query7()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM equioment WHERE id_group in (SELECT id_group FROM _group WHERE id_project = '{Convert.ToInt32(textBoxQuery7.Text)}')";
                NpgsqlCommand command = new NpgsqlCommand(query, GlobalParameters.connection);
                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewQuery7.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                GlobalParameters.MessageError(exception);
            }
        }
    }
}
