using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    internal class PublicacionConImagen : Publicacion 
    {
        public string UrlImagen { get; set; }

        public PublicacionConImagen() { }
        public PublicacionConImagen(string titulo, string autor, bool esPublico, string urlImagen)
        {
            Titulo = titulo;
            Autor = autor;
            EsPublico = esPublico;
            UrlImagen = urlImagen;
        }

        public void Editar(string titulo, bool esPublico, string urlImagen)
        {
            Titulo = titulo;
            EsPublico = esPublico;
            UrlImagen = urlImagen;
        }

    }
}
