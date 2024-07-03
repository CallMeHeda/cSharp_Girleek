using System;

namespace Exo01
{
    public class Program
    {
        public static void Main()
        {
            // Exercice 1: Variables et Types de Données
            int nb = 42;
            string hello = "Hello world";
            double nbFloat = 42.42;

            Console.WriteLine("Entier : " + nb + " - Chaine de caractères : " + hello + " - Nombre décimal : " + nbFloat);

            // Exercice 1: Variables et Types de Données - Améliorée
            Console.WriteLine("Entrez un entier :");
            string data = Console.ReadLine();
            nb = int.Parse(data);
            Console.WriteLine("Entrez une chaine de caractères :");
            hello = Console.ReadLine();
            Console.WriteLine("Entrez un nombre décimal :");
            string dataDouble = Console.ReadLine();
            nbFloat = double.Parse(dataDouble);

            Console.WriteLine("Entier : " + nb + " - Chaine de caractères : " + hello + " - Nombre décimal : " + nbFloat);
        }
    }
}