using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paralelepipedo
{
    class paralelepipedo
    {
        private int altura, largura, comprimento;
        public paralelepipedo() {
            altura = 0;
            largura = 0;
            comprimento = 0;
        }
        public paralelepipedo(int valor) {
            altura = valor;
            largura = valor;
            comprimento = valor;
        }
        public paralelepipedo(int a,int l, int c)
        {
            altura = a;
            largura = l;
            comprimento = c;
        }
        public int Largura
        {
            get
            {
                return largura;
            }
            set
            {
                if (value < 0)
                {
                    largura = value;
                }
            }
        }
        public int Comprimento
        {
            get
            {
                return comprimento;
            }
            set
            {
                if (value < 0)
                {
                    comprimento = 0;
                }
            }
        }
        public int Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value < 0)
                {
                    altura = 0;
                }
            }
        }
        public int Volume() {
            int v;
            v = altura * largura * comprimento;
            return v;
        }
        public int AreaT() {
            int at;
            at = 2 * altura * largura + 2 * altura * comprimento + 2 * largura * comprimento;
            return at;
        }
        public bool IsACube() {
            bool iac=false;
            if (altura == largura && largura == comprimento)
                iac = true;
            return iac;
        }
        public bool Is3d()
        {
            bool i3d = false;
            if (altura != 0 && largura !=0 && comprimento!=0)
                i3d = true;
            return i3d;
        }
    }
}
