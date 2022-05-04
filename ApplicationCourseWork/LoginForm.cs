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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            GlobalParameters.connectionString = "";
        }

        private void buttonLoginFormOK_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalParameters.connectionString = String.Format("Server = {0}; Port={1}; User Id = {2}; Password={3}; Database={4};", "localhost", 5432, GlobalParameters.username = textBoxLogin.Text, GlobalParameters.password = textBoxPassword.Text, "db_Information_system");
                //GlobalParameters.connectionString = String.Format("Server = {0}; Port={1}; User Id = {2}; Password={3}; Database={4};", "localhost", 5432, "Admin", "Admin", "db_Information_system");
                GlobalParameters.connection = new NpgsqlConnection(GlobalParameters.connectionString);
                GlobalParameters.connection.Open();
                Hide();
                new MainForm().Show();
            }
            catch (Exception exception)
            {
                GlobalParameters.connection.Close();
                GlobalParameters.MessageError(exception);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
