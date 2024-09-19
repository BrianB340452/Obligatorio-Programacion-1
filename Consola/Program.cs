using Dominio;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();

            MostrarMenu();
            Console.WriteLine();

        }

        static void MostrarMenu()
        {
            MostrarMensajeColor(ConsoleColor.Cyan, "*** MENÚ ***");
        }

        static void MostrarMensajeColor(ConsoleColor color, string mensaje)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}