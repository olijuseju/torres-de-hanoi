using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty())
            {
                if (a.isEmpty())
                {
                    Console.WriteLine("Las dos pilas están vacías :(");
                }
                else
                {
                    Disco disco = a.pop();
                    b.push(disco);
                    Console.WriteLine("Moviendo primer disco de A a B");
                }

            }else if(a.isEmpty())
            {
                Disco disco = b.pop();
                a.push(disco);
                Console.WriteLine("Moviendo primer disco de B a A");
            } else
            {
                if(a.Top.Valor == b.Top.Valor)
                {
                    Console.WriteLine("Caso imposible, dos discos iguales");
                }
                if(a.Top.Valor > b.Top.Valor)
                {
                    Disco disco = b.pop();
                    a.push(disco);
                    Console.WriteLine("Moviendo primer disco de B a A");
                }
                else
                {
                    Disco disco = a.pop();
                    b.push(disco);
                    Console.WriteLine("Moviendo primer disco de A a B");
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
