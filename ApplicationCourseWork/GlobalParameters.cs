using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace ApplicationCourseWork
{
    class GlobalParameters
    {
        public static string connectionString;
        public static NpgsqlConnection connection;
        public static string username;
        public static string password;

        public static void MessageError(Exception exception)
        {
            MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
