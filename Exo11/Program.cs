using System;

namespace Exo11
{
    public class Program
    {
        public static void Main()
        {
            // Exercice 11: Gestion des Exceptions
            try
            {
                Console.WriteLine("Entrez le premier nombre :");
                string data1 = Console.ReadLine();
                double nb1 = double.Parse(data1);

                Console.WriteLine("Entrez le deuxième nombre :");
                string data2 = Console.ReadLine();
                double nb2 = double.Parse(data2);

                if (nb2 == 0)
                {
                    Console.WriteLine("Erreur : Division par zéro.");
                }
                else
                {
                    double result = nb1 / nb2;
                    Console.WriteLine("Le résultat : " + result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}