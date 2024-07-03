using System;

namespace Exo4
{
    public class Program
    {
        public static void Main()
        {
            // Exercice 4: Structures de Contrôle
            int nb;

            Console.WriteLine("Entrez un nombre :");
            string data = Console.ReadLine();
            nb = int.Parse(data);

            while (nb != 0)
            {
                if (nb > 0)
                {
                    Console.WriteLine("Le nombre : " + nb + " est positif");
                }
                else
                {
                    Console.WriteLine("Le nombre : " + nb + " est négatif");
                }

                Console.WriteLine("Entrez un nombre :");
                data = Console.ReadLine();
                nb = int.Parse(data);
            }
        }
    }
}