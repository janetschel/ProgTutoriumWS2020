using System;

namespace Conditional_Statements
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet deine Zahl?: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Deine Zahl ist durch 2 teilbar");
            }
            else
            {
                Console.WriteLine("Deine Zahl ist nicht durch 2 teilbar");
            }
        }
    }
}
