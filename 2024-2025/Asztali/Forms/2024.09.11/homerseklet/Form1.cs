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

        private int[] ints;
        private static readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if(!validateInputs())
            {
                return;
            }

            int days = int.Parse(days_input.Text);
            double heat = double.Parse(heat_input.Text);

            ints = new int[days];
            string result = "";
            for(int i = 0; i < days; i++)
            {
                ints[i] = random.Next(16, 28);
                result += ints[i] + " ";
            }

            output.Text = result;

            avarage();
            smallest();
            find_matches_count();
        }

        private void find_matches_count()
        {
            if(ints == null)
            {
                MessageBox.Show("Nincs adat!");
                return;
            }

            int chosen = int.Parse(heat_input.Text);
            int count = 0;
            for(int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == chosen)
                {
                    count++;
                }
            }

            heat_output.Text = count.ToString();
        }

        private void smallest()
        {

            if (ints == null)
            {
                MessageBox.Show("Nincs adat!");
                return;
            }

            int min = ints.Min();
            min_output.Text = min.ToString();
        }

        private void avarage()
        {

            if (ints == null)
            {
                MessageBox.Show("Nincs adat!");
                return;
            }

            int sum = ints.Sum();
            double avg = (double)sum / ints.Length;

            avarage_output.Text = Math.Round(avg, 2).ToString();

        }

        private bool validateInputs()
        {
            try
            {
                int days = int.Parse(days_input.Text);
            }
            catch
            {
                MessageBox.Show("Add meg a napok számát!");
                days_input.Focus();
                return false;
            }

            try
            {
                double heat = double.Parse(heat_input.Text);
            }
            catch
            {
                MessageBox.Show("Add meg a hőmérsékletet!");
                heat_input.Focus();
                return false;
            }

            return true;
        }
    }
}
