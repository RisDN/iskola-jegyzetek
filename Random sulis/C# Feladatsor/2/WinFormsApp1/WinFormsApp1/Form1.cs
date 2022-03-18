using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bemenet = input.Text;
            int nevhossza = bemenet.Length;
            if(nevhossza != 0)
            {
                if(bemenet.Contains(" "))
                {
                    string vezeteknev = bemenet.Split(" ")[0];
                    string keresztnev = bemenet.Split(" ")[1];
                    kijelzo.Text = "Helló " + keresztnev;
                    vezeteknev_kijelzo.Text = vezeteknev.ToUpper();
                    keresztnev_kijelzo.Text = keresztnev.ToLower();
                    hossz_kijelzo.Text = (nevhossza-1).ToString();
                } else { hiba(); }
            } else { hiba(); }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            input.Text = "";
            vezeteknev_kijelzo.Text = "";
            keresztnev_kijelzo.Text = "";
            hossz_kijelzo.Text = "";
            kijelzo.Text = "";
            MessageBox.Show("Törölve!");
        }

        private void doktor_Click(object sender, EventArgs e)
        {
            int nevhossza = input.Text.Length;
            if (nevhossza != 0)
            {
                string vezeteknev = input.Text.Split(" ")[0];
                string keresztnev = input.Text.Split(" ")[1];
                input.Text = $"Dr {vezeteknev} {keresztnev}";
                kijelzo.Text = "Helló Dr " + keresztnev;
            }
            else { hiba(); }
            
        }
        public void hiba()
        {
            MessageBox.Show("Kérlek rendes nevet adj meg!");
        }
    }
}
