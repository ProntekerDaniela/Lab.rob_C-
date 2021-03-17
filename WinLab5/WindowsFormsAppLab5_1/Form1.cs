using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab5_1
{
    public partial class Form1 : Form
    {

        private static double s (double k, double b = 2, double c = 7)
        {
            
            double x1; double x2;
            double d = Math.Pow(b, 2) - 4 * k * c;
            if (d < 0)
            {
                return 0;

            }
            else
            {
                if (d == 0) //квадратне рівняння має два однакові корені
                {
                    x1 = -b / (2 * k);
                    return x2 = x1;
                }
                else //рівняння має два різні корені
                {
                    return x1 = (-b + Math.Sqrt(d)) / (2 * k);
                    return x2 = (-b - Math.Sqrt(d)) / (2 * k);
                   

                }
            }


        }


            public Form1()
            {
            InitializeComponent();
            }

        

        private void button2_Click(object sender, EventArgs e)
        {
            double a =Convert.ToDouble(textBox1.Text);
            textBox1.Text = a.ToString();
            double b =(int) Convert.ToDouble(textBox1.Text);
            textBox1.Text = b.ToString();
            a =s(a);
            b = s(b);
            textBox3.Text = a.ToString();
            textBox4.Text = b.ToString();
          
        }
    }
}
