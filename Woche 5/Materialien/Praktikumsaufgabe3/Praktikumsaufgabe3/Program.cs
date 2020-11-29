using System;

namespace Praktikumsaufgabe3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1 und 2
            Console.WriteLine("\nAufgabe 1 und 2:");
            
            var newRow = PascalscheDreieck.PascalDreieck(new[] {1, 3, 3, 1});
            PascalscheDreieck.Ausgabe(newRow);
            
            // Aufgabe 3
            Console.WriteLine("\nAufgabe 3:");

            var numberOfPrimes = PrimzahlenAufgabe.Primzahlen(11, true);
            Console.WriteLine($"Anzahl Primzahlen von 0..11 (inklusive): {numberOfPrimes}");
            
            var numberOfPrimes2 = PrimzahlenAufgabe.Primzahlen(1337);
            Console.WriteLine($"\nAnzahl Primzahlen von 0..1337 (inklusive): {numberOfPrimes2}");
        }
    }
}