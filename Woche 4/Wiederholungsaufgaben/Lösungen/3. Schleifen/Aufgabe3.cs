using System;

namespace Schleifen
{
    class Aufgabe3
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 12; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}
