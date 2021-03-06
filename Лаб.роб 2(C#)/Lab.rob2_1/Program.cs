using System;

namespace Lab.rob2_1_
{
    class Program
    {
        private static double m;
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            int n =
        Convert.ToInt32(Console.ReadLine());
            double s = 0;
            double i = 0;
            while (n >= i)
            {
                double k = (2 * n) / (a + n);
                m = m + k;
                i += 1;
                Console.WriteLine("Сума: {0}", m);
                Console.ReadLine();
            }
        }
    }
}