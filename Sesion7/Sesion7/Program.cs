// List, ArrayList
using System.Collections;

namespace Sesion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RecorrerArregloMultidimension();
            //PruebaArrayLists();
            PruebaList();
        }

        static void ArreglosUnidimensionales() {
            // Puedo directamente asignarlo los valores
            int[] arreglo = { 1, 2, 3 };
            // Puedo crearlo directamente indicando el tamaño
            int[] arreglo2 = new int[10];
            //Indicamos el tamaño y los elementos
            int[] arreglo3 = new int[4] { 1, 2, 4, 3 };

            //Guardar valores en arreglo

            //arreglo2[0] = 1;
            //Console.WriteLine(arreglo2[0]);
            //arreglo2[1] = 2;
            //Llenamos el arreglo
            for (int i = 0; i < arreglo2.Length; i++)
            {
                arreglo2[i] = i + 1;
            }
            //Recorremos e imprimos sus valores
            for (int i = 0; i < arreglo2.Length; i++)
            {
                Console.WriteLine(arreglo2[i]);
            }

            int contador = 0;
            while (contador < arreglo2.Length)
            {
                Console.WriteLine(arreglo2[contador]);
                contador++;
            }
        }

        static void ArregloMultidimensionales() {
            //Es un arreglo de 2x3
            string[,] arrayMulti1 =
            {
                { "A", "B", "C" },
                { "D", "E", "F" },
            };
            string[,] arrayMulti2 = new string[3,3];
            string[,,] arrayMulti3 =
            {
                {
                    { "A", "B", "C" },
                    { "D", "E", "F" }
                },
                {
                    { "A", "B", "C" },
                    { "D", "E", "F" }
                }
            };
        }

        public static void RecorrerArregloMultidimension() {
            string[,] matriz2x3 =
               {
                { "A", "B", "C" },
                { "D", "E", "F" },
            };

            for (int i=0; i< matriz2x3.GetLength(0); i++)
            {
                for (int j=0; j <= matriz2x3.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2x3[i,j]);
                }
            }

        }

        public static void PruebaArrayLists() { 
           ArrayList lista = new ArrayList();
           lista.Add(10);
           lista.Add(20);
            lista.Add("Hola");
            lista.Add("Mundo");

            //Eliminar
            lista.Remove("HOLA");
           for (int i=0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        public static void PruebaList() {
            List<string> lista = new List<string>();
            lista.Add("Hola");
            lista.Add(1.ToString());
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            //Podemos definir lists de cualquier tipo de C#
            List<int> listaEnteros = new List<int>();
            List<Alumno> alumnos = new List<Alumno>();
        }

    }
}