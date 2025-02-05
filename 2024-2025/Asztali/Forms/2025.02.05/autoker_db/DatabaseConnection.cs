using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace autoker_db
{
    internal class DatabaseConnection
    {

        private string hostname = "linsql.verebely.dc";
        private string username = "diak32";
        private string password = "DAVYBH";
        private string database = "diak32";

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
