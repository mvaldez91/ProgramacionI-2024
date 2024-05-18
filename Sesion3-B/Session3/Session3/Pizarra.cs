namespace Session3
{
    internal class Pizarra
    {
        //Attributos de la clase.
        private string color;
        private double ancho;
        private double largo;

        private string contenido = "";
        
        public Pizarra(string color, double ancho, double largo)
        {
            this.color = color;
            this.ancho = ancho;
            this.largo = largo;
        }

        //Metodos
        /// <summary>
        /// El metodo escribe el contenido indicado en la pizarra.
        /// </summary>
        /// <param name="texto">Contenido que se quiere escribir</param>
        public void Escribir(string texto)
        {
            contenido = contenido + texto;
            //contenido = +texto;
        }

        public void Borrar()
        {
            contenido = "";
        }
        public string GetContenido()
        {
            return contenido;
        }
    }
}
