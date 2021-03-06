using System;

namespace Lab.rob1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано три дійсних числа:a,b,c.Знайти max(a,b)+(max(a,b)+min(b,c))^2
            Console.Write("a=");
            int a =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c =
        Convert.ToInt32(Console.ReadLine());
            int d = Math.Max(a, b);
            int i = Math.Min(b, c);
            int p = (int)(d + Math.Pow(d + i, 2));
            Console.WriteLine("Сума: {0}", p);
            Console.ReadLine();
        }
    }
}