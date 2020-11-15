using System;

namespace Input_Output
{
    class Aufgabe3
    {
        static void Main(string[] args)
        {
            Console.Write("Was lautet die Höhe?: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Was lautet die Breite?: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var circumference = 2 * height + 2 * width;
            var area = height * width;
            
            Console.WriteLine($"Der Umfang ist {circumference}");
            Console.WriteLine($"Der Flächeninhalt ist {area}");
        }
    }
}
