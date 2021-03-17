using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab2_1
{
    public partial class Form1 : Form
    {
        private static double m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            double s = 0;
            double i = 0;
            while (n >= i)
            {
                double k = (2 * n) / (a + n);
                m = m + k;
                i += 1;
            }

            textBox3.Text = m.ToString();
        }
    }
}
