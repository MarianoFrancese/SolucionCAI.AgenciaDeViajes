using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    internal class Validaciones
    {
        public bool ValidaUsuario(string usuario, string contraseña)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Este devolvería mensaje de error

        public bool ValidaUsuario2(string usuario, string contraseña)
        {
            bool flag = false;

            if (String.IsNullOrWhiteSpace(usuario) || String.IsNullOrWhiteSpace(contraseña))
            {
                Console.WriteLine("Usuario/Contraseña no puede estar vacio.");
            }
            
            else
            {
                flag = true;
            }

            return flag;
        }



        public bool ValidaAereo(string codigo, string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, TimeSpan tiempoVuelo, string aerolinea, List<decimal> tarifas)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(aerolinea) || tarifas.Count == 0)
            {
                return false;
            }
            else if (fechaSalida > fechaArribo || fechaSalida < DateTime.Now || fechaArribo < DateTime.Now)
            {
                return false;
            }
            else if (tiempoVuelo <= TimeSpan.Zero)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }



        public bool ValidaDni(int DNI)
            {
                bool flag = false;

                if (!int.TryParse(numero, out salida))
                     {
                         Console.WriteLine("Usted debe ingresar un dato numérico.");
                       }
                 else if (salida <= 0)
                      {
                        Console.WriteLine("Usted debe ingresar un número mayor que cero.");
                         }
                  else
                        {
                            flag = true;
                        }

                     return flag;
               }







}



