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

namespace homerseklet
{
    public partial class AdatokRogzitese : Form
    {
        public AdatokRogzitese()
        {
            InitializeComponent();
        }

        private void AdatokRogzitese_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection("SELECT * FROM homerseklet;");
            MySqlDataReader reader = connection.reader;

            while (reader.Read())
            {
                string datum = reader.GetDateTime("datum").ToString("yyyy-MM-dd");
                dataGridView1.Rows.Add(reader["azon"], reader["varos"], reader["napszak"], datum, reader["ertek"], reader["csapadek"]);
            }

        }
    }
}
