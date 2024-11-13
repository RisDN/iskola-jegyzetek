using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using vonat_centrum_verseny.Properties;

namespace vonat_centrum_verseny
{
    public partial class Form1 : Form
    {
        private static readonly Random rnd = new Random();
        private Point defaultTrainLocation;
        private PictureBox defaultCar;
        public Form1()
        {
            InitializeComponent();

            defaultTrainLocation = train.Location;
            felso.Hide();

            defaultCar = car;
            startCarTask();

        }

        public async void startCarTask()
        {
            while (true)
            {
                runCar();
                await Task.Delay(1200);
            }
        }

        public async void runCar()
        {

            PictureBox newCar = new PictureBox();
            this.Controls.Add(newCar);
            newCar.Location = new Point(-126, 170);
            newCar.Size = defaultCar.Size;
            newCar.Image = defaultCar.Image;
            newCar.BackColor = defaultCar.BackColor;
            newCar.SizeMode = defaultCar.SizeMode;
            Bitmap bitamp = new Bitmap(Resources.ferrari_296GTB);
            bitamp.MakeTransparent(Color.White);
            newCar.Image = bitamp;
            newCar.Show();


     
            bool isGoing = true;
            
            while(isGoing)
            {

                if(newCar.Location.X > 820)
                {
                    this.Controls.Remove(newCar);
                    break;
                }
                newCar.Location = new Point(newCar.Location.X + 5, newCar.Location.Y);
                await Task.Delay(1);

            }

        }

        public async void startTrain()
        {
            train.Show();
            bool isFelsoVezetekszakadas = rnd.Next(0, 2) == 1;
            bool isGoing = true;

            while (isGoing)
            {
                Console.WriteLine(train.Location.Y);
                if (train.Location.Y < -190)
                {
                    isGoing = false;
                    train.Location = defaultTrainLocation;
                    train.Hide();
                    break;
                }

                Point point = new Point(train.Location.X, train.Location.Y);
                point.Y = point.Y - 5;
                train.Location = point;
                await Task.Delay(1);

                if (isFelsoVezetekszakadas && train.Location.Y < 280 && train.Location.Y > 250)
                {
                    train.BackColor = Color.Red;
                    felso.Show();
                    isGoing = false;

                    await Task.Delay(1000);
                    isGoing = true;
                }

                felso.Hide();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTrain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runCar();
        }
    }
}
