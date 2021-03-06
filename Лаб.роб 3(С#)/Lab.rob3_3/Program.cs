using System;

namespace Lab.rob3_2
{
    class Program
    {
        private static int i;

        static void Main(string[] args)

        {
            //Знайти вектор
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr_1 = new double[n];
            double[] arr_2 = new double[n];
            double[] arr_3 = new double[n];

            for (int i = 0; i < arr_1.Length && i < arr_2.Length && i < arr_3.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                arr_1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("b[{0}]=", i);
                arr_2[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("c[{0}]=", i);
                arr_3[i] = Convert.ToDouble(Console.ReadLine());
            }
            double [] d = new double [n];
            for (int i = 0;i<n;i++)
            {
               d [i] = arr_1[i] - (3 * arr_2[i]) + (2 * arr_3[i]);
                Console.WriteLine("d[{0}]={1};", i, d[i]);
            }
           
        }
    }
}
