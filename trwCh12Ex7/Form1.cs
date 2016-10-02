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

namespace trwCh12Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = "";
            decimal number1 = 0.000m;
            decimal number2 = 0.000m;
            label5.Visible = false;
            input = textBox1.Text;
            number1 = decimal.Parse(input);
            input = textBox2.Text;
            number2 = decimal.Parse(input);

            textBox3.Text = Convert.ToString(number1 * number2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            decimal number1 = 0.000m;
            decimal number2 = 0.000m;
            label5.Visible = false;
            input = textBox1.Text;
            number1 = decimal.Parse(input);
            input = textBox2.Text;
            number2 = decimal.Parse(input);

            textBox3.Text = Convert.ToString(number1 + number2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = "";
            decimal number1 = 0.000m;
            decimal number2 = 0.000m;
            label5.Visible = false;
            input = textBox1.Text;
            number1 = decimal.Parse(input);
            input = textBox2.Text;
            number2 = decimal.Parse(input);

            textBox3.Text = Convert.ToString(number1 - number2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "";
                decimal number1 = 0.000m;
                decimal number2 = 0.000m;
                label5.Visible = false;
                input = textBox1.Text;
                number1 = decimal.Parse(input);
                input = textBox2.Text;
                number2 = decimal.Parse(input);

                textBox3.Text = Convert.ToString(number1 / number2);
            }
            catch (System.DivideByZeroException)
            {
                label5.Visible = true;
                label5.Text = "Can't Divide by Zero!";
                //timer1.Enabled = true;
                //Thread.Sleep(4000);
                //label4.Text = "RESULT:";
                //label5.Visible = false;
            }
        }
    }
}
