using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    public class ClasePublica
    {
        private int id;
        public string name;
        private DateTime fechaNacimiento = new DateTime(1990,01,01);
        private void MetodoProtegido()
        {
            Console.WriteLine("Esto es privado");
        }

        public void MetodoPublico()
        {
            Console.WriteLine("Esto no es privado");
        }

        public int ObtenerEdad() { 
            return Convert.ToInt32(((DateTime.Now - fechaNacimiento).TotalDays / 365.00));
        }

        public void CambiarFechaNacimiento(DateTime nuevaFecha)
        {
            this.fechaNacimiento = nuevaFecha;
        }

        protected void MetodoConProtected() {
            Console.WriteLine("Este metodo usa protected");
        }

    }
}
