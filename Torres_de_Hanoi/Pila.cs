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
        public Pila()
        {
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d;
            Size = Elementos.Count();
        }

        public Disco pop()
        {
            if (!this.isEmpty())
            {
                Disco disco = Top;
                Elementos.Remove(Top);
                Top = Elementos.Last();
                Size = Elementos.Count();
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
