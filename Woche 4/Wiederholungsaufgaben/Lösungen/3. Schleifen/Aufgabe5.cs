using System;

namespace Schleifen
{
    class Aufgabe5
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl ein: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var primeNumber = true;
            for (var i = 2; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    primeNumber = false;
                    break;
                }
            }

            Console.WriteLine(primeNumber ? "Deine Zahl ist eine Primzahl" : "Deine Zahl ist keine Primzahl");
            
            /*
            // oder mit if-Statement
            
            if (primeNumber)
                Console.WriteLine("Deine Zahl ist eine Primzahl");
            else
                Console.WriteLine("Deine Zahl ist keine Primzahl");
            */
        }
    }
}
