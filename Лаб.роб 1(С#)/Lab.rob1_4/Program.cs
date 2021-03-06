using System;

namespace Lab.rob1_4_
{
    class Program
    {
        private static object math;
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x =
        Convert.ToInt32(Console.ReadLine());
            double t = 0;
            double y = 0;
            if (x >= 2)
            {
                t = Convert.ToDouble(Math.Log(x));
                Console.WriteLine("t={0}", t);
            }
            else
            {
                t = Convert.ToDouble(Math.Cos(x));
                Console.WriteLine("t={0}", t);
            }
            if (t >= 0)
            {
                y = Convert.ToDouble(Math.Pow(Math.E, t) * Math.Sin(t));
                Console.WriteLine("y={0}", y);
            }
            else
            {
                y = Convert.ToDouble(Math.Pow(Math.E, t) * Math.Cos(t));
                Console.WriteLine("y={0}", y);
            }
        }
    }
}
