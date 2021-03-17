using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab4_3
{
    public partial class Form1 : Form
    {
        private int i;
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
            dataGridView2.RowCount = a;
            dataGridView2.ColumnCount = b;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            dataGridView2.RowCount = a;
            dataGridView2.ColumnCount = b;
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
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j] + "\t";
                }
            }
            for (i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    if (i <= j)
                        dataGridView2.Rows[i].Cells[j].Value = matrix[i, j] + "\t";
                    
                    else
                        dataGridView2.Rows[i].Cells[j].Value = "0\t";
                    
                }
            }



        }
    }
}
