using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab8
{
    class Matrix
    {
        private  int[,] array;   
        private  int rows;       
        private  int columns;

        public Matrix(int[,] matrix) { }
        
        

        
        public Matrix(int rows, int columns)
        {
            array = new int[rows, columns];
        }

        
        public Matrix(Matrix previousMatrix)
        {
            rows = previousMatrix.rows;
            columns = previousMatrix.columns;
            array = previousMatrix.array;
        }

       
        public int Rows => array.GetLength(0);

        
        public int Сolumns => array.GetLength(1);

        
        public int [,] InputMatrix()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int rows = Rows, columns = Сolumns;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
         
           }
            return array;

        }

        
        public int [,] OutputMatrix()
        {
            return array;

        }
       
        
        public string ElementMax()
        {
            int max = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            
            return $"{ max}";
        }

        
        public string ElementMin()
        {
            int min = 99999;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
           
            return $"{ min}";
        }

        public string SumOfElements()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                }
            }
            return $"{sum}";
        }
    }
}
