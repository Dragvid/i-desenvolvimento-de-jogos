using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nc=0;
            carta[] baralho = new carta[52];
            for (int i = 0; i < 4; i++) {
                for (int y = 0; y < 13; y++)
                {

                    carta();
                    nc++;
                }
            }
        }
    }
}
