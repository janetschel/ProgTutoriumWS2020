using System;

namespace Lösungen
{
    public class Aufgabe5
    {
        public static void Execute()
        {
            Console.WriteLine("Gib eine Zahl ein:");

            var inputFromUser = Console.ReadLine();
            var number = Convert.ToInt32(inputFromUser);

            if (number < 0 || number > 999999)
                Console.WriteLine("Nummer ist nicht innerhalb der Begrenzung von 0 bis 999.999");

            var validNumber = IsValidNumber(number);

            if (validNumber)
                Console.WriteLine("Diese Zahl ist valide!");
            else
                Console.WriteLine("Diese Zahl ist nicht valide!");
        }

        static bool IsValidNumber(int number)
        {
            var numberAsString = Convert.ToString(number);

            if (numberAsString.Length < 6 || numberAsString.Length > 6)
                return false; // Zahl muss 6-stellig sein

            bool hasDoubleDigit = false;
            var lastDigit = number % 10;

            for (var i = number / 10; i > 0; i /= 10)
            {
                // Kriterium: von links nach rechts aufsteigend sortiert
                var currentDigit = i % 10;
                if (currentDigit > lastDigit)
                    return false;

                // Kriterium: mindestens eine doppelte Zahl
                if (currentDigit == lastDigit)
                    hasDoubleDigit = true;

                lastDigit = currentDigit;
            }

            return hasDoubleDigit;
        }
    }
}