using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio1_3381027.Cochefrenado;

namespace Ejercicio1_3381027
{
    
    


        public class Cochefrenado : Coche
        {

            public Cochefrenado(string Marca, string Modelo, string Velocidadmaxima, string Velicidadactual) : base(Marca, Modelo, Velocidadmaxima, Velicidadactual)
            {

            }
            public void frenado()
            {
                
                Console.WriteLine("Mi coche frena por que es muy rapido ya que es un:");
                this.marca = "ferrari";
            }
        }
    }

