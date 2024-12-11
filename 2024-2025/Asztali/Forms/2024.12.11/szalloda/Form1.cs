using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szalloda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vendeg.Load();
            DisplayData();
            for(int i = 1; i < 11; i++)
            {
                ejszakak_input.Items.Add(i);
            }
            ejszakak_input.SelectedIndex = 0;
        }


        public void DisplayData()
        {
            adatok_output.Text = null;
            foreach (Vendeg vendeg in Vendeg.vendegek)
            {
                adatok_output.Text += $"{vendeg.Nev};{vendeg.EjszakakSzama};{vendeg.VendegekSzama};{vendeg.EllatasTipusa}\n";
            }

            sum_vendegej.Text = "Vendég éjszakák száma összesen: ";
            sum_vendegej.Text += Vendeg.vendegek.Sum(x => x.VendegEjszakakSzamitas()).ToString();

            teljesellatasok.Text = "A teljes ellátást igénybevevők száma: ";
            teljesellatasok.Text += Vendeg.vendegek.Count(x => x.EllatasTipusa == "p").ToString();

            torzsvendegek_output.Text = null;
            List<Vendeg> teljesEllatask = Vendeg.vendegek.FindAll(x => x.EllatasTipusa == "p");
            foreach(Vendeg vendeg in teljesEllatask) {
                torzsvendegek_output.Text += $"{vendeg.Nev}\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nev_input.Text;

            if(nev.Length == 0)
            {
                DisplayHiba("Adja meg a vendég nevét!");
                return;
            }

            int ejszakak = 0;
            try
            {
                ejszakak = int.Parse(ejszakak_input.Text);
            }
            catch (Exception)
            {
                DisplayHiba("Adja meg az éjszakák számát!");
                return;
            }

            int vendegekSzama = 0;
            try
            {
                vendegekSzama = int.Parse(vendegek_input.Text);
            }
            catch (Exception)
            {
                DisplayHiba("Adja meg a vendégek számát!");
                return;
            }

        }

        public void DisplayHiba(string message)
        {
            MessageBox.Show(message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
