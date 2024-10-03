using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sportolok
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            Player.loadPlayers();
            refreshOutput();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            int age;
            try
            {
                age = int.Parse(age_input.Text);
            }
            catch (Exception)
            {
                age_input.Focus();
                MessageBox.Show("Hibás életkor!");
                return;
            }

            if(age > 40 || age < 6)
            {
                age_input.Focus();
                MessageBox.Show("Hibás életkor! Minimum 6 és 40 között kell lennie.");
                return;
            }

            if(name.Length == 0)
            {
                name_input.Focus();
                MessageBox.Show("Hibás név!");
                return;
            }

            new Player(name, age);
            refreshOutput();
            Player.savePlayers();
            name_input.Text = "";
            age_input.Text = "";
        }


        private void refreshOutput()
        {
            players_output.Text = "";
            foreach(Player player in Player.players)
            {
                players_output.Text += player.ToString() + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sumAges = Player.players.Sum(p => p.Age);
            double avarage = (double) sumAges / Player.players.Count;
            showInfoBox("Átlag", $"Az összes játékos átlag életkora: {avarage:0.00}");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Player youngestPlayer = Player.players.OrderBy(p => p.Age).First();

            showInfoBox("Legfiatalabb játékos", $"A legfiatalabb játékos: {youngestPlayer.Name} ({youngestPlayer.Age} éves)");
        }

        private void showInfoBox(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player oldestPlayer = Player.players.OrderBy(p => p.Age).Last();

            showInfoBox("Legidősebb játékos", $"A legidősebb játékos: {oldestPlayer.Name} ({oldestPlayer.Age} éves)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Player.savePlayers();
            MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Player> youngPlayers = Player.players.Where(p => p.Age >= 10 && p.Age <= 12).ToList();
            string message = "10 és 12 év közöttiek:\n";
            foreach (Player player in youngPlayers)
            {
                message += player.ToString() + "\n";
            }

            showInfoBox("10 és 12 év közöttiek", message);
        }
    }
}
