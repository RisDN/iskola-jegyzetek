using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace asd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string felhasznalo = textBox1.Text;
            string jelszo = textBox2.Text;
            int mennyiseg = Decimal.ToInt32(numericUpDown1.Value);

            string email = "risiskola5@gmail.com";
            string ejelszo = "Titkos12!";

            if (felhasznalo != "")
            {
                if (jelszo != "")
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient server = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(email);
                    mail.To.Add("r.andriska05@gmail.com");
                    mail.Subject = "asd";
                    mail.Body = "asdawd";
                    server.Send(mail);

                }
                else MessageBox.Show("Kérlek add meg jelszavadat.", "Hiba!");
            } else MessageBox.Show("Kérlek add meg felhasználónevedet.", "Hiba!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
