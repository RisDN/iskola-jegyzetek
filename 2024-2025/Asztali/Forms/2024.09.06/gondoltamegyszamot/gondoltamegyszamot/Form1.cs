using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gondoltamegyszamot
{
    public partial class Form1 : Form
    {

        private readonly static Random rnd = new Random();

        private int numberToGuess;
        private int numberOfGuesses = 0;

        public Form1() {
            InitializeComponent();
        }

        private void newGame() {
            this.guess_input.Enabled = true;

            this.guess_btn.Show();
            this.numberOfGuesses = 0;

            this.number_of_guesses.Text = this.numberOfGuesses.ToString();

            this.numberToGuess = rnd.Next(1, 50);

            this.to_guess.Text = numberToGuess.ToString();
            this.guess_input.Text = "";

            this.newGameBtn.Hide();

            this.guess_input.ReadOnly = false;
            this.guess_input.Focus();

            this.surrenderBtn.Show();

        }

        private void guess() {

            if(this.guess_input.Text == "")
            {
                MessageBox.Show("Kérlek adj meg egy számot!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int guess;
            try {
                guess = int.Parse(this.guess_input.Text);
            } catch (Exception e) {
                MessageBox.Show("Kérlek adj meg egy számot!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.numberOfGuesses++;
            this.number_of_guesses.Text = this.numberOfGuesses.ToString();


            if(guess < this.numberToGuess) {
                this.feedbackOutput.Text = "Nagyobb számra gondoltam!";
                return;
            }

            if(guess > this.numberToGuess) {
                this.feedbackOutput.Text = "Kisebb számra gondoltam!";
                return;
            }

            win();
        }

        private void win() {
            this.feedbackOutput.Text = $"Hurrá! Nyertél {this.numberOfGuesses} lépésben!";
            this.guess_input.ReadOnly = true;
            this.surrenderBtn.Hide();
            this.newGameBtn.Show();
            this.guess_input.Enabled = false;

        }

        private void surrender() {
            this.feedbackOutput.Text = $"Feladtad! Vesztettél!";
            this.surrenderBtn.Hide();
            this.newGameBtn.Show();
            this.guess_input.ReadOnly = true;
            this.guess_btn.Hide();
            this.guess_input.Enabled = false;

        }


        private void Form1_Load(object sender, EventArgs e) {
            this.surrenderBtn.Hide();
            this.guess_btn.Hide();
            this.guess_input.Enabled = false;


        }

        private void newGame_Click(object sender, EventArgs e) {
            newGame();
        }

        private void guess_btn_Click(object sender, EventArgs e) {
            guess();
        }

        private void surrenderBtn_Click(object sender, EventArgs e) {
            surrender();
        }
    }
}
