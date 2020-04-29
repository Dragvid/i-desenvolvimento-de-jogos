using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Character: Cards
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Attack{ get; set; }

        public Character(int health, int speed, int range, int attack) : base (Name,  effect)
        {
            Health = health;
            Speed = speed;
            Range = range;
            Attack = attack;
        }
    }
}
