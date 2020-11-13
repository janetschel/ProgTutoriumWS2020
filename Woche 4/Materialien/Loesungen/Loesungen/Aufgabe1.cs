using System;

namespace Loesungen
{
    public class Aufgabe1
    {
        public static void Execute()
        {
            var grades = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.Write("Gib eine Note ein: ");
                var input = Console.ReadLine();

                // Inline Deklaration der out-Variable
                // Oder: int output;
                var validNumber = int.TryParse(input, out var output);

                if (!validNumber)
                    i--; // Zurücksetzen der Zählvariable, weil ungültige Eingabe erkannt wurde
                else
                    grades[i] = output;
            }
            
            Console.WriteLine("Folgende Noten wurden eingegeben:");

            for (var i = 1; i <= 6; i++)
                Console.WriteLine($"{i}: {CountNumberInArray(grades, i)} mal");
            
            Console.WriteLine(); // Leerzeile
            Console.WriteLine($"Der Durchschnitt dieser Noten ist: {GetAverageOfIntegerArray(grades)}");
        }

        static double GetAverageOfIntegerArray(int[] array)
        {
            var result = 0.0;

            foreach (var element in array)
                result += element;

            return result / array.Length;
        }

        static int CountNumberInArray(int[] array, int numberToCount)
        {
            var numberOfElementsInArray = 0;
            foreach (var currentNumber in array)
                if (currentNumber == numberToCount)
                    numberOfElementsInArray++;

            return numberOfElementsInArray;
        }
    }
}