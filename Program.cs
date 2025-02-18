using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplopersona3381027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            //Crear objeto de clase
            Persona Personal = new Persona("verdes ", " 187 ", " 85 ", " v ");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos " + Personal.Ojos);
            Console.WriteLine("Altura " + Personal.altura);
            Console.WriteLine("Peso " + Personal.peso);
            Console.WriteLine("Sexo " + Personal.sexo);

            //Llamando a los metodos o acciones
            Personal.Hablar("Me llamo Borja ");
            Console.WriteLine("Color de mis ojos : " + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es : " + Personal.peso);

            //Llamando a la clase heredada
            PersonaNadadora Personal1 = new PersonaNadadora("verdes ", "187", "85 ", "v");
            Console.WriteLine("Descripción de la persona nadadora :");
            Console.WriteLine("Ojos " + Personal1.Ojos);
            Console.WriteLine("Altura " + Personal1.altura);
            Console.WriteLine("Peso " + Personal1.peso);
            Console.WriteLine("Sexo " + Personal1.sexo);
            Personal1.Nadar();
            Console.ReadKey();
        }
    }
}
