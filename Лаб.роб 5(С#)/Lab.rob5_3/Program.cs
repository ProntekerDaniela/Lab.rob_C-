using System;

namespace Lab.rob5_3
{
    class Program
    {
        
            /*Дано послідовність натуральних числень 
            Використовуючипідпрограму, яка дозволяє встановити, чи є послідовність із чотирьох чисел 
            арифметичною прогресією, знайти кількість послідовно розміщених четвірок чисел,які утворюють арифметичну прогресію.*/
            static int x(int i)
            {
                if (i == 0)
                {
                    return 0;
                }
                else if (i == 1)
                {
                    return 7;
                }
                else
                {
                    return (x(i - 1) * (1 + x(i - 2)));
                }
            }
            static void Main(string[] args)
            {
                Console.Write("n= ");
                int n = int.Parse(Console.ReadLine());
                n = x(n);
                Console.WriteLine("n={0}", n);
            }



        




    }




}
