namespace Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizarra pizarronDelSalon = new Pizarra("blanco", 1.5, 3);
            pizarronDelSalon.Escribir("Hola estudiantes");

            Console.WriteLine(pizarronDelSalon.GetContenido());
        }
    }
}