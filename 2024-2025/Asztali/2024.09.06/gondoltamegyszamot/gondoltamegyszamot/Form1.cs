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

        private void newGame_Click(object sender, EventArgs e) {
            newGame();
        }



        private void newGame() {
            
            this.numberOfGuesses = 0;
            this.numberToGuess = rnd.Next(1, 50);

            this.to_guess.Text = numberToGuess.ToString();
            this.guess_input.Text = "";

            this.newGameBtn.Hide();

            this.guess_input.ReadOnly = false;
            this.guess_input.Focus();

            this.surrenderBtn.Show();

        }

        private void guess() {
            this.numberOfGuesses++;
            this.number_of_guesses.Text = this.numberOfGuesses.ToString();

            int guess = int.Parse(this.guess_input.Text);

            if(guess < this.numberToGuess) {
                this.feedbackOutput.Text = "Nagyobb számra gondoltam!";
                return;
            }

            if(guess > this.numberToGuess) {
                this.feedbackOutput.Text = "Kissebb számra gondoltam!";
                return;
            }

            win();
        }

        private void win() {
            this.feedbackOutput.Text = $"Hurrá! Nyertél {this.numberOfGuesses} lépésben!";
            this.guess_input.ReadOnly = true;
            this.surrenderBtn.Hide();
            this.newGameBtn.Show();

        }

        private void Form1_Load(object sender, EventArgs e) {
            this.surrenderBtn.Hide();
        }

        private void guess_btn_Click(object sender, EventArgs e) {
            guess();
        }
    }
}
