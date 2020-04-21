using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Math
{
    class MathUtil
    {
        public static double sum(int s1, int s2) {
            double r = s1+s2;
            return r;
        }
        public static double subtract(int s1, int s2)
        {
            double r = s1 - s2;
            return r;
        }
        public static double multiply(int s1, int s2)
        {
            double r = s1 * s2;
            return r;
        }
        public static double divide(int s1, int s2)
        {
            double r = s1 / s2;
            return r;
        }
        public static double percentage(int s1, int s2)
        {
            double r = (s1 / s2)*100;
            return r;
        }
    }
}
