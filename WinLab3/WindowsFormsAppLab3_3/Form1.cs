using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            string[] db = textBox3.Text.Split(' ');
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(db[i]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            string[] dc = textBox4.Text.Split(' ');
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = Convert.ToDouble(dc[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            string[] da = textBox2.Text.Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(da[i]);
            }
            
            n = Convert.ToInt32(textBox1.Text);
            string[] db = textBox3.Text.Split(' ');
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(db[i]);
            }

            
            n = Convert.ToInt32(textBox1.Text);
            string[] dc = textBox4.Text.Split(' ');
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = Convert.ToDouble(dc[i]);
            }

            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = a[i] - (3 * b[i]) + (2 * c[i]);
                listBox1.Items.Add(d[i]);
            }

        }

    }
}
