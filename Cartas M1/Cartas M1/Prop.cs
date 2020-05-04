using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Prop : Card
    {
        private int Health { get; set; }
        public Prop(int health, string name, string effect) : base(name, effect)
        {
            Health = health;
        }
    }
}
