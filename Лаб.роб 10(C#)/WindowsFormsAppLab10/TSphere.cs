using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab10
{
    class TSphere : TCircle
    {
        public double radius_1;
    

        public TSphere(double radius_1) : base()
        {
            this.radius_1 = 0;
 
           
        }
       
        public double surface_of_the_ball()
        {
            double a = 3.14;
            return 4 * a * Math.Pow(radius_1, 2);

        }

        

    }
}
