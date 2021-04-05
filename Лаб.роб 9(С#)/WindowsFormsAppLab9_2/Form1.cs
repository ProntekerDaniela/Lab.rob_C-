using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TGoods cl = new TGoods(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            listBox1.Items.Add(cl.input_and_output());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TGoods cl = new TGoods(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox5.Text = cl.cost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TGoods cl = new TGoods(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            textBox6.Text = cl.UnitToBigger((Convert.ToInt32(textBox3.Text)));
            textBox7.Text = cl.UnitToLower((Convert.ToInt32(textBox3.Text)));
            listBox2.Items.Add(cl.input_and_output_2());
        }
    }
}
