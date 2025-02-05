using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoker_db
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection("SELECT * FROM autoker");
            MySqlDataReader reader = connection.reader;
            while (reader.Read()) {
                data_output.Rows.Add(reader["autoid"], reader["rendszam"], reader["tipus"], reader["szin"], reader["tulajszam"], reader["ar"]);
            }
           
        }
    }
}
