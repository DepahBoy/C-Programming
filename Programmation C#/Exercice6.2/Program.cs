/**
 * Exercie6.2 : test Imbriqué deuxième possibilitée
 * author : FullStack TechBoy
 * date : 11/01/2024
 */

using System;

namespace Exercice6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            double note;

            // saisi de la note par l'utilisateur
            Console.Write("Entrer la note de l'étudiant: ");
            note = double.Parse(Console.ReadLine());

            //Traitement
            if (note < 10)
            {
                Console.Write("Recallé(e) !");
            }
            else
            {
                if(note < 12)
                {
                    Console.Write("Mention Passable!!!");
                }
                else if(note < 14)
                {
                    Console.Write("Mention Assez-Bien!!!");
                }
                else if(note < 16)
                {
                    Console.Write("Mention Bien!!!");
                }
                else
                {
                    Console.Write("Mention Très Bien !!!");
                }
            }

            Console.ReadLine();
        }
    }
}
