using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        public List<Llamada> _listaDeLlamadas;
        public string _razonSocial;
        // faltan las propiedades.


        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this()
        {
            this._razonSocial = nombreEmpresa;
        }
        
        public void mostrar()
        { }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            return 0;
        }


    }
}
