using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_idj
{
    class aluno
    {
        int ano, numero;
        string nome, curso;
        public aluno(int a,int n,string n2,string c)
        {
            ano = a;
            numero = n;
            nome = n2;
            curso = c;
        }
        public string Ov() {
            string ov = nome+" "+numero+", "+ano+"º  ano "+curso;
            return ov;
        }
        public bool ordem(aluno a)
        {
            if (this.numero > a.numero) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
