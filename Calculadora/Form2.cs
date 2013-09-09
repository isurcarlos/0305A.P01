using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    

    public partial class Form2 : Form
    {
        string operacion;
        double numero1;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0 + textBox1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "." + textBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = 9 + textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = 8 + textBox1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = 7 + textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = 6 + textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = 5 + textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = 4 + textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = 3 + textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = 2 + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 1 + textBox1.Text;
        }
    }
}
