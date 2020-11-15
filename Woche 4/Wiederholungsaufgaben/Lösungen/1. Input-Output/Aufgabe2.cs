using System;

namespace Input_Output
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            Console.Write("Was lautet deine Zahl?: ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Das Quadrat deiner Zahl ist {number * number}");
        }
    }
}
