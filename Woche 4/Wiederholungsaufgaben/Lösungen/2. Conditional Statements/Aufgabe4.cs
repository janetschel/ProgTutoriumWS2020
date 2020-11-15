using System;

namespace Conditional_Statements
{
    class Aufgabe4
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet dein Jahr?: ");
            var year = Convert.ToInt32(Console.ReadLine());

            var yearIsALeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (yearIsALeapYear)
            {
                Console.WriteLine($"Das Jahr {year} ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine($"Das Jahr {year} ist kein Schaltjahr");
            }
        }
    }
}
