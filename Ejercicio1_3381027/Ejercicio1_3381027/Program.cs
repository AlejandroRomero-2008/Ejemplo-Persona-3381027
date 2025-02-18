using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3381027
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Coche coche = new Coche("Ferrari", "Carreras", "1000km/h", "0km/h");
            Console.WriteLine("Cararteristicas del coche");
            Console.WriteLine("Marca: " + coche.marca);
            Console.WriteLine("Modelo: " + coche.modelo);

            coche.Acelera("1000km/h");
            coche.Decelera("0km/h");
           
            Cochefrenado cochefrenado = new Cochefrenado ("Ferrari", "Carreras", "1000km/h", "0km/h");
            Console.WriteLine("Cararteristicas del coche");
            Console.WriteLine("Marca: " + coche.marca);
            Console.WriteLine("Modelo: " + coche.modelo);

            coche.Acelera("1000km/h");
            coche.Decelera("0km/h");
            cochefrenado.frenado();
            Console.ReadKey();
        }

    }
}
