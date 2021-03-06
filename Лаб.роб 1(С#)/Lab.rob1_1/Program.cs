using System;

namespace Lab.rob1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обчислити площу та периметр рівнобічної трапеції, для якої задано довжини основ та висоту.
            Console.Write("a=");
            double a =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            double b =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            double c =
        Convert.ToInt32(Console.ReadLine());
            double s = ((a + b) / 2) * c;
            double d = (b - a) / 2;
            double i = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(c, 2));
            double p = i + i + a + b;
            Console.WriteLine("Площа: {0}", s);
            Console.WriteLine("Периметр: {0}", p);
            Console.ReadLine();
        }
    }
}