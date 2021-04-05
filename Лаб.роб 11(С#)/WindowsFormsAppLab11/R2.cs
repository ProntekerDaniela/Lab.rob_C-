using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab11
{
    class R2 : TVector
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
       

        public R2(int x1, int y1, int x2, int y2)
        {
            x1 = x1;
            y1 = y1;
            x2 = x2;
            y2 = y2;
        }

        public override string input_and_output()
        {
            return $"X1:{x1},Y1:{y1};X2{x2},Y2:{y2};  X1:{x1},Y1:{y1};X2{x2},Y2:{y2};  X1:{x1},Y1:{y1};X2{x2},Y2:{y2};";
        }
        public override string parallel()
        {
            if (x1 / x2 == y1 / y2 )
            {
                double d = Math.Sqrt(Math.Pow(this.x1, 2) + Math.Pow(this.y1, 2) + Math.Pow(this.x2, 2) + Math.Pow(this.y2, 2));
                return $"Довжина вектора = {d}";
            }
            else
            {
                return "Вектори не паралельні ";
            }
        }


    }
}
