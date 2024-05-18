// namespace sirve para agrupar distintas clases de C#

//Importamos la biblioteca de clases
using MiBiblioteca;

namespace Sesion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declarar una variable
            //Cada linea de codigo en C# lleva un ; al final
            int edadEnNumero = 0;

            //Instanciamos un objeto de la clase.
            MiPrimeraClase miPrimerObjeto = new MiPrimeraClase();
            decimal suma = miPrimerObjeto.Sumar(10, 20);
            Console.WriteLine("El resultado de la suma es {0}-{1}-{2}", suma, "Hola", 3);
            Console.WriteLine($"El resultado de la suma es {suma}-{"Hola"}-{3}");
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Ingrese su edad:");
            //string edad = Console.ReadLine();
            edadEnNumero = int.Parse(Console.ReadLine());
            if (edadEnNumero < 18) {
                Console.WriteLine("Usted es menor de edad");
            }
            else
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            Console.ReadLine();
        }
    }
}