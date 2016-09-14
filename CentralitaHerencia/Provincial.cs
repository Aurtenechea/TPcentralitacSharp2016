using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.calcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            :base (unaLlamada.NroOrigen, unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        
        public float calcularCosto()
        {
            return 0;
        }

        public void mostrar()
        { 
            
        }

    
    }
}
