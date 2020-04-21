using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectângulo_classe
{
    class rectangulo
    {
        private int largura, comprimento;
        public rectangulo(int l,int c) {
            this.largura = l;
            this.comprimento = c;
        }
        public int Largura
        {
            get {
                return largura;
            }
            set
            {
                if (value < 20 && value > 1) {
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
                if (value < 20 && value > 1)
                {
                    comprimento = value;
                }
            }
        }
        public int Perimetro() {
            int perimetro;
            perimetro = (Largura * 2) + (Comprimento * 2);
            return perimetro;
        }
        public int Area()
        {
            int area;
            area = Largura * Comprimento;
            return area;
        }
        public bool Quadrado() {
            bool quadrado = false;
            if (Comprimento == Largura) {
                quadrado = true;
            }
            return quadrado;
        }
    }
}
