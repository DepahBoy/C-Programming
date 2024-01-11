/**
 * Exercice 4 : Calcul du prix TTC
 * author : FullStack TechBoy
 * date : 10/01/2024
 * */

using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            float prixHt;
            float tauxTva;

            // Saisi d'Informations
            Console.Write("Entrer le prix Ht: ");
            prixHt = float.Parse(Console.ReadLine());
            Console.Write("entrer le taux de TVA en pourcentage(ex 20): ");
            tauxTva = float.Parse(Console.ReadLine());

            // Calcul du prix TTC
            
            Console.Write("Le prix TTC = " + (prixHt * (1 + (tauxTva / 100))));


            Console.ReadLine();
        }
    }
}
