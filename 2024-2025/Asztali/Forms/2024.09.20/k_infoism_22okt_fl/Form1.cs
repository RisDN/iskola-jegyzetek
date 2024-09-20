using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_infoism_22okt_fl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            distance.SelectedIndex = 3;
            time.Text = "1:00:00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }


        private void calculate()
        {
            DateTime dateTime = DateTime.Parse(time.Text);
            int distance = GetDistance();
            // 1km = 1000m, 1 óra, = 3600s

            double avarageSpeedKmh = distance / (dateTime.Hour + dateTime.Minute / 60.0 + dateTime.Second / 3600.0);
            double avarageSpeedMs = avarageSpeedKmh * 1000 / 3600;

            km_output.Text = $"Átlagsebesség [km/h]: {avarageSpeedKmh:0.00}";
            m_output.Text = $"Átlagsebesség [m/s]: : {avarageSpeedMs:0.00}";
        }

        private int GetDistance()
        {

            string[] splitted = distance.SelectedItem.ToString().Split('-');
            return int.Parse(splitted[1].Trim().Replace("km", ""));
        }
    }
}
