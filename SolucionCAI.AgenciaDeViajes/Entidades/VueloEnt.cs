using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    internal class VueloEnt
    {
        public VueloEnt()
        {
            // Podemos usar onstructor para inicializar el codigo
        }
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaArribo { get; set; }
        public TimeSpan TiempoVuelo { get { return CalcularTiempoVuelo();  } }
        public string Aerolinea { get; set; }
        public List<decimal> Tarifas { get; set; }

        private TimeSpan CalcularTiempoVuelo()
        {
            return FechaArribo - FechaSalida;
        }
        
    }
}
