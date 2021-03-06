using System;

namespace Lab.rob2_4_
{
    class Program
    {
        private static int i;
        private static int f;
        private static int ff;
        private static int fff;
        private static int ffff;
        static void Main(string[] args)
        {
           
            Console.Write("n=");
            double n =
        Convert.ToInt32(Console.ReadLine());
            i = 4;
            f = 0;
            ff = 7;
            fff = 7;
            ffff = 7;
            if (n >= 4)
            {
                while (i <= n)
                {
                    double fffff = ((ffff + 4 * fff) * (1 + fff) + ff / Math.Sqrt(f)) + f;
                    f = ff;
                    ff = fff;
                    fff = ffff;
                    ffff = (int)fffff;
                    i += 1;
                else
                    {
                        double d = fffff;
                        Console.WriteLine("Результат={0}", d);
                    }
                }
            }
            else if (0 < n && n <= 3)
            {
                Console.WriteLine("Результат = 7");
            }
            else if (n == 0)
            {
                Console.WriteLine("Результат = 0");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
