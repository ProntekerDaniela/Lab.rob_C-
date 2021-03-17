using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab3_2
{
    public partial class Form1 : Form
    {
        private static int k;
        private static int d;
        private static int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] arr = new int[n];
            d = 2;
            i = 1;
            int NewElement = d / i;
            for (int i = 0; i < n; i++)
            {
                k = ((int)(Math.Pow((-1), i) * i));
                int add = d * k;
                NewElement += add;
                arr[i] = NewElement;

            }
            k = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    k = k + arr[i];
                }
                else
                {
                    k = k;
                }
            }
            textBox2.Text = k.ToString();

        }
    }
}
