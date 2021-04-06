using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab11
{
    class R3 : TVector
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }

        public R3(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            x1 = x1;
            y1 = y1;
            x2 = x2;
            y2 = y2;
            x3 = x3;
            y3 = y3;
        }
        public override string input_and_output()
        {
            return $"X1:{x1},Y1:{y1};X2{x2},Y2:{y2};X3{x3},Y3:{y3};  X1:{x1},Y1:{y1};X2{x2},Y2:{y2};X3{x3},Y3:{y3};  X1:{x1},Y1:{y1};X2{x2},Y2:{y2};X3{x3},Y3:{y3};  X1:{x1},Y1:{y1};X2{x2},Y2:{y2};X3{x3},Y3:{y3};";
        }

        public  string perpendicularity()
        {
            int a = (x1 * x2 * x3 + y1 * y2 * y3 );
            if (a == 0)
            {
                double d = Math.Sqrt(Math.Pow(this.x1, 2) + Math.Pow(this.y1, 2) + Math.Pow(this.x2, 2) + Math.Pow(this.y2, 2) + Math.Pow(this.x3, 2) + Math.Pow(this.y3, 2));
                return $"Довжина вектора = {d}";
            }
            else
            {
                return "Вектори не перпендикулярні ";
            }
        }

    }
}
