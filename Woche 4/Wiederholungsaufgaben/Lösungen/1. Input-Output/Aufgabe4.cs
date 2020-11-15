using System;

namespace Input_Output
{
    class Aufgabe4
    {
        static void Main(string[] args)
        {
            Console.Write("Was lautet der Radius?: ");
            var radius = Convert.ToInt32(Console.ReadLine());

            const double pi = Math.PI; // oder einfach PI selbstständig hinschreiben

            var circumference = 2 * radius * pi;
            var area = radius * radius * pi;
            
            Console.WriteLine($"Der Umfang ist {circumference}");
            Console.WriteLine($"Der Flächeninhalt ist {area}");
        }
    }
}
