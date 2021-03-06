using System;

namespace Lab.rob1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано чотири точки, що є вершинами чотирикутника.З’ясувати, чи можуть вони бути вершинами паралелограма.
            Console.Write("x1=");
            int x1 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("x3=");
            int x3 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("y3=");
            int y3 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("x4=");
            int x4 =
        Convert.ToInt32(Console.ReadLine());
            Console.Write("y4=");
            int y4 =
        Convert.ToInt32(Console.ReadLine());
            if ((x2 - x1) + (x4 - x1) == (x3 - x1) && (y2 - y1) + (y4 - y1) == (y3 - y1))
            {
                Console.WriteLine("Координати є вершинами паралелограму");
            }
            else
            {
                Console.WriteLine("Координати не є вершинами паралелограму");
            }
            Console.ReadLine();
        }
    }
}