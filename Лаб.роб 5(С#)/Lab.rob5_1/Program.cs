using System;


namespace Lab.rob5_1
{
    class Program
    {
        static void s(int k, int b=2, int c=7)
        {
                double x1; double x2;
                double d = Math.Pow(b, 2) - 4 * k * c;
                if (d < 0)
                {
                    Console.WriteLine("Квадратне рівняння не має коренів");
                }
                else
                {
                    if (d == 0) //квадратне рівняння має два однакові корені
                    {
                        x1 = -b / (2 * k);
                        x2 = x1;
                    }
                    else //рівняння має два різні корені
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * k);
                        x2 = (-b - Math.Sqrt(d)) / (2 * k);
                    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
                }
                } 
                static void Main(string[] args)
                {
                    Console.Write("a= ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    int b = int.Parse(Console.ReadLine());
                    s(a);
                    s(b);
                    Console.WriteLine("a={0}", a);
                    Console.WriteLine("b={0}", b);

                }
              
                
                
         
        
        
        
        }

    
    
    
    }

 


}
