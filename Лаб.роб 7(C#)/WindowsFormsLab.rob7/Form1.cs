using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab.rob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            listBox1.Items.Add (cl.input_and_output_of_coefficients());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            textBox8.Text = cl.point();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            textBox15.Text = cl.parallel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            listBox2.Items.Add(cl.projection());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            listBox3.Items.Add(cl.crossing());
        }
    }
}
