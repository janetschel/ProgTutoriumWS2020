using System;

namespace Schleifen
{
    class Aufgabe6
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl ein: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorialOfNumber = CalculateFactorial(number);
            
            Console.WriteLine($"Die Fakultät von {number} ist {factorialOfNumber}");
        }

        static int CalculateFactorial(int number)
        {
            var result = 1;

            for (var i = 2; i <= number; i++)
                result *= i;

            return result;
        }
    }
}
