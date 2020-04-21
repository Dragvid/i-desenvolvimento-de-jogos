using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {

        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (base.Age > 15)
                {
                    throw new ArgumentException("Child's age must be below 15");
                }
                base.Age = value;
            }
        }
        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Don't you have a name?");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("That name is too short");
                }
                base.Name = value;
            }
        }
    }
}
