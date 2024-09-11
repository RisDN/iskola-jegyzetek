using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vonatjegy1
{
    public partial class Form1 : Form
    {
        private static readonly int KM_PRICE = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void calculatePrice()
        {
            int km = 0;
            int price = 0;

            if (km_input.Text != "" && km_input.Text != "0")
            {
                km = int.Parse(km_input.Text);
            }

            string type = type_input.Text;
            switch (type)
            {
                case "50%-os kedvezmény":
                    price = km * KM_PRICE - (int)(km * (KM_PRICE * 0.5));
                    break;
                case "90%-os kedvezmény":
                    price = km * KM_PRICE - (int)(km * (KM_PRICE * 0.9));
                    break;
                case "Teljes árú":
                    price = (int)(km * KM_PRICE);
                    break;
            }

            price_output.Text = "A fizetendő összeg: " + price.ToString() + " Ft.";
        }

        private void type_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void kieg_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }
    }
}
