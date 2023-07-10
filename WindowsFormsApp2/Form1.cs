using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0, b = 0, c = 0;
        string d = " ";
        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;

            }
            switch (d)
            {
                case "x^y":
                    c = Math.Pow(a, b);
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
           
        }

        char znak = '+';
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;

        }
    }
}
