using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bevlista_form
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }

        private void DisplayData()
        {
            products_output.Text = null;
            foreach (Product product in Product.GetProducts())
            {
                products_output.Text += $"{product.Name} : {product.Price} : {product.Amount}\n";
            }

            totalamount_output.Text = $"Fizetendő ár: {Product.GetTotalAmount()} Ft";
            totalcount_output.Text = $"Tételek száma: {Product.GetProductsCount()}";
            mostexpensive_output.Text = $"Legdrágább termék: {Product.GetMostExpensive().Name}";
        }

        private void LoadData()
        {
            StreamReader streamReader = new StreamReader(@"bevasarlolista.txt");
            while(!streamReader.EndOfStream)
            {
                string[] splitted = streamReader.ReadLine().Split(';');
                new Product(splitted[0], int.Parse(splitted[1]), int.Parse(splitted[2]));
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
