using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Rows = Convert.ToInt32(textBox1.Text);
            int Columns = Convert.ToInt32(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = Rows;
            dataGridView1.ColumnCount = Columns;
            int[,] matrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            Matrix cl = new Matrix(matrix: matrix);
            int[,] matrix1 = cl.OutputMatrix();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Rows = Convert.ToInt32(textBox1.Text);
            int Columns = Convert.ToInt32(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = Rows;
            dataGridView1.ColumnCount = Columns;
            int[,] matrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            int max = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        matrix[i, j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }
            Matrix cl = new Matrix(matrix: matrix);
            textBox3.Text = cl.ElementMax();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Rows = Convert.ToInt32(textBox1.Text);
            int Columns = Convert.ToInt32(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = Rows;
            dataGridView1.ColumnCount = Columns;
            int[,] matrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            int min = 9999;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        matrix[i, j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }
            Matrix cl = new Matrix(matrix: matrix);
            textBox4.Text = cl.ElementMin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Rows = Convert.ToInt32(textBox1.Text);
            int Columns = Convert.ToInt32(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = Rows;
            dataGridView1.ColumnCount = Columns;
            int[,] matrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            Matrix cl = new Matrix(matrix: matrix);
            textBox5.Text = cl.SumOfElements();
        }
    }
}

