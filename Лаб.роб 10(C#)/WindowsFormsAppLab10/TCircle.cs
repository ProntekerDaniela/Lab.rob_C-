using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab10
{
    class TCircle
    {
        public double radius_1;
        public double radius_2;
      
        public TCircle(double radius_1,double radius_2)
        {
            this.radius_1 = radius_1;
            this.radius_2 = radius_2;

        }

        public TCircle(TCircle tCircle)
        {
            this.radius_1 = tCircle.radius_1;
            this.radius_2 = tCircle.radius_2;

        }

        public TCircle()
        {
            this.radius_1 = 0;
            this.radius_2 = 0;
        }


        public string input_and_output()
        {
            return $"Радіус першого кола:{radius_1},Радіус другого кола:{radius_2}";
        }
        public double area()
        {
            double a = 3.14;
            double s_1 = 2 * a * radius_1;
            return s_1;

        }
        public double length_1()
        { 
            double a = 3.14;
            double l_1 = a * Math.Pow(radius_1, 2) ;
            return l_1;
            
        }
        public double length_2()
        {
            double a = 3.14;
            double l_2 = a * Math.Pow(radius_1, 2);
            return l_2;

        }
        public double sector()
        {
            double a = 3.14;
            double l_1 = a * Math.Pow(radius_1, 2);
            double s_2 = (l_1 * radius_1)/2;
            return s_2;
           
        }
        public string comparison_radius()
        {
            if (radius_1>radius_2)
            {
                return "Радіус першого кола більший за радіус другого кола";
            }
            else
            {
                return "Радіус другого кола більший за радіус першого кола";
            }
        }
        public string comparison_length()
        {

            double a = 3.14;
            double l_1 = a * Math.Pow(radius_1, 2);
            double l_2 = a * Math.Pow(radius_2, 2);
            if (l_1 > l_2)
            {
                return "Довжина першого кола більша за довжину другого кола";
            }
            else
            {
                return "Довжина другого кола більша за довжину  першого кола";
            }
        }

        public string radius_dod(TCircle otherTCircle)
        {
            return $"{this.radius_1 + otherTCircle.radius_1}";
        }
        public string radius_vid(TCircle otherTCircle)
        {
            return $"{this.radius_1 - otherTCircle.radius_1}";
        }
        public string radius_number(TCircle otherTCircle)
        {
            return $"{this.radius_1 * otherTCircle.radius_1}";
        }
    
    
    }
}
