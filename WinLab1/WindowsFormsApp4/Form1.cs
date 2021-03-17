using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, t, y;
            x = Convert.ToDouble(textBox1.Text);
            t = 0;
            y = 0;
            if (x >= 2)
            {
                t = Convert.ToDouble(Math.Log(x));
                Console.WriteLine("t={0}", t);
            }
            else
            {
                t = Convert.ToDouble(Math.Cos(x));
                Console.WriteLine("t={0}", t);
            }
            if (t >= 0)
            {
                y = Convert.ToDouble(Math.Pow(Math.E, t) * Math.Sin(t));
                Console.WriteLine("y={0}", y);
            }
            else
            {
                y = Convert.ToDouble(Math.Pow(Math.E, t) * Math.Cos(t));
                Console.WriteLine("y={0}", y);
            }
            textBox2.Text = t.ToString();
            textBox3.Text = y.ToString();
        }
    }
}
