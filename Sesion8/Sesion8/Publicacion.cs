using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    class Publicacion
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool EsPublico { get; set; }

        public Publicacion() { 
            var random = new Random();
            ID = random.Next(1, 12000000);
            Titulo = "Mi primera publicacion";
            EsPublico= true;
            Autor = "Juan Perez";
        }

        // Virtual nos indica que una subclase puede sobreescribir el metodo.
        public void Editar(string titulo, bool esPublico)
        {
            Titulo = titulo;
            EsPublico = esPublico;
        }

        //override nos permite sobrescribir el metodo ToString que tienen todos los objectos de C#
        public override string ToString() {
            return $"ID:{ID}Titulo:{Titulo};Autor:{Autor}:EsPublico{EsPublico}";
        }
    }
}
