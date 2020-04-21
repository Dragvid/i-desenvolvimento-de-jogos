using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            
            //string[] valores = new string[10];
            valor = Console.ReadLine();
            string[] valores = valor.Split(' ');
           
            switch valores[1]:
                case valores[1] == "f" || valores[1] == "F")
            {
                converter.farenheight();
            }
            if (valores[1] == "c" || valores[1] == "C")
            {
                converter.celcius();
            }
        }
    }
}
