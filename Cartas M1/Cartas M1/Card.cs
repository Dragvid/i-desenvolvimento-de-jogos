using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    public abstract class Card
    {
        public string Name { get; set; }
        public string Effect { get; set; }

        /*public int Health { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Attack { get; set; }*/
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Effect: {1}", this.Name, this.Effect));
            return stringBuilder.ToString();
        }
        public Card(string name, string effect) {
            this.Name = name;
            this.Effect = effect;
            /*Health = health;
            Speed = speed;
            Range = range;
            Attack = attack;*/
        }

    }
}
