using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.rob4_3
{
    class Program
    {
        int x;
        static void Main(string[] args)
        {
            //Дано матрицю.Звести дану матрицю до верхньої трикутної матриці.
            int m, n, i, j;
            Console.Write("Введiть кiльксть рядкiв i стовпцiв матрицi A i B: ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nВведiть першу матрицю : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nМатриця A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Верхня трикутна матриця\n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    if (i <= j)
                        Console.Write(A[i, j] + "\t");
                    else
                        Console.Write("0\t");
                }
            }
            Console.ReadLine();
        }
    }
}
