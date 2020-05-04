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

            Character c = new Character(100, 10, 19, 12, "joao", "mata tudo");

            string content = File.ReadAllText("Cartas.json");
            //CardsDictionary cd = new CardsDictionary(content);
            Dictionary<string, List<Card>> cards = JsonConvert.DeserializeObject<Dictionary<string, List<Card>>>(content);
            /*foreach (KeyValuePair<string, List<Cards>> item in cards)
            {
                Console.WriteLine("Card type: "+item.Key);
                foreach (Cards crd in item.Value)
                {
                    Console.WriteLine("name: "+crd.Name);
                    
                    if(item.Key== "character")
                    {
                        Console.WriteLine("health: " + crd.Health);
                        Console.WriteLine("Atk: " + crd.Attack);
                        Console.WriteLine("Speed: " + crd.Spe ed);
                    }
                    if (item.Key == "Prop")
                    {
                        Console.WriteLine("health: " + crd.Health);
                    }
                    Console.WriteLine("effect: " + crd.Effect);
                    Console.WriteLine("\n");
                }
        }*/
            Console.ReadLine();
        }
    }
}
