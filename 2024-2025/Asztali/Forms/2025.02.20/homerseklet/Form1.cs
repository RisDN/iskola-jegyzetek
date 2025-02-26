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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adatokRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdatokRogzitese adatokRogzitese = new AdatokRogzitese();
            adatokRogzitese.ShowDialog();
        }
    }
}
