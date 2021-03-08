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

            // Keep the console window open in debug mode.
            Console.WriteLine("Buenos días, inserte el número de discos por favor :)");
            int totalDiscos = Int32.Parse(Console.ReadLine());

            Pila pilaIni = new Pila();
            Pila pilaAux = new Pila();
            Pila pilaFin = new Pila();

            for (int i=totalDiscos; i>0; i--)
            {
                pilaIni.Elementos.Add(new Disco(i));
                Console.WriteLine(i);
            }

            

            Console.WriteLine(pilaAux.Elementos.Count());

            Hanoi El_problema_de_hanoi = new Hanoi();

            int numMovimientos = El_problema_de_hanoi.iterativo(totalDiscos, pilaIni, pilaAux, pilaFin);

            Console.WriteLine("El problema se ha resuelto en " + numMovimientos + " movimientos.");

            if (numMovimientos == (2 ^ totalDiscos) - 1)
            {
                Console.WriteLine("El problema se ha resuelto bien :)");
            }
            else
            {
                Console.WriteLine("El problema se ha resuelto mal :(");

            }

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}
