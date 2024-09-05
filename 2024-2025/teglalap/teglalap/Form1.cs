using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teglalap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aInput.Text);
            double b = double.Parse(bInput.Text);

            output.Text = $"A téglalap kerülete: {2*(a*b)} cm\nA téglalap területe: {a*b} cm2";

        }
    }
}
