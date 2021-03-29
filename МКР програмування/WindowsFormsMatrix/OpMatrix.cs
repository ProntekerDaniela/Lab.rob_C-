using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMatrix
{
    class OpMatrix : Matrix
    {
        private int rows;
        private int columns;
        private int[,] array;
        public OppMatrix() : base()
        {
              this.rows=0;
              this.columns = 0;
              this.[,] array = 0;
    }
        public static Matrix operator *(Matrix leftMatrix, Matrix rightMatrix)
        {
            int minRows = (leftMatrix.Rows < rightMatrix.Rows) ? leftMatrix.Rows : rightMatrix.Rows;
            int minColumns = (leftMatrix.columns < rightMatrix.columns) ? leftMatrix.columns : rightMatrix.columns;

            var newMatrix = new Matrix(minRows, minColumns);
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.columns; j++)
                {
                    newMatrix.matrix[i, j] = leftMatrix.matrix[i, j] * rightMatrix.matrix[i, j];
                }
            }

            return newMatrix;
        }
    
    
    
    }

}
