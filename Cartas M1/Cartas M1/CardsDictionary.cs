using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class CardsDictionary
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Attack { get; set; }
    }
}
