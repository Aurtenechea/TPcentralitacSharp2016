using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // En el Main() se creará una Centralita (―Telefónica‖) y cuatro llamadas. 
            // La primera llamada será de tipo Local, con una duración de 30 seg.
            // y un costo de 2.65. La segunda será Provincial 
            // (en la franja 1 y con duración de 21 seg.) y las restantes: Local (45 seg. y 1.99)
            // y Provincial (que recibe la segunda llamada y franja 3).

            Centralita miCentralita = new Centralita("LaHipotenusa");
            Local miLocal = new Local("mongolia", 30, "sudafrica", 2.65f);
            Provincial miProvincial = new Provincial("origen", Franja.Franja_1, 21, "destino");
            Local miLocal2 = new Local("orig2", 45, "dest2", 1.99f);
            
            
            Provincial miProvincial2 = new Provincial(Franja.Franja_3 ,miProvincial);
        }
    }
}
