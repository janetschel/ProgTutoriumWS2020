using System;

namespace Praktikumsaufgabe3
{
    public class PrimzahlenAufgabe
    {
        public static int Primzahlen(int n, bool ausgabe = false)
        {
            var primzahlen = new bool[n + 1];

            for (var i = 0; i < primzahlen.Length; i++)
                primzahlen[i] = true; // wir gehen davon aus, dass alles Primzahlen sind

            var numberOfPrime = 0;
            for (var i = 2; i < primzahlen.Length; i++) // Anfang bei 2, da 0 und 1 keine Primzahlen sind
            {
                if (!primzahlen[i]) continue;

                numberOfPrime++;
                
                if (ausgabe)
                    Console.Write($"{i} ");

                // Sieb des Eratosthenes
                for (var j = i + 1; j < primzahlen.Length; j++)
                    if (j % i == 0)
                        primzahlen[j] = false;
            }
            
            // Für letzte Leerzeile
            if (ausgabe)
                Console.WriteLine();
            
            return numberOfPrime;
        }
    }
}