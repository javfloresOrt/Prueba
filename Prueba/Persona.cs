using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public string MostraDatos()
        {
            string Resultado;
            Resultado = $"DNI: {DNI},Nombre: {Nombre},Apellido: {Apellido}";
            return Resultado;

        }

    }
}
