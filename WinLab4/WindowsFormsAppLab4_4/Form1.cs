using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab4_4
{
    public partial class Form1 : Form
    {
        private int j;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = b;
            int number = 1;
            double[] fh = new double[a];
            double[,] matrix = new double[a, b];
            
           
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            for (int i = 0; i < a; i++)
            {
                fh[i] = matrix[i, (b - number)];
                number++;
            }
            
            Array.Sort(fh);
           
            for (int i = 0; i < a; i++)
            {
                dataGridView3.Rows[0].Cells[i].Value = fh[i];
               
               
            }








        }
    }
}
