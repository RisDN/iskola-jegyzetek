using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopapirollo
{
    public partial class Form1 : Form
    {
        List<string> options = new List<string> { "Kő", "Papír", "Olló" };
        private int pointsComputer = 0;
        private int pointsPlayer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void user_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userChoice = user_input.SelectedItem.ToString();

            Random random = new Random();
            int index = random.Next(options.Count);
            string computerChoice = options[index];

            computer_output.Text = computerChoice;

            if (userChoice == computerChoice)
            {
                pointsComputer++;
                pointsPlayer++;
            }
            else if (userChoice == "Kő" && computerChoice == "Olló" ||
                     userChoice == "Papír" && computerChoice == "Kő" ||
                     userChoice == "Olló" && computerChoice == "Papír")
            {
                pointsPlayer++;
            }
            else
            {
                pointsComputer++;
            }

            updateScoreboard();
            checkWin();
        }

        private void checkWin()
        {
            if(pointsComputer == 5 && pointsPlayer == 5)
            {
                MessageBox.Show("Döntetlen!");
                return;
            }

            if (pointsPlayer >= 5)
            {
                MessageBox.Show("A játékos nyert!");
                return;
            }
            if (pointsComputer >= 5)
            {
                MessageBox.Show("A számítógép nyert!");
                return;
            }

        }

        private void updateScoreboard()
        {
            scoreboard.Text = $"{pointsComputer}\t:\t{pointsPlayer}";
        }
    }
}
