using System;

namespace Schleifen
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet deine Zahl?: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var resultFor = 0;
            for (var i = 1; i <= number; i++)
            {
                resultFor += i;
            }

            var resultWhile = 0;
            var j = 1;
            while (j <= number)
            {
                resultWhile += j;
                j++;
            }

            var resultDoWhile = 0;
            var k = 1;
            do
            {
                resultDoWhile += k;
                k++;
            } while (k <= number);

            Console.WriteLine(resultFor);
            Console.WriteLine(resultWhile);
            Console.WriteLine(resultDoWhile);
        }
    }
}
