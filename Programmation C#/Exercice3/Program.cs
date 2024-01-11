/**
 * Exercice 3 : saisi, afficharge et calcul
 * author : FullTack TechBoy
 * date : 10/01/2024
 */

using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            double sommeNotes;
            int nombreNotes;

            // saisi d'informations
            Console.Write("Entrer la somme des notes: ");
            sommeNotes = double.Parse(Console.ReadLine());
            Console.Write("Entrer le nombre de notes : ");
            nombreNotes = int.Parse(Console.ReadLine());

            // calcul et afficharge de la moyenne!
            double moyenne = sommeNotes/nombreNotes;
            Console.Write("La moyenne = "+moyenne);

            Console.ReadLine();
        }
    }
}
