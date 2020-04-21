using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[100];
            string ip = "";
            int i = 0;
            string[] cbeers = new string[10];
            while (ip != "End")
            {
                ip = Console.ReadLine();
                cbeers = ip.Split(' ');
                //animais[i].Animal(cbeers[0],cbeers[1]);
                i++;
            }
            //animais[i].breed;
        }
    }
}
