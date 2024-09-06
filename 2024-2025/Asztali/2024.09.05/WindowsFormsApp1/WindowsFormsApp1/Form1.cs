using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void startTicks()
        {
           int i = 0;
           while(true)
            {
                i++;
                this.timerOutput.Text = i.ToString();
                await Task.Delay(1000);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.output.Text = "Üdvözöllek, " + inputField.Text + "!";
            this.info.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            startTicks();
        }
    }
}
    