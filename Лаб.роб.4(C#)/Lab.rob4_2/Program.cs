using System;

namespace Lab.rob4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Побудувати прямокутну матрицю А, елементи якої задаються формулою.Обчислити суму елементів матриці А, сума індексів яких непарна.
            Console.Write("Кiлькiсть рядкiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв = ");
            int m = Convert.ToInt32(Console.ReadLine());

            double[,] arr = new double[n, m];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int c = i + 1;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int z = j + 1;
                    arr[i, j] = 1.0 / (c + z);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,5:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }

            double s = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int c = i + 1;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int z = j + 1;
                    if ((c + z) % 2 != 0)
                    {
                        s += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Cума елементiв матрицi А, сума iндексiв яких непарна = {0}", s);
        }
    }



}   

