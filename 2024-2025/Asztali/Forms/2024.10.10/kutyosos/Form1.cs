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

namespace kutyosos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog.dogs.Clear();
            StreamReader sr = new StreamReader(@"kutyak.txt");
            string line;
            while (!sr.EndOfStream) {
                new Dog(sr.ReadLine());
            }

            sr.Close();

            int kan = Dog.dogs.FindAll(d => d.Sex == "kan").Count;
            int szuka = Dog.dogs.FindAll(d => d.Sex == "szuka").Count;

            kan_output.Text = kan.ToString();
            szuka_output.Text = szuka.ToString();

            output.Text = "";
            old_output.Text = "";
            var olderThanFive = Dog.dogs.FindAll(d => d.Age > 5 && d.Sex == "szuka");
            for(int i = 0; i < olderThanFive.Count; i++)
            {
                old_output.Text += olderThanFive[i].Name + "\n";
            }

            foreach (Dog dog in Dog.dogs)
            {
                output.Text += $"{dog.Name}: {dog.Genre}, {dog.Age} év. {dog.Sex}\n";
            }

        }
    }
}
