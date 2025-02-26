using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
    internal class DatabaseConnection
    {

        private string hostname = "localhost";
        private string username = "root";
        private string password = "";
        private string database = "homerseklet";

        private string connectionString => $"server={hostname};uid={username};password={password};database={database}";

        public MySqlDataReader reader;
        MySqlConnection connection;
        public DatabaseConnection(string sqlCommand)
        {
            this.connection = new MySqlConnection(connectionString);

            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                this.reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        ~DatabaseConnection()
        {
            if (connection == null)
            {
                return;
            }

            connection.Close();
        }
    }
}
