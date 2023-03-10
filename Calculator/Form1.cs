using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            float sum = float.Parse(value1) + float.Parse(value2);
            resultBox.Text = sum.ToString();
        }

        private void difference_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            float diff = float.Parse(value1) - float.Parse(value2);
            resultBox.Text = diff.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            float pro = float.Parse(value1) * float.Parse(value2);
            resultBox.Text = pro.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;
            
            float div = float.Parse(value1) / float.Parse(value2);
            resultBox.Text = div.ToString();
        }

        private void mode_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;

            float mod = float.Parse(value1) % float.Parse(value2);
            resultBox.Text = mod.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            resultBox.Text = "0.0";
        }

        private void pow_Click(object sender, EventArgs e)
        {
            string res = resultBox.Text;

            float result = float.Parse(res) * float.Parse(res);
            resultBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res = resultBox.Text;

            float result = float.Parse(res) * float.Parse(res) * float.Parse(res);
            resultBox.Text = result.ToString();
        }
    }
}
