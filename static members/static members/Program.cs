using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_members
{
    class Program
    {
        static void Main(string[] args)
        {
            Ppl p = new Ppl();
            p.nome = "joao";
            Ppl p1 = new Ppl();
            p1.nome = "antonio";
            Ppl p2 = new Ppl();
            p2.nome = "joao";

            Console.ReadLine();
        }
    }
}
