using System;

namespace Exo12
{
    public class Program
    {
        public static void Main()
        {
            // Exercice 12: Collections et Génériques
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.AddRange(new int[] { 2, 40, 8, 42, 105 }); // Add pour ajouter un seul nombre et AddRange pour en ajouter plusieurs à la fois

            foreach (int number in listOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}