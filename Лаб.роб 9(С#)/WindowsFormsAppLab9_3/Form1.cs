using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab9_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equation cl = new Equation(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add(cl.input_and_output_of_coefficients());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equation cl = new Equation(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            listBox2.Items.Add(cl.equation());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equation cl = new Equation(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox4.Text = cl.discriminant();
        }
    }
}
