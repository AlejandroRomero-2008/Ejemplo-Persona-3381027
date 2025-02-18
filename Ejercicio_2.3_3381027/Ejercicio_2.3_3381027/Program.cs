using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3_3381027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            DatosOrdenador datosOrdenador = new DatosOrdenador("HP","INTEL core 5", "1TB", "SSD");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Marca " + datosOrdenador.Marca);
            Console.WriteLine("Procesador " + datosOrdenador.Procesador);
            Console.WriteLine("Memoria " + datosOrdenador.Memoria);
            Console.WriteLine("Discoduro " + datosOrdenador.Discoduro);

            datosOrdenador.MayorCapacidad("");
            datosOrdenador.MenorCapacidad("");
            Console.ReadKey();
        }
    }
}
