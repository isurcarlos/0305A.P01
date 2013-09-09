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
    public partial class Form1 : Form
    {
        string convert, convert1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            convert = Convert.ToString(comboBox1.SelectedItem);
           convert1= Convert.ToString(comboBox2.SelectedItem);
           if (convert == "Celsius" && convert1 == "Kelvin")
           {
               textBox2.Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble(textBox1.Text) + 273.15));
           }
           else if (convert == "Kelvin" && convert1 == "Celsius")
           {
               textBox2.Text = Convert.ToString(Convert.ToDouble(Convert.ToDouble(textBox1.Text) - 273.15));
           }
           else if (convert == "Fahrenheit" && convert1 == "Celsius")
           {
               textBox2.Text = Convert.ToString(Convert.ToDouble((Convert.ToDouble(textBox1.Text)-32)/1.8));
           }
           else if (convert == "Celsius" && convert1 == "Fahrenheit")
           {
               textBox2.Text = Convert.ToString(Convert.ToDouble((1.8 * Convert.ToDouble(textBox1.Text)) +32));
           }
           else if (convert == "Fahrenheit" && convert1 == "Kelvin")
           {
               textBox2.Text=Convert.ToString(Convert.ToDouble((5/9)*(Convert.ToDouble(textBox1.Text)-32)+273));
           }
           else if (convert == "Kelvin" && convert1 == "Fahrenheit")
           {
               textBox2.Text = Convert.ToString(Convert.ToDouble((9 / 5) * (Convert.ToDouble(textBox1.Text) - 273) + 32));
           }
        }
    }
}
