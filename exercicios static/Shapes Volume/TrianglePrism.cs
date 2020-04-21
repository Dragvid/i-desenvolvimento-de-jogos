using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Volume
{
    class TrianglePrism
    {
        public static int resul(int b,int h, int l) {
            int v = 0, ab= (b*l)/2;
            v = ab * h;
            return v;
        }
    }
}
