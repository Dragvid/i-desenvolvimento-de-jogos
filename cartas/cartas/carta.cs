using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas
{
    class carta
    {
        int num;
        naipes naipe;
        public carta(int n, int na) {
            num = n;
            if (na == 1)
            {
                naipe = naipes.ouro;
            }
            else if (na == 2) {
                naipe = naipes.paus;
            }
            else if (na == 3)
            {
                naipe = naipes.espada;
            }
            else if (na == 4)
            {
                naipe = naipes.copa;
            }
        }
    }
}
