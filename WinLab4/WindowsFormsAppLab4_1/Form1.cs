using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab4_1
{
    public partial class Form1 : Form
    {
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
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
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j]+ "\t";
                }
            }




        }


        private void button2_Click(object sender, EventArgs e)
            {
            int d = 0;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            double[,] matrix = new double[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
            {

            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
               {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j]+"\t";
                if (i % 2 == 0 && j % 2 == 0)
                {

                    if (matrix[i, j] < 0)

                        d += 1;

                }

               }
            }
            textBox3.Text = d.ToString();
            
        }
    }




    
}
