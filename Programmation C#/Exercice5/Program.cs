/**
 * Exercice5 : Test Majeur, Mineure
 * author : Full Stack TechBoy
 * date : 10/01/2024
 */

using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            int age=0;

            // Saisir de l'age
            Console.Write("Entrer votre age: ");
            age = int.Parse(Console.ReadLine());

            // Afficharge
            if (age >= 18)
            {
                Console.Write("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineure");

                Console.Write("Vous serez majeur dans : " +(18 - age)+ " an(s) !");
            }

            Console.ReadLine();
        }
    }
}
