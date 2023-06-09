﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{

    internal class Validaciones
    {
       /* public bool ValidaUsuario(string usuario, string contraseña)
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

        //Este devolvería mensaje de error, es igual a la de arriba */

      /*  public bool ValidaUsuario2(string usuario, string contraseña)
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
        } */

        //Usuarios
        public bool ValidarUsuarios(string usuario, string contraseña)
        {
            string contenidoJSON = File.ReadAllText("Usuarios.json");

            try
            {
                var jsonData = System.Text.Json.JsonSerializer.Deserialize<JsonDocument>(contenidoJSON);
                var usuarios = jsonData.RootElement.GetProperty("usuarios").EnumerateArray();

                foreach (var usuarioJson in usuarios)
                {
                    string usuarioActual = usuarioJson.GetProperty("usuario").GetString();
                    string contraseñaActual = usuarioJson.GetProperty("contraseña").GetString();

                    if (usuario == usuarioActual && contraseña == contraseñaActual)
                    {
                        return true; // Usuario y contraseña válidos
                    }
                }
            }
            catch (System.Text.Json.JsonException ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
            }

            return false; // Usuario o contraseña incorrectos
        }



        public bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mail ingresado no es válido.");
                return false;
            }
        }




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
        public bool ValidaDNI(string dni)
        {
            const int longitudDNI = 8;

            //string dniString = dni.ToString();

            // Remove any whitespace from dni
            dni = dni.Trim();

            // Verificar la longitud del DNI
            if (dni.Length != longitudDNI)
            {
                MessageBox.Show("El DNI ingresado no es válido.");
                return false;
            }

            // Verificar que el DNI esté compuesto solo por dígitos
            foreach (char c in dni)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("El DNI ingresado no es válido.");
                    return false;
                }
            }

            // Si todas las validaciones son exitosas, se asume que el DNI es válido
            return true;
        }

        public bool ValidaTexto(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    
                    return false;
                }
            }

            return true;
        }


        public bool ValidaTextoNumero(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ValidaTextoNumeroEsp(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetterOrDigit(c) && c != '-' && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        









        public bool ValidaCampoVacio(string input, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"El campo {nombreCampo} no puede estar vacío.");
                return false;
            }

            return true;
        }



        //ValidaTelefono
        public bool ValidaTelefono(string telefono)
        {
            const int longitudTelefono = 10;

            // Remove any whitespace from telefono
            telefono = telefono.Trim();

            // Verificar la longitud del Telefono
            if (telefono.Length != longitudTelefono)
            {
                MessageBox.Show("El Teléfono ingresado no es válido.");
                return false;
            }

            // Verificar que el teléfono esté compuesto solo por dígitos
            foreach (char c in telefono)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("El teléfono ingresado no es válido.");
                    return false;
                }
            }

            // Si todas las validaciones son exitosas, se asume que el Teléfono es válido
            return true;
        }


      






        //ValidaCUIT

        public bool ValidarCUIT(string cuit)
        {
            {
                string cleanedcuit = cuit;

                // Verificar longitud del CUIT
                if (cuit.Length != 11)
                {
                    MessageBox.Show("El CUIT no es válido");
                    return false;
                }
                // Verificar que todos los caracteres sean dígitos numéricos
                foreach (char c in cuit)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("El CUIT no es válido");
                        return false;
                    }
                }

                // Obtener los dos primeros dígitos
                string firstTwoDigits = cleanedcuit.Substring(0, 2);

                // Verificar que los dos primeros dígitos sean válidos
                int firstTwoDigitsValue = Convert.ToInt32(firstTwoDigits);

                if (firstTwoDigitsValue != 30 && firstTwoDigitsValue != 33 && firstTwoDigitsValue != 34)
                {
                    MessageBox.Show("El CUIT no es válido");
                }

                else

                { return true; }

            }

            // Si todas las validaciones pasan, devuelve true
            return true;
        }

        //Valida CUIL

        public  bool ValidarCUIL(string cuil)
        {
            string cleanedcuil = cuil;
            // Verificar longitud del CUIL
            if (cuil.Length != 11)
            {
                MessageBox.Show("El CUIL no es válido");
                return false;
            }

            // Verificar que los dos primeros dígitos sean válidos
            string firstTwoDigits = cleanedcuil.Substring(0, 2);
            int firstTwoDigitsValue = Convert.ToInt32(firstTwoDigits);

            if (firstTwoDigitsValue != 27 && firstTwoDigitsValue != 20 && firstTwoDigitsValue != 24 && firstTwoDigitsValue != 23 )
            {
                MessageBox.Show("El CUIL no es válido");
            }

            else

            { return true; }


            // Verificar que todos los caracteres sean dígitos numéricos
            foreach (char c in cuil)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("El CUIL no es válido");
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
            { 
                MessageBox.Show("El correo electrónico es inválido");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarTipoPasajero(int adultos, int menores, int infantes, int cantHuespedes)
        {
            if (cantHuespedes >= adultos + menores + infantes)
            {
                if (adultos > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
    


