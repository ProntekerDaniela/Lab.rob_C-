using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab9_3
{
    /*Реалізувати клас, що представляє квадратне рівняння і містить опис індексатора,
який дозволяє одержувати перший та другий розв’язки (якщо вони існують).
Передбачити методи введення/виведення, перевірки існування розв’язків.*/
    class Equation
    {
        public int A;
        public int B;
        public int C;
        public double x1;
        public double x2;

        public Equation(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            
        }

        public string __str__()
        {
            return $"{A}x+{B}y+{C}";
        }
        public string input_and_output_of_coefficients()
        {
            return $"A:{A},B:{B},C:{C}";
        }

        public string equation()
        {
            double D = B *B - 4 * A * C;
            this.x1 = (-1 * this.B + Math.Sqrt(D)) / 2 * this.C;
            this.x2 = (-1 * this.B - Math.Sqrt(D)) / 2 * this.C;
            return $"x1:{x1},x2:{x2}";
        }

        public double X1
        {
            get { return this.x1; }
        }

        public double X2
        {
            get { return this.x2; }
      
        }
        public string discriminant()
        {
            double D = B * B - 4 * A * C;
            if (D >= 0 )
            {
                return "Квадратне рівняння має розв'язок";
            }
            else
            {
                return "Квадратне рівняння розв'язку немає";
            }
        }



    }
}
