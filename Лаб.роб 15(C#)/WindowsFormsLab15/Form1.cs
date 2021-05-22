using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 6, h = 0.6, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while(x<=b){
                y = Math.Pow(x,Math.Atan(x));
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0, b = 6, h = 0.6, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = -(Math.Pow(x, Math.Atan(x)));
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
    }
}
