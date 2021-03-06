using System;

namespace Lab.rob2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Побудувати алгоритм для знаходження порядку цього числа.
            Console.Write("n=");
            double n =
        Convert.ToInt32(Console.ReadLine());
            double b = Math.Log10(n);
            Console.WriteLine("Порядок числа: {0}", b);
            Console.ReadLine();
        }
    }
}