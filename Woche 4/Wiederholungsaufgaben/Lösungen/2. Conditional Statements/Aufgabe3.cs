using System;

namespace Conditional_Statements
{
    class Aufgabe3
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet dein Name?: ");
            var name = Console.ReadLine();

            if (name.ToLower() == "alice" || name.ToLower() == "bob")
            {
                Console.WriteLine($"Hallo {name}!");
            }
            else
            {
                Console.WriteLine("Dich kenne ich nicht!");
            }
        }
    }
}
