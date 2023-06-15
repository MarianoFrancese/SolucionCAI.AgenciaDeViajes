using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        //Este devolvería mensaje de error, es igual a la de arriba

        public bool ValidaUsuario2(string usuario, string contraseña)
        {
            bool flag = false;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                Console.WriteLine("Usuario/Contraseña no puede estar vacio.");
            }

            else
            {
                flag = true;
            }

            return flag;
        }

        //para leer de json
     /*   public bool ValidaUsuario1(string usuario, string contraseña)
        {

            string usuario = UsuarioLogin.Text;
            string contraseña = ContraseñaLogin.Text;

            var credenciales = LeerCredencialesDesdeJSON("ruta_al_archivo.json");

            if (credenciales != null && credenciales.Usuario == usuario && credenciales.Contraseña == contraseña)
            {
                MenuPrincipal MPrinc = new MenuPrincipal(usuario);
                MPrinc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        } */




        public bool ValidaAereo(string codigo, string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, TimeSpan tiempoVuelo, string aerolinea, List<decimal> tarifas)
        {
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(aerolinea) || tarifas.Count == 0)
            {
                return false;
            }
            else if (fechaSalida > fechaArribo || fechaSalida < DateTime.Now || fechaArribo < DateTime.Now) //fecha arribo no se busca en el filtro asique no se valida
            {
                return false;
            }
            else if (tiempoVuelo <= TimeSpan.Zero) //tiempo vuela se calcula, no se filtra, no deberia validarse
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaHotel(string ciudad, DateTime fechaEntrada, int cantHuespedes, string tipoHabitacion)
        {
            if (string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(tipoHabitacion))
            {
                return false;
            }
            else if (fechaEntrada < DateTime.Now) 
            {
                return false;
            }
            else if (cantHuespedes == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //ValidaDNI del pasajero
        public bool ValidaDNI(int dni)
        {
            const int longitudDNI = 8;

            string dniString = dni.ToString();

            // Verificar la longitud del DNI
            if (dniString.Length != longitudDNI)
            {
                Console.WriteLine("El DNI ingresado no es válido.");
                return false;
            }

            // Verificar que el DNI esté compuesto solo por dígitos
            foreach (char c in dniString)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("El DNI ingresado no es válido.");
                    return false;
                }
            }

            // Si todas las validaciones son exitosas, se asume que el DNI es válido
            return true;
        }


        /* Para llamar a esta validación mas tarde
          PasajeroEnt pasajero = new PasajeroEnt();
            pasajero.DNI = 12345678;

            bool dniValido = ValidaDNI(pasajero.DN);
                if (dniValido)
                {
                Console.WriteLine("El DNI es válido.");
                            }
                        else
                {
                    Console.WriteLine("El DNI no es válido.");
                }*/





        //ValidaCUIL

        public static bool ValidarCUIT(string cuit)
        {
            {
                string cleanedcuil = cuit;

                // Verificar longitud del CUIT
                if (cuit.Length != 11)
                {
                    return false;
                }
                // Verificar que todos los caracteres sean dígitos numéricos
                foreach (char c in cuit)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }

                // Obtener los dos primeros dígitos
                string firstTwoDigits = cleanedcuil.Substring(0, 2);

                // Verificar que los dos primeros dígitos sean válidos
                int firstTwoDigitsValue = Convert.ToInt32(firstTwoDigits);

                if (firstTwoDigitsValue != 30 && firstTwoDigitsValue != 33 && firstTwoDigitsValue != 34)
                {
                    Console.WriteLine("El CUIT es inválido");
                }

                else

                { return true; }

            }

            // Si todas las validaciones pasan, devuelve true
            return true;
        }

        //Valida CUIT

        public static bool ValidarCUIL(string cuil)
        {

            // Verificar longitud del CUIL
            if (cuil.Length != 11)
            {
                return false;
            }


            // Verificar que todos los caracteres sean dígitos numéricos
            foreach (char c in cuil)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }

            }
            return true;
        }


        //Valida email
       

        
        public static bool ValidateEmail(string email)
        {
            bool isValid = false;

            // Expresión regular para validar el formato del correo electrónico
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Utilizar Regex.IsMatch para verificar si el correo electrónico coincide con el patrón
            return Regex.IsMatch(email, pattern);

            if (isValid == false)

                Console.WriteLine("El correo electrónico es inválido");
            else
            {
                return true;
            }
        }
    }


    
    }
    


