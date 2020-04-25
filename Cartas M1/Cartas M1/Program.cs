using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("Cartas.json");
            Dictionary<string, List<Cards>> cards = JsonConvert.DeserializeObject<Dictionary<string, List<Cards>>>(content);
            foreach (KeyValuePair<string, List<Cards>> item in cards)
            {
                Console.WriteLine("Card type: "+item.Key);
                foreach (Cards crd in item.Value)
                {
                    Console.WriteLine("name: "+crd.Name);
                    
                    if(item.Key== "character")
                    {
                        Console.WriteLine("health: " + crd.health);
                        Console.WriteLine("Atk: " + crd.atack);
                        Console.WriteLine("Speed: " + crd.speed);
                    }
                    if (item.Key == "Prop")
                    {
                        Console.WriteLine("health: " + crd.health);
                    }
                    Console.WriteLine("effect: " + crd.effect);
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
