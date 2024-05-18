namespace Sesion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion();
            Console.WriteLine(publicacion.ToString());

            //Publicacion publicacionConImagen = new PublicacionConImagen();

            //PublicacionConImagen publicacion3 = (PublicacionConImagen)publicacion;

            IOrdenable conInterfaz = new MiclaseConInterfaz();
        }
    }
}