using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplopersona3381027
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
        }
        public string Ojos;
        public string altura;
        public string peso;
        public string sexo;

        //Acciones
        public void Hablar(string texto)
        {
            Console.WriteLine("Voy a decir : " + texto);
        }

        public void Comer(double calorias)
        {
            Console.WriteLine("Ganando " + calorias + " Calorias");
            this.peso += calorias / 1000;
        }

        public void correr(double calorias)
        {
            Console.WriteLine("Perdiendo " + calorias + " calorias");
            this.peso = Convert.ToString(calorias / 1000);
        }
    }
}

