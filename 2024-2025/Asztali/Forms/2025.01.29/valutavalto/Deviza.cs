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

namespace valutavalto
{
    public partial class Deviza : Form
    {

        private string filename = @"devizak.txt";
        public Deviza()
        {
            InitializeComponent();
        }

        private void dev_input_TextChanged(object sender, EventArgs e)
        {
            if(dev_input.Text.Length != 3)
            {
                return;
            }

            if(!isFileExists())
            {
                return;
            }

            if (isDevizaExists(dev_input.Text))
            {
                MessageBox.Show("A deviza már létezik!" + " (" + dev_input.Text + ")");
                dev_input.Text = "";
                dev_input.Focus();
            }

        }

        private bool isDevizaExists(string input)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                if (parts[0] == input)
                {
                    streamReader.Close();
                    return true;
                }
                
            }
            streamReader.Close();
            return false;
        }

        private bool isFileExists()
        {
            return File.Exists(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Biztos elveti?", "Válasszon", MessageBoxButtons.YesNo);
            if(message == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
