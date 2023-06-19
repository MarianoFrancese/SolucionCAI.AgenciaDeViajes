using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class TarifaEnt
    {
        public string Clase { get; set; }
        public string TipoPasajero { get; set; }
        public decimal Precio { get; set; }
        public int Disponibilidad { get; set; }
        public List<PasajeroEnt> Pasajeros { get; set; }
        public Guid Uid { get; set; }

        public bool CorrespondeA(PasajeroEnt pasajero)
        {
            var edad = DateTime.Now.Year - pasajero.FechaNac.Year;
            if (TipoPasajero == "Infante")
            {
                return edad < 3;
            }
            else if (TipoPasajero == "Menor")
            {
                return edad < 12;
            }
            else
            {
                return true;
            }

            //pasar pasajero en vez de fecha me permite eventualmente agregar más validaciones.
        }
    }
}
