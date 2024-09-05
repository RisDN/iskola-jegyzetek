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
    public partial class quiter : Form
    {
        public quiter()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            Hide();
            foreach (Form form in Application.OpenForms)
            {
                if(form.Name == "main")
                {   
                    form.Show();
                    break;
                }
            }
        }
    }
}
