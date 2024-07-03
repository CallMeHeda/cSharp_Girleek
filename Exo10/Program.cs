using System;

namespace Exo10
{
    public class Program
    {
        // Exercice 10: Concepts Orientés Objet
        class Animal
        {
            public string Nom;
            public void FaireDuBruit(string noise)
            {
                Console.WriteLine(noise);
            }
        }
        public static void Main()
        {
            Animal cat = new Animal();
            cat.FaireDuBruit("Miaou");
        }
    }
}