using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam=10)
        {
            var linea = "".PadRight(tam,'*');
            WriteLine(linea);
        }

        public static void WriteTitle(string titulo)
        {
            var tamano = titulo.Length + 4;
            DibujarLinea(titulo.Length+4);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamano);
        }

        public static void Beep(int hz=2000, int tiempo=500, int cantidad=1)
        {
            while (cantidad-- >0)
            {
                System.Console.Beep(hz,tiempo);
            }
        }
    }
}