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
            bool valido = false;
            Console.WriteLine("Buenos días, inserte el número de discos por favor :)");
            while (!valido)
            { //Este While comprueba que hayas introducido un número válido
                try
                {
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
                    valido = true; //Si todo va bien, salimos del while
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Por favor, ingrese un número válido");
                    //Si ha ingresado un número negativo, o una tecla o cualquier otro símbolo volvemos a empezar
                }
            }
            
           

        }
    }
}
