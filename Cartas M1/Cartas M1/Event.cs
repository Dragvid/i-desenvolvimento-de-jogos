﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class Event : Card
    {
        public string Name;
        public string Effect;
        public Event(string name, string effect) : base(name, effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
