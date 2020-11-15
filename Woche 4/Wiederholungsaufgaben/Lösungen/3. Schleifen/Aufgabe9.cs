using System;

namespace Schleifen
{
    class Aufgabe9
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumOfDigitsInNumber(123));
            Console.WriteLine(GetSumOfDigitsInNumber(1337));
        }

        static int GetSumOfDigitsInNumber(int number)
        {
            var sum = 0;

            foreach (var character in number.ToString())
            {
                // char.ToString() nötig, weil Convert.ToInt32(char) -> ASCII representation
                var digit = Convert.ToInt32(character.ToString());
                sum += digit;
            }

            return sum;
        }
    }
}
