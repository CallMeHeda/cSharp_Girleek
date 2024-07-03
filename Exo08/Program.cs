using System;

namespace Exo08
{
    public class Program
    {
        // Exercice 8: Portée des Variables
        // Variable Globale
        static bool globale = true;
        public static void Main()
        {
            // Variable Locale
            bool sunny = false;

            Console.WriteLine(globale);
            Console.WriteLine(sunny);
        }
    }
}