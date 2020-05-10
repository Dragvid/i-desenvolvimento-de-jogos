using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Character: Card
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Attack{ get; set; }
        //private string name, effect;
        public Character(int health, int speed, int range, int attack, string name, string effect) :base(name, effect)
        {
            Health = health;
            Speed = speed;
            Range = range;
            Attack = attack;
            this.Name = name;
            this.Effect = effect;
        }
    }
}
