using System;
using System.Windows.Forms;

namespace MyFirstWinFormProject
{
    public partial class Form2 : Form
    {
        private string valueText1;
        private string valueText2;
        private decimal result;
        private string factrioal;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(valueText1);
            decimal t2 = Convert.ToDecimal(valueText2);
            result = t - t2;
            Console.WriteLine(result);
            label6.Text = result.ToString();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valueText1 = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            valueText2 = textBox2.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(valueText1);
            decimal t2 = Convert.ToDecimal(valueText2);
            result = t + t2;
            Console.WriteLine(result);
            label6.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(valueText1);
            decimal t2 = Convert.ToDecimal(valueText2);
            if (t2 == 0)
                result = 0;
            else
            result = t / t2;
            Console.WriteLine(result);
            label6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(valueText1);
            decimal t2 = Convert.ToDecimal(valueText2);
                result = t * t2;
          
            Console.WriteLine(result);
            label6.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(valueText1);
            decimal t2 = Convert.ToDecimal(valueText2);
            result = t % t2;
            Console.WriteLine(result);
            label6.Text = result.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            factrioal = textBox3.Text;
       
            if (Int32.TryParse(factrioal, out int parsed))
            {
                int res = 1;
                for (int i = 2; i <= parsed; i++)
                    res *= i;

                label8.Text = res.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
