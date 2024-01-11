/**
 * Name : Exercice2 : saisi et affichage personnalisé
 * author : FullStack TechBoy
 * date : 10/01/2024
 */

using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables declaration
            string firstName;
            string lastName;
            byte age;

            // Request information from the user

            Console.Write("enter your first name : ");
            firstName = Console.ReadLine();
            Console.Write("enter your last name : ");
            lastName = Console.ReadLine();
            Console.Write("enter your age : ");
            age = byte.Parse(Console.ReadLine());

            // Display
            Console.WriteLine("Hello " + firstName + " " + lastName + " you have " + age + " Years old !!!");

            Console.ReadLine();
        }
    }
}
