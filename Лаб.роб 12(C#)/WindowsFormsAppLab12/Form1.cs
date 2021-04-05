using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number cl = new Number(Convert.ToInt32(textBox1.Text));
            textBox1.Text = cl.Sum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number cl = new Number(Convert.ToInt32(textBox1.Text));
            textBox2.Text = cl.Vid();
        }
    }
}
