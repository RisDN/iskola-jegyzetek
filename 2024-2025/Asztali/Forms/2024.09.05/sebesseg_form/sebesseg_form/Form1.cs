using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sebesseg_form
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(pathinput.Text);
            double hour = double.Parse(hourinput.Text);
            double speed = distance / hour;
            speedoutput.Text = $"{speed:00}";

            if(speed > 50)
            {
                speedlimit.Text = "Gyorshajtás!";
                speedlimit.ForeColor = Color.DarkRed;
                return;
            }
            speedlimit.Text = "Megengedett sebességgel hajt!";
            speedlimit.ForeColor = Color.Green;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new quiter();
            form.Show();
            this.Hide();
        }
    }
}
