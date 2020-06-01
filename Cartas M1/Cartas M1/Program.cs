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
            List<Character> CharacterCol = new List<Character>();
            CharacterCol.Add(new Character(100, 10, 19, 12, "joao teste", "mata tudo"));
            CharacterCol.Add(new Character(101, 10, 19, 12, "joao teste2", "mata tudo 2 vezes"));

            List<Scenery> SceneryCol = new List<Scenery>();
            SceneryCol.Add(new Scenery("Casino", "'Card' cards get a buff"));
            SceneryCol.Add(new Scenery("Castle", "'Knight'type cards get a buff"));

            List<Event> EventCol = new List<Event>();
            EventCol.Add(new Event("Blackjack", "draw one character, if it has 'card' on it's name or card text, draw another one. If the cards you drew have each 'Ace' and 'Figure' as their names, you can play them."));
            EventCol.Add(new Event("David", " aparece!"));
            List<Prop> PropCol = new List<Prop>();
            PropCol.Add(new Prop(1, "bom programa", "funciona sem dar erros"));
            using (StreamWriter writer = new StreamWriter("Collection.json"))
            {
                writer.WriteLine("{\n \"character\": [");
                
                foreach (Character character  in CharacterCol)
                {
                    if (character== CharacterCol.Last())
                    {
                        writer.WriteLine("{\n \"Name\":\"" + character.Name +
                        "\",\n \"Effect\": \"" + character.Effect +
                        "\",\n \"Attack\": \"" + character.Attack +
                        "\",\n \"Health\": \"" + character.Health +
                        "\",\n \"Speed\": \"" + character.Speed +
                        "\",\n \"Range\": \"" + character.Range +
                        "\"\n}");
                    }
                    else
                    {
                        writer.WriteLine("{\n \"Name\":\"" + character.Name +
                        "\",\n \"Effect\": \"" + character.Effect +
                        "\",\n \"Attack\": \"" + character.Attack +
                        "\",\n \"Health\": \"" + character.Health +
                        "\",\n \"Speed\": \"" + character.Speed +
                        "\",\n \"Range\": \"" + character.Range +
                        "\"\n},");
                    }
                }
                writer.WriteLine("],\n \"Scenery\": [");
                foreach (Scenery scenery in SceneryCol)
                {
                    if (scenery == SceneryCol.Last())
                    {
                        writer.WriteLine("{\n \"Name\":\"" + scenery.Name +
                        "\",\n \"Effect\": \"" + scenery.Effect +
                        "\"\n}");
                    }
                    else
                    {
                        writer.WriteLine("{\n \"Name\":\"" + scenery.Name +
                        "\",\n \"Effect\": \"" + scenery.Effect +
                        "\"\n},");
                    }
                }
                writer.WriteLine("],\n \"Prop\": [");
                foreach (Prop prop in PropCol)
                {
                    if (prop == PropCol.Last())
                    {
                        writer.WriteLine("{\n \"Name\":\"" + prop.Name +
                        "\",\n \"Effect\": \"" + prop.Effect +
                        "\"\n}");
                    }
                    else
                    {
                        writer.WriteLine("{\n \"Name\":\"" + prop.Name +
                        "\",\n \"Effect\": \"" + prop.Effect +
                        "\"\n},");
                    }
                }
                writer.WriteLine("],\n \"Event\": [");
                foreach (Event evento in EventCol)
                {
                    if (evento == EventCol.Last())
                    {
                        writer.WriteLine("{\n \"Name\":\"" + evento.Name +
                        "\",\n \"Effect\": \"" + evento.Effect +
                        "\"\n}");
                    }
                    else
                    {
                        writer.WriteLine("{\n \"Name\":\"" + evento.Name +
                        "\",\n \"Effect\": \"" + evento.Effect +
                        "\"\n},");
                    }
                }
                writer.WriteLine(" ]\n}");

            }
            string content = File.ReadAllText("Collection.json");

            Dictionary<string, List<CardsDictionary>> cards = JsonConvert.DeserializeObject<Dictionary<string, List<CardsDictionary>>>(content);
            foreach (KeyValuePair<string, List<CardsDictionary>> item in cards)
            {
                Console.WriteLine("Card type: "+item.Key);
                foreach (CardsDictionary crd in item.Value)
                {
                    Console.WriteLine("name: " + crd.Name);
                    Console.WriteLine("effect: " + crd.Effect);

                    if (item.Key== "character")
                    { 
                        Console.WriteLine("health: " + crd.Health);
                        Console.WriteLine("Atk: " + crd.Attack);
                        Console.WriteLine("Speed: " + crd.Speed);
                    }
                    if (item.Key == "Prop")
                    {
                        Console.WriteLine("health: " + crd.Health);
                    }
                    
                    Console.WriteLine("\n");
                }
        }
            Console.ReadLine();
        }
    }
}
