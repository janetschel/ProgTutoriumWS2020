using System;

namespace Lösungen
{
    public class Aufgabe2
    {
        public static void Execute()
        {
            var random = new Random();
            int randomNumber = random.Next(0, 101); // 101 weil exklusive

            Console.WriteLine("Der Computer hat eine zufällige Zahl ausgewählt.");

            int guess;
            int guessCount = 0;
            do
            {
                Console.WriteLine("Dein Tipp:");
                guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess < randomNumber)
                    Console.WriteLine("Deine geratene Zahl ist zu klein");
                else if (guess > randomNumber)
                    Console.WriteLine("Deine geratene Zahl ist zu groß");
                
                guessCount++;

            } while (guess != randomNumber);

            Console.WriteLine($"Gewonnen! ({guessCount} Versuche)");
            
            /* Extra-Frage:
             * Ja es gibt einen optimalen Weg.
             * Der User fängt bei 50 (Hälfte der Werte) mit dem Raten an.
             * Falls die Zahl zu groß ist, sind alle Werte über 50 zu groß, und diese müssen nicht mehr
             * beachtet werden.
             * -> Der User betrachtet nun 0 bis 50 als neue Werte und nimmt davon wieder die Hälfte als seinen
             *    nächsten Versuch (hier: 25)
             *
             * Das geht so weiter, bis der User die Zahl erraten hat
             */
        }
    }
}