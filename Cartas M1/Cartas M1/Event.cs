using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Event : Card
    {
        private string Name;
        private string Effect;
        public Event(string name, string effect) : base(name, effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
