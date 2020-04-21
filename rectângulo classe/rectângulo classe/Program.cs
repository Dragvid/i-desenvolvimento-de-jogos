using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectângulo_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangulo r=new rectangulo(20,10);
            /*r.Comprimento = 10;
            r.Largura = 10;*/
            Console.WriteLine(r.Comprimento);
            Console.WriteLine(r.Largura);
            Console.WriteLine(r.Quadrado());
            Console.WriteLine(r.Perimetro());
            Console.WriteLine(r.Area());
            Console.ReadLine();
        }
    }
}
