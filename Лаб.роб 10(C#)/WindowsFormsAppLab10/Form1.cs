using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCircle cl = new TCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add(cl.input_and_output());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCircle cl = new TCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = cl.area().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TCircle cl = new TCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox4.Text = cl.sector().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TCircle cl = new TCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox5.Text = cl.length_1().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TCircle cl = new TCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox6.Text = cl.comparison_length();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TSphere cl = new TSphere(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox7.Text = cl.surface_of_the_ball().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TSphere cl = new TSphere(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox8.Text = cl.radius_dod();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TSphere cl = new TSphere(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox9.Text = cl.radius_vid();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TSphere cl = new TSphere(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox10.Text = cl.radius_number();
        }
    }
}
