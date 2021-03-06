using System;


namespace Lab.rob3_2
{
    class Program
    {
        private static int k;
        private static int d;
        private static int i;
        static void Main(string[] arg)
        {
            //Побудувати масив А=(ai), елементи якого задаються формулою.Обчислити суму додатних елементів масиву А і вивести її на форму.
            Console.Write("Введiть кiлькiсть елементiв:");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n];
            d = 2;
            i = 1;
            int NewElement = d / i;
            for (int i=0;i<n;i++)
            {
               k = ((int)(Math.Pow((-1),i) * i));
                int add = d * k;
               NewElement += add;
                arr[i] = NewElement;
 
            }
            k = 0;
            for (int i= 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    k = k + arr[i];
                }
                else
                {
                    k = k;
                }
            }
           Console.Write("Сума додатнiх елементiв масиву = {0}",k);

        }
    }
}
