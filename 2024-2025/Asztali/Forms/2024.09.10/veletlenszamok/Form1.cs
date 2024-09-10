namespace veletlenszamok
{
    public partial class Form1 : Form
    {

        private int[] ints;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int count;
            try
            {
                min = Convert.ToInt32(min_input.Text);
                max = Convert.ToInt32(max_input.Text);
                count = Convert.ToInt32(count_input.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("K�rlek t�lts ki minden mez�t!");
                return;
            }

            Random rnd = new Random();
            ints = new int[count];
            string result = "";
            for (int i = 0; i < count; i++)
            {
                ints[i] = rnd.Next(min, max);
                result += ints[i] + " ";
            }

            output_numbers.Text = result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ints == null)
            {
                MessageBox.Show("K�rlek el�bb gener�lj sz�mokat!");
                return;
            }

            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            double avarge = sum / ints.Length;
            // �tlag 2 tizedesre kerek�tve

            avarage_output.Text = $"�tlag: {Math.Round(avarge, 2)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �ttel oszthat� sz�mok
            if (ints == null)
            {
                MessageBox.Show("K�rlek el�bb gener�lj sz�mokat!");
                return;
            }

            string result = "";

            foreach (int i in ints)
            {
                if (i % 5 == 0)
                {
                    result += i + " ";
                }
            }

            divide_output.Text = "�ttel oszthat� sz�mok: " + result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            divide_output.Text = "";
            avarage_output.Text = "";
            output_numbers.Text = "";
        }
    }
}
