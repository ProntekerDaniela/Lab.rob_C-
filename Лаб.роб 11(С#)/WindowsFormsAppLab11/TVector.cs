using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab11
{
    class TVector
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public virtual string input_and_output()
        {
            return $"X:{x1},Y:{y1},X:{x2},Y:{y2}";
        }
        public virtual string vector_length()
        {
            double d = Math.Sqrt(Math.Pow(this.x1, 2) + Math.Pow(this.y1, 2));
            return $"Довжина вектора = {d}";
        }

        public virtual string perpendicularity()
        {
            int a = (x1 * x2 + y1 * y2);
            if (a == 0)
            {
                return "Вектори перпендикулярні ";
            }
            else
            {
                return "Вектори не перпендикулярні ";
            }
        }
        public virtual bool parallel()
        {
            return x1 / x2 == y1 / y2;
            
        }


    
    }
}
