using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koncert
{
    public partial class Form1 : Form
    {

        private int money;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculation()
        {
            money = 0;
            if(sitting_1.Checked)
            {
                money += 1990 * int.Parse(siting_count.Text);
            }

            if (sitting_2.Checked)
            {
                money += 2990 * int.Parse(siting_count.Text);
            }

            if (standing_1.Checked)
            {
                money += 1490 * int.Parse(standing_count.Text);
            }

            if (standing_2.Checked)
            {
                money += 2190 * int.Parse(standing_count.Text);
            }

            output.Text = $"Fizetendő: {money} Ft";

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void újVásárlásToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            siting_count.SelectedIndex = 0;
            standing_count.SelectedIndex = 0;

            sitting_1.Select();
            standing_1.Select();

            output.Text = $"Fizetendő: {money} Ft";
        }

        private void siting_count_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void standing_count_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void standing_2_CheckedChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void standing_1_CheckedChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void sitting_2_CheckedChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void sitting_1_CheckedChanged(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
