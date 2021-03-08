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
        public Pila(List<Disco> lista)
        {
            Elementos = lista;
            Top = lista.Last();
            Size = lista.Count();
        }

        public Pila()
        {
            Elementos = new List<Disco>();
            Top = new Disco(0);
            Size = 0;
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d;
            Size ++;
        }

        public Disco pop()
        {
            if (Size > 0)
            {
                Disco disco = Top;
                Elementos.Remove(Top);
                if (this.isEmpty())
                {
                    Top = new Disco(0);
                    Size = 0;
                }
                else
                {
                    Top = this.Elementos.Last();
                    Size --;
                }
                return disco;
            }
            else
            {
                //Caso imposible, sacar un disco de una pila vacía
                Console.WriteLine("ERROR: Sacar un disco de una pila Vacía");
                return new Disco(0);
            }
        }

        public bool isEmpty()
        {
            if (Elementos.Count < 0)
            {
                Console.WriteLine("ERROR: Numero de elementos negativo");
                return true;
            }

            if (Elementos.Count() == 0)
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
