using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homerseklet
{
    public partial class AdatokRogzitese : Form
    {

        private Meres kivalasztva;

        public AdatokRogzitese()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void AdatokRogzitese_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection("SELECT * FROM homerseklet;");
            MySqlDataReader reader = connection.reader;

            while (reader.Read())
            {
                string datum = reader.GetDateTime("datum").ToString("yyyy-MM-dd");
                dataGridView1.Rows.Add(reader["azon"], reader["varos"], reader["napszak"], datum, reader["ertek"], reader["csapadek"]);
                new Meres(reader.GetInt32("azon"), reader.GetString("varos"), reader.GetString("napszak"), reader.GetDateTime("datum"), reader.GetDouble("ertek"), reader.GetInt32("csapadek"));
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

            input_azonosito.Clear();
            input_varos.Clear();
            input_napszak.Text = null;
            input_datum.ResetText();
            input_homerseklet.Clear();
            input_csapadek.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int azon;
            try
            {
                azon = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception) { return; }

            Meres meres = Meres.MeresByAzonosito(azon);

            kivalasztva = meres;

            input_azonosito.Text = meres.Azonosito.ToString();
            input_varos.Text = meres.Varos;
            input_napszak.Text = meres.Napszak;
            input_datum.Value = meres.Datum;
            input_homerseklet.Text = Math.Round(meres.Homerseklet, 2).ToString();
            input_csapadek.Text = meres.Csapadek.ToString();
        }
    }
}
