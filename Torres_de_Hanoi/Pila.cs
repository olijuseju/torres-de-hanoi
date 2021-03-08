using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top*/
        public Disco Top { get; set; }

        /* TODO: Elegir tipo de Elementos*/
        public List<Disco> Elementos { get; set; }


        /* TODO: Implementar métodos */
        public Pila(int size)
        {
            Size = size;
            Top = new Disco(0);
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            /* if(Elementos.Count < Size){
               boolean existe = revisarLista(d); 
                 if(existe==false){*/
            Elementos.Add(d);
            Top = d;
            /*}

        }*/
        }


        public Disco pop()
        {
            Disco res = Top;
            Elementos.Remove(Top);

            if (this.isEmpty())
            {
                Top = new Disco(0);
            }
            else
            {
                Top = Elementos[Elementos.Count - 1];
            }

            return res;

        }

        public bool isEmpty()
        {

            if (Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
