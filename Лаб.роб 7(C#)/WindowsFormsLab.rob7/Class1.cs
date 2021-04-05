using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab.rob7
{
    class Class1
    {
        public int A;
        public int B;
        public int C;
        public int D;
        public int x;
        public int y;
        public int z;
        public int a;
        public int b;
        public int c;
        public int d;
        public int e;
        public int p;
        public int l;
        public int m;
        public int n;

        public Class1(int A, int B, int C, int D, int x, int y, int z, int a, int b, int c, int d, int e, int p, int l, int m, int n)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.x = x;
            this.y = y;
            this.z = z;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.p = p;
            this.l = l;
            this.m = m;
            this.n = n;

        }
        public Class1(Class1 class1)
        {
            this.A = class1.A;
            this.B = class1.B;
            this.C = class1.C;
            this.D = class1.D;
            this.x = class1.x;
            this.y = class1.y;
            this.z = class1.z;
            this.a = class1.a;
            this.b = class1.b;
            this.c = class1.c;
            this.d = class1.d;
            this.e = class1.e;
            this.p = class1.p;
            this.l = class1.l;
            this.m = class1.m;
            this.n = class1.n;
        }
        public string __str__()
        {
            return $"{A}x+{B}y+{C}z+{D}";
        }
        public string input_and_output_of_coefficients()
        {
            return $"A:{A},B:{B},C:{C},D:{D}";
        }
        
        public string point( )
        {
             
            if (x >= 0 && y >= 0 && z >= 0)
            {
                return"Дана точка належить площині";
            }
            else
            {
                return"Дана точка не належить площині";
            }
        
        }
        public string projection()
        {
            double t = -((A * x + B * y + C * z + D) / (Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2)));
            double x1 = A * t + x;
            double y1 = B * t + y;
            double z1 = C * t + z;
            return $"x1:{x1},y1:{y1},z1:{z1}";
        }
        public string crossing()
        {
            double k = -((A * x + B * y + C * z + D) / (A*l + B*m + C*n));
            double x2 = l * k + x;
            double y2 = m * k + y;
            double z2 = n * k + z;
            return $"x2:{x2},y2:{y2},z2:{z2}";
        }
        public string parallel()
        {
            if (a / d == b / e)
            {
                return"Площина паралельна іншій площині";
            }
            else
            {
                return"Площина не паралельна іншій площині";
            }

        }
        
    }

}
