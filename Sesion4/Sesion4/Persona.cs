using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4
{
    internal class Persona
    {
        private string Nombre;
        private int Edad;
        
        public Persona(string Nombre, int edad)
        {
            this.Nombre = Nombre;
            Edad = edad;
        }

        public string Saludar(string aQuienSaludo)
        {
            return $"Hola {aQuienSaludo}";
        }

        //Metodo estatico
        public static string SaludarEstatico(string aQuienSaludo)
        {
            return $"Hola {aQuienSaludo}";
        }

        public void Caminar() {
            Console.WriteLine($"{Nombre} esta caminando");
        }

        public int ObtenerEdad()
        {
            return Edad;
        }


    }
}
