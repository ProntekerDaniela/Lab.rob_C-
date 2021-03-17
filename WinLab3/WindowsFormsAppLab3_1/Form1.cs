using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab3_1
{
    public partial class Form1 : Form
    {
        private static int k;

        public static double FirstPositive { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            string[] da = textBox2.Text.Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(da[i]);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            string[] da = textBox2.Text.Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(da[i]);
            }


            for (int i = 0; i < n; i++)
            {

                if (a[i] > 0)
                {
                    FirstPositive = a[i];
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (FirstPositive == 0)
                {
                    textBox3.Text = "Додатнiх елементiв в масивi нема";
                   
                }
                else
                {
                    k = 0;

                    for (i = 0; i < n; i++)
                        if (a[i] == FirstPositive) ;
                    k += 1;


                }
            }
            textBox3.Text = k.ToString();
            

        }
    }
}
