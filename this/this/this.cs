using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @this
{
    public class Class1
    {
       public static double circle(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public static double triangle(double a, double b, double c)
        {
            double p;
            double s;
            if (a == b )
            {
              

                return s = (a *c) *0.5;
            }
            else
              p = (a+b +c) *0.5;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

    }
}
