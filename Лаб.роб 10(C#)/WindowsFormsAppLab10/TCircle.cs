using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab10
{
    class TCircle
    {
        public double radius;

      
        public TCircle(double radius)
        {
            this.radius = radius;
        

        }

        public TCircle(TCircle tCircle)
        {
            this.radius = tCircle.radius;
         
        }

        public TCircle()
        {
            this.radius = 0;
 
        }


        public string input_and_output()
        {
            return $"Радіус першого кола:{radius}";
        }
        public double area()
        {
            double a = 3.14;
            return 2 * a * radius;

        }
        public double length_1()
        {
            double a = 3.14;
            double l_1 = a * Math.Pow(radius, 2);
            return l_1;

        }
        public double sector()
        {
            double a = 3.14;
            double l_1 = a * Math.Pow(radius, 2);
            double s_2 = (l_1 * radius)/2;
            return s_2;
           
        }
        public bool comparison_radius(double radius_2)
        {
                return radius > radius_2;
        }
        public bool comparison_length(double radius_2)
        {

            double a = 3.14;
            double l_1 = a * Math.Pow(radius, 2);
            double l_2 = a * Math.Pow(radius_2, 2);
            return l_1 > l_2;
        }

        public string radius_dod(TCircle otherTCircle)
        {
            return $"{this.radius + otherTCircle.radius}";
        }
        public string radius_vid(TCircle otherTCircle)
        {
            return $"{this.radius - otherTCircle.radius}";
        }
        public string radius_number(TCircle otherTCircle)
        {
            return $"{this.radius * otherTCircle.radius}";
        }
    
    
    }
}
