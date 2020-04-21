using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        private string name;
        private int age;
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",this.Name,this.Age));
            return stringBuilder.ToString();
        }
        public Person(string name, int age)
        {

            this.Name = name;

            this.Age = age;

        }
        public virtual string Name
        {

            get
            {
                return name;
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Dont you have a name?");
                }
                else if (value.Length < 3) {
                    throw new ArgumentException("That name is too short?");
                }
                else
                {
                    name = value;
                }
            }
        }

        public virtual int Age
        {
            get

            {
                return this.age;
            }
            set

            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
    }
}