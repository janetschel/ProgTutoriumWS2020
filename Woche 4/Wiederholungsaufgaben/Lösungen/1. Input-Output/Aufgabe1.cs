using System;

namespace Input_Output
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            Console.Write("Was ist dein Name?: ");
            var name = Console.ReadLine();
            
            Console.Write("Was ist dein Alter?: ");
            var age = Console.ReadLine(); // Convert.ToInt32() nicht nötig
            
            Console.WriteLine($"Hallo, {name}! Du bist {age} Jahre alt.");
        }
    }
}
