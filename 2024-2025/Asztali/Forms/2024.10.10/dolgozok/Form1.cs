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

namespace dolgozok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader streamReader = new StreamReader("dolgozok.txt");

            List<Dolgozo> list = new List<Dolgozo>();

            while (!streamReader.EndOfStream)
            {
                list.Add(new Dolgozo(streamReader.ReadLine())); 
            }
            streamReader.Close();

            double avg = list.Average(x => x.Age);
            label3.Text = "Dolgozók átlagéletkora: " + avg.ToString("0.0") + " év";
            label2.Text = "Dolgozói létszám: " + list.Count.ToString();



            foreach (Dolgozo dolgozo in list)
            {
                richTextBox1.Text += $"{dolgozo.Name}: {dolgozo.Age} év, {dolgozo.City}, {dolgozo.Sex}\n";
            }


        }
    }
}
