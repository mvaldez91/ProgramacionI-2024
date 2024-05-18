using ModificadoresAcceso;

namespace Sesion9
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //ProbarModificadoresDeAcceso();
            //claseMath();
            Console.WriteLine(getChar(101));
            Console.WriteLine(getRandomChar());
            Console.WriteLine(generarIdAleatorio(10));
            

        }

        public static void ProbarModificadoresDeAcceso() {
            ClasePublica objectoClasePublica = new ClasePublica();
            //No se puede usar porque esta definida como internal.
            //ClaseInternal claseInternal = new ClaseInternal();

            objectoClasePublica.MetodoPublico();
            //No se puede acceder porque esta como private
            //objectoClasePublica.MetodoProtegido();

            Console.WriteLine(objectoClasePublica.ObtenerEdad());
            //objectoClasePublica.fechaNacimiento;

            objectoClasePublica.CambiarFechaNacimiento(new DateTime(1980, 1, 1));
            Console.WriteLine(objectoClasePublica.ObtenerEdad());

            //Metodo protegido no es accesible.
            //objectoClasePublica.MetodoConProtected();

            ClaseHeradada objClaseHeradada = new ClaseHeradada();
            objClaseHeradada.MetodoConProtectedHeradado();

            Estructuras estructuras = new Estructuras();
            estructuras.CrearEstructura();
            estructuras.EjemploEnum((int)DateTime.Now.DayOfWeek);

        }

        public static void claseMath() {
            Console.Write("Usando Ceiling para 15.3 el resultado es {0}", Math.Ceiling(15.3));
            Console.Write("Usando floor para 15.3 el resultado es {0}", Math.Floor(15.3));
        }

        public static string getChar(int ascii)
        {
            return ((char)ascii).ToString();
        }

        public static string getRandomChar() {
            Random random = new Random();
            return getChar(random.Next(40, 122));
        }

        public static string generarIdAleatorio(int digitos)
        {
            string id = "";
            for (int i = 0;  i < digitos; i++)
            {
                id += getRandomChar();
            }
            return id;
        }
    }

}