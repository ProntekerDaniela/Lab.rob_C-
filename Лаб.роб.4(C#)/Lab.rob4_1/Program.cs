using System;

namespace Lab.rob4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Визначити кількість від’ємних елементів матриці з обома парними індексами.
            double d = 0;
            Console.Write("Введiть кiлькiсть рядкiв = ");
            int m = int.Parse(Console.ReadLine()); ;
            Console.Write("Введiть кiлькiсть стовпцiв = ");
            int n = int.Parse(Console.ReadLine()); ;
            int[,] mas = new int[m, n];
            Random rnd = new Random();
            Console.WriteLine("Матриця випадкових чисел:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(-100, 100);
                    Console.Write(mas[i, j] + "\t");
                    Console.WriteLine();
                    if (i % 2 == 0 && j % 2 == 0)
                    {

                    if (mas[i, j] < 0)

                            d += 1;
                        
                    }
                }
            }
            Console.WriteLine("Кiлькiсть вiд`ємних елементiв матрицi з обома парними iндексами = {0}", d);
            Console.ReadKey();
        }
    }
}
