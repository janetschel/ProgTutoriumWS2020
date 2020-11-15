using System;

namespace Schleifen
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            var j = 1;
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            var k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 100);
        }
    }
}
