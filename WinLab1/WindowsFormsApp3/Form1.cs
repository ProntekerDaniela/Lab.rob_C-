using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2, x3, y3, x4 , y4;
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            x2 = Convert.ToDouble(textBox3.Text);
            y2 = Convert.ToDouble(textBox4.Text);
            x3 = Convert.ToDouble(textBox5.Text);
            y3 = Convert.ToDouble(textBox6.Text);
            x4 = Convert.ToDouble(textBox7.Text);
            y4 = Convert.ToDouble(textBox8.Text);

            if ((x2 - x1) + (x4 - x1) == (x3 - x1) && (y2 - y1) + (y4 - y1) == (y3 - y1))
            {
                
                textBox9.Text = "Координати є вершинами паралелограму";
            }
            else
            {
                
                textBox9.Text = "Координати не є вершинами паралелограму";
            }

        }
    }
}
