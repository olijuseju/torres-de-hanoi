using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numeroValido = false;
            bool eleccionValida = false;
            Console.WriteLine("Buenos días, elija una opción por favor por favor :)");
            Console.WriteLine("Pulse 1 para utilizar el algoritmo iterativo");
            Console.WriteLine("Pulse 2 para utilizar el algoritmo recursivo");

            while (!eleccionValida)
            {
                try
                {
                    int elección = Int32.Parse(Console.ReadLine());

                    while (!numeroValido)
                    { //Este While comprueba que hayas introducido un número válido
                        try
                        {



                            if (elección == 1)
                            {
                                Console.WriteLine("Ingrese el número de discos");
                                int totalDiscos = Int32.Parse(Console.ReadLine());


                                int formula = (int)(Math.Pow(2, totalDiscos) - 1);
                                List<Disco> Elementos = new List<Disco>();
                                for (int i = totalDiscos; i > 0; i--)
                                {
                                    Elementos.Add(new Disco(i));
                                }

                                Pila pilaIni = new Pila(Elementos);
                                Pila pilaAux = new Pila();
                                Pila pilaFin = new Pila();


                                Hanoi El_problema_de_hanoi = new Hanoi();
                                int numMovimientos = El_problema_de_hanoi.iterativo(totalDiscos, pilaIni, pilaFin, pilaAux);

                                Console.WriteLine("El problema con " + totalDiscos + " discos se ha resuelto en " + numMovimientos + " movimientos.");

                                if (numMovimientos == formula)
                                {
                                    Console.WriteLine("El problema se ha resuelto bien :)");
                                }
                                else
                                {
                                    Console.WriteLine("El problema se ha resuelto mal :(");

                                }
                                numeroValido = true; //Si todo va bien, salimos del while
                                Console.WriteLine("Pulse cualquier tecla para salir");
                                Console.ReadKey();
                            }
                            else if (elección == 2)
                            {
                                Console.WriteLine("Ingrese el número de discos");
                                int totalDiscos = Int32.Parse(Console.ReadLine());


                                int formula = (int)(Math.Pow(2, totalDiscos) - 1);
                                List<Disco> Elementos = new List<Disco>();
                                for (int i = totalDiscos; i > 0; i--)
                                {
                                    Elementos.Add(new Disco(i));
                                }

                                Pila pilaIni = new Pila(Elementos);
                                Pila pilaAux = new Pila();
                                Pila pilaFin = new Pila();


                                Hanoi El_problema_de_hanoi = new Hanoi();
                                int numMovimientos = El_problema_de_hanoi.Recursivo(totalDiscos, pilaIni, pilaFin, pilaAux);

                                Console.WriteLine("El problema con " + totalDiscos + " discos se ha resuelto en " + numMovimientos + " movimientos.");

                                if (numMovimientos == formula)
                                {
                                    Console.WriteLine("El problema se ha resuelto bien :)");
                                }
                                else
                                {
                                    Console.WriteLine("El problema se ha resuelto mal :(");

                                }
                                numeroValido = true; //Si todo va bien, salimos del while
                                Console.WriteLine("Pulse cualquier tecla para salir");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Muy gracioso, ingrese una elección válida");
                                elección = Int32.Parse(Console.ReadLine());

                            }

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Por favor, ingrese un número válido");
                            //Si ha ingresado un número negativo, o una tecla o cualquier otro símbolo volvemos a empezar
                        }
                    }
                    eleccionValida = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Muy gracioso, ingrese una elección válida");
                }
            }

        }
    }
}
