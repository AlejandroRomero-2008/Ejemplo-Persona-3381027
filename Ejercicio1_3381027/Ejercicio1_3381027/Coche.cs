using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3381027
{
    public class Coche
    {
        public Coche(string Marca, string Modelo, string Velocidadmaxima, string Velicidadactual)
        {
            this.marca = Marca;
            this.modelo = Modelo;
            this.velocidadmaxima = Velocidadmaxima;
            this.velocidadactual = Velicidadactual;
        }
        public string marca;
        public string modelo;
        public string velocidadmaxima;
        public string velocidadactual;

        public void Acelera(string acelera)
        {
            Console.WriteLine("El coche acelera: " + acelera);
        }
        public void Decelera(string decelera)
        {
            Console.WriteLine("El coche decelera: " + decelera);
        }
    }
}
