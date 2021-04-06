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
        

        public Class1(int A, int B, int C, int D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
           
        }
        public Class1(Class1 class1)
        {
            this.A = class1.A;
            this.B = class1.B;
            this.C = class1.C;
            this.D = class1.D;
            
        }
        public string __str__()
        {
            return $"{A}x+{B}y+{C}z+{D}";
        }
        public string input_and_output_of_coefficients()
        {
            return $"A:{A},B:{B},C:{C},D:{D}";
        }
        
        public bool point(int x, int y, int z )
        {
            return (x >= 0) && (y >= 0) && (z >= 0);
        }
        public string projection(int x, int y, int z)
        {
            double t = -((A * x + B * y + C * z + D) / (Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2)));
            double x1 = A * t + x;
            double y1 = B * t + y;
            double z1 = C * t + z;
            return $"x1:{x1},y1:{y1},z1:{z1}";
        }
        public string crossing(int x, int y, int z, int l, int m, int n)
        {
            double k = -((A * x + B * y + C * z + D) / (A*l + B*m + C*n));
            double x2 = l * k + x;
            double y2 = m * k + y;
            double z2 = n * k + z;
            return $"x2:{x2},y2:{y2},z2:{z2}";
        }
        public bool parallel(int a, int b, int d, int e)
        {  
            return a / d == b / e;
        }
        
    }

}
