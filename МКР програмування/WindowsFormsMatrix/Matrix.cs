using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMatrix
{
    class Matrix
    {
         
        private  int rows;       
        private  int columns;
        private  int[,] array;

        public Matrix() { }

       
        public Matrix(int rows, int columns)
        {
            array = new int[rows, columns];
        }

       
        public Matrix(Matrix matrix)
        {
            rows = matrix.rows;
            columns = matrix.columns;
            array = matrix.array;
        }

       
        public int Rows => array.GetLength(0);
        public int Сolumns => array.GetLength(1);

        
        public void InputMatrix()
        {
            int rows = Rows, columns = Сolumns;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Элемент [{0}][{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                }
            }
        }

        
        public void OutputMatrix()
        {
            int rows = Rows, columns = Сolumns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    return("{0, 3} ", array[i, j]);
                }
                
            }

           
        }
       
        public void ProductMax()
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                       
                    }
                }
            }

            return max;
        }

       
        public void ProductMin()
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        
                    }
                }
            }
            return min;
        }

        public void SumOfElements()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    
                }
            }
            return sum;

        }
        public static Matrix operator -(Matrix leftMatrix, Matrix rightMatrix)
        {
            int minRows = (leftMatrix.Rows < rightMatrix.Rows) ? leftMatrix.Rows : rightMatrix.Rows;
            int minColumns = (leftMatrix.сolumns < rightMatrix.сolumns) ? leftMatrix.сolumns : rightMatrix.сolumns;

            var newMatrix = new Matrix(minRows, minColumns);
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Columns; j++)
                {
                    newMatrix.matrix[i, j] = leftMatrix.matrix[i, j] - rightMatrix.matrix[i, j];
                }
            }

            return newMatrix;
        }


        
        public static Matrix operator +(Matrix leftMatrix, Matrix rightMatrix)
        {
            int minRows = (leftMatrix.Rows < rightMatrix.Rows) ? leftMatrix.Rows : rightMatrix.Rows;
            int minColumns = (leftMatrix.columns < rightMatrix.columns) ? leftMatrix.columns : rightMatrix.columns;

            var newMatrix = new Matrix(minRows, minColumns);
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.columns; j++)
                {
                    newMatrix.matrix[i, j] = leftMatrix.matrix[i, j] + rightMatrix.matrix[i, j];
                }
            }

            return newMatrix;
        }



    }


}
