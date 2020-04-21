using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip="";
            string[] cbeers = new string[10];
            while (ip!= "End")
            {
                ip = Console.ReadLine();
                cbeers=ip.Split(' ');
                BeerCounter.BuyBeer = Int32.Parse(cbeers[0]);
                BeerCounter.DrinkBeer = Int32.Parse(cbeers[1]);
                BeerCounter.BB();
                BeerCounter.DB();
                Console.WriteLine("Stock and beers drank: " + BeerCounter.BeerInStock +" "+ BeerCounter.BeersDrank);
            }
            Console.ReadLine();
        }
    }
}
