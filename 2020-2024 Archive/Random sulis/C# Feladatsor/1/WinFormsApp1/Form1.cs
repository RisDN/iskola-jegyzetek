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

        private void udvozol_Click(object sender, EventArgs e)
        {
            string vezeteknev = vezeteknev_box.Text;
            string keresztnev = keresztnev_box.Text;
            string telefonszam = telszam_box.Text;
            kijelzo.Text = "Üdvözöllek!\n" + vezeteknev + " " + keresztnev + "\nTelefonszám: " + telefonszam;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
