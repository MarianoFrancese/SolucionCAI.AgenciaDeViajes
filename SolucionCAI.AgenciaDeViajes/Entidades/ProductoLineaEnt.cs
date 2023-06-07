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
        public decimal PrecioUn { get; set; }
        public int Cantidad { get; set; }
        public Decimal Descuento { get { return CalcularDescuento(Cantidad); } }
        public Decimal SubTotal { get { return CalcularSubtotal(Cantidad, PrecioUn); } }
        public Decimal IVA { get { return CalcularIVA(SubTotal); } }
        public Decimal TotalProd { get { return CalcularTotal(SubTotal, IVA); } }

        public decimal CalcularDescuento(int cantidad)
        {
            decimal descuento;

            if (cantidad >= 5)
            {
                descuento = 0.1m;
            }
            else
            {
                descuento = 0;
            }
            return descuento;
        }

        public decimal CalcularSubtotal(int cantidad, decimal precioUnitario)
        {
            decimal subtotal;

            subtotal = cantidad * precioUnitario;

            return subtotal;
        }

        public decimal CalcularIVA(decimal subtotal)
        {
            decimal iva;

            iva = subtotal * 0.21m;

            return iva;
        }

        public decimal CalcularTotal(decimal subtotal, decimal iva)
        {
            decimal total;

            total = subtotal + iva;

            return total;
        }

    }
}
