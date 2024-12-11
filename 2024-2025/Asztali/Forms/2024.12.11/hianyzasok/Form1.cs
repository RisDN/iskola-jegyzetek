using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hianyzasok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Diak.Load();
            DisplayData();
            for (int i = 1; i < 32; i++) {
                hanyadikan_input.Items.Add(i);
            }
            hanyadikan_input.SelectedIndex = 0;
        }

        public void DisplayData()
        {
            table_output.Rows.Clear();
            foreach (Diak d in Diak.diakok)
            {
                table_output.Rows.Add(d.Nev, d.Osztaly, d.Hanyadika, d.Igazolt, d.NemIgazolt, d.NapiHianyzasSzamolas());
            }

            int maxHianyzas = Diak.diakok.Max(k => k.NapiHianyzasSzamolas());
            legtobb_h.Text = "Legtöbb hiányzás: ";
            legtobb_h.Text = legtobb_h.Text + maxHianyzas;

            List<Diak> max10 = Diak.diakok.FindAll(k => k.NapiHianyzasSzamolas() >= 10);
            htanulok.Clear();
            adatok_output.Clear();
            foreach (Diak diak in max10)
            {
                htanulok.Text += diak.Nev + "\n";
            }

            foreach(Diak diak in Diak.diakok)
            {
                adatok_output.Text += diak.Nev + " " + diak.Osztaly + " " + diak.Hanyadika + " " + diak.Igazolt + " " + diak.NemIgazolt + "\n";
            }
            
        }
           

        private void mentes_btn_Click(object sender, EventArgs e)
        {
            
            string name = nev_input.Text;
            string osztaly = osztaly_input.Text;

            if(name.Length == 0 || osztaly.Length == 0)
            {
                MessageBox.Show("Add meg a nevet és az osztályt is!");
                return;
            }

            int hanyadikan = int.Parse(hanyadikan_input.Text);
            int igazolt = 0;
            int nemIgazolt = 0;
            try
            {
                 igazolt = int.Parse(igazolt_input.Text);
                 nemIgazolt = int.Parse(nemigazolt_input.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot kell megadjon az igazolt és nem igazolt hiányzásoknál!");
                return;
            }

            new Diak(name, osztaly, hanyadikan, igazolt, nemIgazolt);
            Diak.Save();
            DisplayData();
        }

        private void igazolt_input_TextChanged(object sender, EventArgs e)
        {
            OsszesHianyzas();
        }

        private void nemigazolt_input_TextChanged(object sender, EventArgs e)
        {
            OsszesHianyzas();
        }

        public void OsszesHianyzas()
        {
            osszesh_output.Text = "Összes hiányzása adott napon: ";
            try
            {
                int igazolt = int.Parse(igazolt_input.Text);
                int nemIgazolt = int.Parse(nemigazolt_input.Text);
                osszesh_output.Text = osszesh_output.Text + (igazolt + nemIgazolt).ToString();
            } catch (Exception)
            {
                return;
            }
        }
    }
}
