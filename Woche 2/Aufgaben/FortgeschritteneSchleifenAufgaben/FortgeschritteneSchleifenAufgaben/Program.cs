using System;

namespace FortgeschritteneSchleifenAufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1:
            // Erstelle ein Programm, welche die Anzahl der geraden und ungeraden Ziffern in einer 
            // gegebenen Zahl zählt

            var number = 535730968; // gerade: 3, ungerade: 6

            var numberOfEvenDigits = 0;
            var numberOfOddDigits = 0;
            
            for (; number != 0; number /= 10)
            {
                if (number % 10 % 2 == 0)
                {
                    numberOfEvenDigits++;
                }
                else
                {
                    numberOfOddDigits++;
                }
            }

            Console.WriteLine(numberOfEvenDigits);
            Console.WriteLine(numberOfOddDigits);
            
            
            // Aufgabe 2:
            // Schreibe eine Schleife, welche die erste und die letzte Ziffer einer Zahl miteinander
            // multipliziert

            var numberToMultiply = 68399214;
            var lastDigitOfNumber = numberToMultiply % 10;
            var currentDigit = 0;
            
            while (numberToMultiply > 0) // geht auch ... != 0
            {
                currentDigit = numberToMultiply % 10;
                numberToMultiply /= 10;
            }
            
            // an dieser Stelle hat currentDigit den Wert der ersten Ziffer unserer Zahl
            Console.WriteLine(currentDigit * lastDigitOfNumber);
            
            
            // Aufgabe 3:
            // Schreibe eine Schleife, welche alle echten Teiler (% teiler == 0) einer Zahl heraussucht
            // echte Teiler: ein Teiler, welche die Zahl ohne Rest teilt

            Console.WriteLine("---- Echte Teiler ----");
            
            int number2 = 3587;
            int sumOfDividers = 0;
            
            // wir fangen bei i = 2 an, weil:
            //        - durch 0 darf man nicht teilen
            //        - durch 1 ist jede Zahl teilbar..
            for (int i = 2; i < number2; i++)
            {
                if (number2 % i == 0) // anders gesagt: falls i unsere Zahl ohne Rest teilt -> echter Teiler
                {
                    Console.WriteLine(i); // Ausgabe des echten Teilers
                    sumOfDividers += i;
                }
            }

            Console.WriteLine("Summe der echten Teiler: " + sumOfDividers);
        }
    }
}