using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    
    class Hanoi
    {
        public int m;

        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty())
            {
                Disco discoA = a.pop();
                b.push(discoA);
                Console.WriteLine("Moviendo de A a B");
            }
            else if (a.isEmpty())
            {
                Disco discoB = b.pop();
                a.push(discoB);
                Console.WriteLine("Moviendo de B a A");
            }
            else
            {

                if (a.Top.Valor < b.Top.Valor)
                {
                    Disco discoA = a.pop();
                    b.push(discoA);
                    Console.WriteLine("Moviendo de A a B");

                }
                else if (b.Top.Valor < a.Top.Valor)
                {
                    Disco discoB = b.pop();
                    a.push(discoB);
                    Console.WriteLine("Moviendo de B a A");
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            bool solucion = false;
            if (n%2 == 0)
            {
                while (!solucion)
                {
                    /*incrementar movimientos(m) ← mover disco(INI, AUX)
                      6: incrementar movimientos(m) ← mover disco(INI, FIN)
                      7: incrementar movimientos(m) ← mover disco(AUX, FIN)*/

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a fin");
                    mover_disco(ini, aux);

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a aux");
                    mover_disco(ini, fin);

                    movimientos++;
                    Console.WriteLine("Movimiento aux a fin");
                    mover_disco(aux, fin);


                    if (fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        Console.WriteLine("Graasia Diego");
                        solucion = true;
                    }

                }
            }
            else
            {
                while (!solucion)
                {
                    /*incrementar movimientos(m) ← mover disco(INI, FIN)
                      incrementar movimientos(m) ← mover disco(INI, AUX)
                      incrementar movimientos(m) ← mover disco(AUX, FIN)*/

                    if (fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        solucion = true;
                        return movimientos;
                    }

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a aux");
                    mover_disco(ini, fin);
                    if (fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        solucion = true;
                        return movimientos;

                    }

                    movimientos++;
                    Console.WriteLine("Movimiento inicio a fin");
                    mover_disco(ini, aux);

                    if (fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        solucion = true;
                        return movimientos;
                    }

                    movimientos++;
                    Console.WriteLine("Movimiento aux a fin");
                    mover_disco(aux, fin);

                    if (fin.Size == n)
                    {
                        //Si la pila final tiene todos los discos, paramos el programa
                        solucion = true;
                        return movimientos;
                    }

                }
                    
            }

            return movimientos;
        }


        public int Recursivo(int n, Pila ini, Pila fin, Pila aux)
        {

            /*
                1: ENTRADA: n, INI, F IN, AUX
                2: SALIDA: m
                3: si n = 1:
                4: incrementar movimientos(m) ← mover disco(INI, F IN)
                5: sino:
                6: algoritmo recursivo(n − 1, INI, AUX, F IN)
                7: incrementar movimientos(m) ← mover disco(INI, F IN)
                8: algoritmo recursivo(n − 1, AUX, F IN, INI)
                9: fin si
                10: devuelve m
             */


            if (n == 1)
            {
                m++;
                mover_disco(ini, fin);
                return m;
            }
            else
            {
                Recursivo(n - 1, ini, aux, fin);
                m++;
                mover_disco(ini, fin);
                Recursivo(n - 1, aux, fin, ini);
            }

            return m;

        }

    }
}
