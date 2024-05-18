namespace Sesion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //cicloForConBreak();
            sumarPuntos();
        }

        public static void cicloForConBreak()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }

        public static void sumarPuntos() {

            string[] nombres = new string[]
            {
                "Luis",
                "Aritna",
                "Hector",
                "Alejandro"
            };
            int punteoBase = 9;
            for (int i = 0; i < nombres.Length; i++)
            {
                string nombreActual = nombres[i];
                if (!nombreActual.StartsWith("A"))
                {
                    continue;
                }
                Console.WriteLine($"{nombreActual} tienes {punteoBase + 1}");
            }
        }
    }
}