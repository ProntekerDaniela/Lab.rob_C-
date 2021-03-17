using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] masiv = { 1, 6, 0, 7, 5, 8, 3, 8, 5, 7, 4, 2, 4, 7, 3, 5, 7, 7, 4, 2, 9 };


            for (int i = 0; i < masiv.Length; i++)
            {
                listBox1.Items.Add(masiv);
                

            }
            Array.Sort(masiv);
            Array.Reverse(masiv);
           
            for (int i = 0; i < masiv.Length; i++)
            {
                listBox2.Items.Add(masiv[i]);
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] masiv = { 1, 6, 0, 7, 5, 8, 3, 8, 5, 7, 4, 2, 4, 7, 3, 5, 7, 7, 4, 2, 9 };


            for (int i = 0; i < masiv.Length; i++)
            {
                listBox1.Items.Add(masiv);


            }
        }
    }
}
