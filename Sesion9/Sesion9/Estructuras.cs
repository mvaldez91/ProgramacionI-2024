using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion9
{

    enum Dia {Lu = 1, Ma, Mi, Ju, Vi, Sa, Do };
    enum EstadoVenta { Bodega, EnTransito, Agotado};

    public struct Videojuego
    {
        public string nombre;
        public string desarrollador;
    }

    internal class Estructuras
    {
        public void CrearEstructura() {
            Videojuego videojuego;
            videojuego.nombre = "Call Of Duty";
            videojuego.desarrollador = "Activision";
            Console.WriteLine("{0}-{1}", videojuego.nombre, videojuego.desarrollador);
        }

        public void EjemploEnum(int dia) { 
           
            if (dia == (int)Dia.Sa) {
                Console.WriteLine("Es sabado");
            }

        }

        public void EjemploVenta(int estado) { 
        
            if (estado == (int)EstadoVenta.Agotado)
            {
                Console.WriteLine("El producto esta agotado");
            }
            //Realizar el proceso de la venta que sigue.

        }
    }
}
