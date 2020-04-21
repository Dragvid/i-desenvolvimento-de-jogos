using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    static class converter
    {
        int temperatura;
        string tipotemp;
        public converter(string t, string tt) {
            temperatura = Convert.ToInt32(t);
            tipotemp = tt;
            
        }
        public static double farenheight(string) {
            double f;
            return f = temperatura * 9 / 5 + 32;
        }
        public static double celcius()
        {
            double c;
            return c = (temperatura - 32) * 5 / 9;
        }
    }
}
