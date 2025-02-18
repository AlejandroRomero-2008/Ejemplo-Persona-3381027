using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3_3381027
{
    public class DatosOrdenador
    {
        public DatosOrdenador(string marca, string procesador, string memoria, string discoduro)
        { 
            this.Marca = marca;
            this.Procesador = procesador;
            this.Memoria= memoria;
            this.Discoduro= discoduro;

        }
        public string Marca;
        public string Procesador;
        public string Memoria;
        public string Discoduro;

        public void MayorCapacidad(string texto)
        {
            Console.WriteLine("La mayor capacidad del ordenador es 100 en 100GB");
        }
        public void MenorCapacidad(string texto)
        {
            Console.WriteLine("la menor capacidad del ordenaodor es menor de 100GB");
        }
    }
}
