using System;

namespace Lab.rob3_1
{
    class Program
    {
        private static int k;

        public static double FirstPositive { get; private set; }

        static void Main(string[] args)
        {
            //Знайти кількість від’ємних елементів у векторі, які розташовані після першого додатного.
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {

                if ( arr[i] > 0)
                {
                    FirstPositive = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (FirstPositive == 0)
                {
                    Console.Write("Додатнiх елементiв в масивi нема");
                }
                else
                {
                    k = 0;

                    for (i = 0; i < n; i++)
                        if (arr[i]==FirstPositive) ;
                         k += 1;
                    

                }
            }
            Console.Write("Кiлькicть вiд'ємних елементiв пiсля першого додатнього = {0}",k);


        }



    }
}
