﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local: Llamada
    {
        protected float _costo;
        
        public float CostoLlamada
        {
            get 
            {
                return this.calcularCosto();
            }
        }

        public Local (Llamada unaLlamada, float costo)
            :base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            // si no se deja explicito hay una invocacion implicita al constructor por defecto de la clase padre.

        
        }

        public Local (string origen, float duracion, string destino, float costo)
            :base(origen, destino, duracion)
        {
            // si no se deja explicito hay una invocacion implicita al constructor por defecto de la clase padre.
        
        }

        private float calcularCosto()
        {
            return 0;
        }

        public void mostrar()
        {
            
        }

        
    }
}
