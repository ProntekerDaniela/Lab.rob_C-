using System;

namespace Lab.rob2_3_
{
    class Program
    {
        private static int m;
        static void Main(string[] args)
        {
            //Перевірити справедливість рівності при заданій точності
            Console.Write("eps=");
            double eps =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("x=");
            double x =
        Convert.ToInt32(Console.ReadLine());
            double s = 0;
            double n = 1;
            double b = (1 - (4 * Math.Pow(x, 2)) / (Math.Pow(2 * n - 1, 2) * Math.Pow(Math.PI, 2)));
            while (b >= eps)
            {
                b = (1 - (4 * Math.Pow(x, 2)) / (Math.Pow(2 * n - 1, 2) * Math.Pow(Math.PI, 2)));
                if (-1 < m && m < 1)
                {
                    Console.WriteLine("Рівність справедлива");
                }
                else
                {
                    Console.WriteLine("Рівність не справедлива");
                }
            }
        }
    }
}