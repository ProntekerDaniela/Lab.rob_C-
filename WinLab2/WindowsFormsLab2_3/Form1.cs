using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab2_3
{
    public partial class Form1 : Form
    {
        private static int m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eps, x;

            eps = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);
            double s = 0;
            double n = 1;
            double b = (1 - (4 * Math.Pow(x, 2)) / (Math.Pow(2 * n - 1, 2) * Math.Pow(Math.PI, 2)));
            while (b >= eps)
            {
                b = (1 - (4 * Math.Pow(x, 2)) / (Math.Pow(2 * n - 1, 2) * Math.Pow(Math.PI, 2)));
                if (-1 < m && m < 1)
                {
                    textBox3.Text = "Рівність справедлива";
                }
                else
                {
                    textBox3.Text = "Рівність несправедлива";
                }
            }




        }
    }
}
