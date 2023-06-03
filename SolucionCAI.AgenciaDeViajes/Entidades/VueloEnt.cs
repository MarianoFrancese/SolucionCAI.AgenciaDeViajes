using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class VueloEnt
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaArribo { get; set; }
        public TimeSpan TiempoVuelo { get { return CalcularTiempoVuelo(); } }
        public string Aerolinea { get; set; }
        public List<TarifaEnt> Tarifas { get; set; }

        public TimeSpan CalcularTiempoVuelo()
        {
            return FechaArribo - FechaSalida;
        }
    }
}
