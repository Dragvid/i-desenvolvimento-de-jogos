using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_idj
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new aluno(1,32,"joao","djd");
            var aluno2 = new aluno(1, 31, "sonia", "djd");
            Console.WriteLine(aluno1.Ov());
            Console.WriteLine(aluno2.Ov());
            Console.WriteLine(aluno2.ordem(aluno1));
            Console.ReadLine();
        }
    }
}
