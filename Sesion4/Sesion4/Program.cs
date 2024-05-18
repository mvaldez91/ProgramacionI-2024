namespace Sesion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cree una instancia de la clase Persona.
            Persona personaObjeto = new Persona("Marco", 29);

            //Console.WriteLine(personaObjeto.Saludar("Juan"));
            //Console.WriteLine(Persona.SaludarEstatico("Pedro"));

            //personaObjeto.SaludarEstatico("Hola");
            ejemploSwitchCase();
        }
        

        static void ManejoErorres()
        {
            try
            {
                Calculadora calculadora = new Calculadora();
                //Vamos a colocar el codigo que puede fallar.
                Console.WriteLine("Ingrese el primer numero:");
                float n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                float n2 = float.Parse(Console.ReadLine());
                Console.WriteLine(calculadora.Sumar(n1, n2));
            }
            catch (Exception ex)
            {
                //Aqui vamos a ejecutar acciones cuando el codigo falle.
                Console.Error.WriteLine("Algo salio mal");
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine(ex.GetType().Name);
            }
            finally
            {
                //Esto siempre se va ejecutar.
                Console.WriteLine("Esto siempre se ejecuta");
            }
        }
        static void verificarEdad(int edad)
        {
            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            //Operador AND &&
            if (edad >= 18 && edad < 100)
            {
                Console.WriteLine("Esta en plena juventud");
            }
            //Operador OR ||
            if (edad == 15 || edad == 16)
            {
                Console.WriteLine("Usted es adolescente");
            }
        }

        static void ejemploSwitchCase()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("Escriba su opcion");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Hola");
                    break;
                case "2":
                    Console.WriteLine("Ingrese numero 1");
                    float n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese numero 2");
                    float n2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es {n1 + n2}");
                    break;
                default:
                    Console.WriteLine("No reconoci la opcion solicitada");
                    break;
            }
            

        }
    }
}