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

        private void button1_Click(object sender, EventArgs e)
        {
            Ellenorzes();

        }

        private void Ellenorzes()
        {
            try
            {
                int.Parse(input_azonosito.Text);
            }
            catch (Exception)
            {
                HibaUzenet("Az azonosítónak egész számnak kell lennie!");
                return;
            }

            try
            {
                double.Parse(input_homerseklet.Text);
            }
            catch (Exception)
            {
                HibaUzenet("A hőmérsékletnek tört számnak kell lennie!");
                return;
            }

            try
            {
                int.Parse(input_csapadek.Text);
            }
            catch (Exception)
            {
                HibaUzenet("A csapadéknak egész számnak kell lennie!");
                return;
            }
        }

        private void HibaUzenet(string hiba)
        {
            MessageBox.Show(hiba, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
        }
    }
}
