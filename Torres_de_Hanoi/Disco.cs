using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        public int Valor;


        public Disco(int Valor)
        {
            this.Valor = Valor;
        }

        public int getValor()
        {
            return Valor;
        }

        public void setValor(int Valor)
        {
            this.Valor = Valor;
        }

    }
}
