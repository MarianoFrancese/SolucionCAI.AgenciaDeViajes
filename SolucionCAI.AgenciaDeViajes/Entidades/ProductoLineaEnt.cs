using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ProductoLineaEnt
    {
        public HotelEnt ProductoH { get; set; }
        public VueloEnt ProductoV { get; set; }
        public TarifaEnt PrecioUn { get; set; }
        public int Cantidad { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal IVA { get; set; }
        public Decimal TotalProd { get; set; }
        
    }
}
