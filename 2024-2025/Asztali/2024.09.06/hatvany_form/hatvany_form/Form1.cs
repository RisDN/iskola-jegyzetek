using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hatvany_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

            if (alap_input.TextLength == 0)
            {
                alap_input.Focus();
                alap_input.Text = "";
                MessageBox.Show("Kérem adja meg a hatvány alapját!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(kitevo_input.TextLength == 0)
            {
                kitevo_input.Focus();
                kitevo_input.Text = "";
                MessageBox.Show("Kérem adja meg a hatvány kitevőjét!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            double alap = double.Parse(alap_input.Text);
            double kitevo = double.Parse(kitevo_input.Text);
            double eredmeny = Math.Pow(alap, kitevo);
            output.Text = "A hatványozás eredménye: " + eredmeny.ToString();

        }
    }
}
