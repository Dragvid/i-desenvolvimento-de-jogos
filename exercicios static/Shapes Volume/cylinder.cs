using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Volume
{
    class cylinder
    {
        public static double resul(int r, int h)
        {
            double ab = 3.14*Math.Pow(r,2), v = 0;
            v = ab * h;
            return v;
        }
    }
}
