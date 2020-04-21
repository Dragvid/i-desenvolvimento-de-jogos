using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_members
{
    class Ppl
    {
        public string nome;
        public static List<Ppl> people = new List<Ppl> { };
        public static HashSet<string> nomes = new HashSet<string>;
        public Ppl(string n)
        {
            nome = n;
        }
    }
}
