using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab12
{
    class Number
    {
        int n;
        public Number(int n)
        {
            this.n = n;
        }
        public int [] number()
        {
            int[] arr = new int[n];
            Random ran = new Random(DateTime.Now.Millisecond);
           
            for (int i = 0; i < n; i++)
            {
               arr[i] = ran.Next(-100, 100);

            }
            return arr;

        }

        public int Sum()
        {
            int[] arr = new int[n];
            Random ran = new Random(DateTime.Now.Millisecond);
            int sum = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    sum = sum + arr[i];


            }
            return sum;
        
        }

        public int Vid()
        {
            int[] arr = new int[n];
            Random ran = new Random(DateTime.Now.Millisecond);
            int vid = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    vid = vid - arr[i];
            }
            return vid;

        }

    }
}