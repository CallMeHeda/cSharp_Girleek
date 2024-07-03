using System;

namespace Exo9
{
    public class Program
    {
        // Exercice 9: Programmation Orientée Objet
        class Animal
        {
            public string Nom;
        }
        public static void Main()
        {
            Animal lion = new Animal();
            lion.Nom = "Simba";
            Console.WriteLine(lion.Nom);
        }
    }
}