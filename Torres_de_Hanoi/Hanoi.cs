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
                    Console.WriteLine("Moviendo disco de A a B");
                }

            }else if(a.isEmpty())
            {
                Disco disco = b.pop();
                a.push(disco);
                Console.WriteLine("Moviendo disco de B a A");
            } else
            {
                if(a.Top.Valor > b.Top.Valor)
                {
                    Disco disco = b.pop();
                    a.push(disco);
                    Console.WriteLine("Moviendo disco de B a A");
                }
                else
                {
                    Disco disco = a.pop();
                    b.push(disco);
                    Console.WriteLine("Moviendo disco de A a B");
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            bool solucion = false;
            if(n%2 == 0)
            {
                while (!solucion)
                {
                    /*incrementar movimientos(m) ← mover disco(INI, F IN)
                      6: incrementar movimientos(m) ← mover disco(INI, AUX)
                      7: incrementar movimientos(m) ← mover disco(AUX, FIN)*/

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a fin");
                    mover_disco(ini, fin);

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a aux");
                    mover_disco(ini, aux);

                    movimientos++;
                    Console.WriteLine("Movimiento aux a fin");
                    mover_disco(aux, fin);

                    if(fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        solucion = true;
                    }
                }
            }
            else
            {
                /*incrementar movimientos(m) ← mover disco(INI, AUX)
                  incrementar movimientos(m) ← mover disco(INI, F IN)
                  incrementar movimientos(m) ← mover disco(AUX, F IN)*/

                movimientos++;
                Console.WriteLine("Movimiento inicio a aux");

                mover_disco(ini, aux);

                movimientos++;
                Console.WriteLine("Movimiento inicio a fin");

                mover_disco(ini, fin);

                movimientos++;
                Console.WriteLine("Movimiento aux a fin");
                mover_disco(aux, fin);

                if (fin.Size == n)
                {
                    //Si la pila final tiene todos los discos, paramos el programa
                    solucion = true;
                }

            }

            return movimientos;
        }

    }
}
