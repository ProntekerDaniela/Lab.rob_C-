using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab5_3
{
    public partial class Form1 : Form
    {
        static double x(double i)
        {
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 7;
            }
            else
            {
                return (x(i - 1) * (1 + x(i - 2)));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            textBox1.Text = n.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            textBox1.Text = n.ToString();
            n = x(n);
            textBox2.Text = n.ToString();
        }

    }
}
