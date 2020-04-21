using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCounter
{
    static class BeerCounter
    {
        public static int BeerInStock;
        public static int BuyBeer;
        public static int DrinkBeer;
        public static int BeersDrank;
        public static void BB() {
            BeerInStock -=  BuyBeer;
        }
        public static void DB()
        {
            BeerInStock -= DrinkBeer;
            BeersDrank += DrinkBeer;
        }
    }
}
