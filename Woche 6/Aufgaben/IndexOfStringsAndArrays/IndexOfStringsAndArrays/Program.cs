using System;

namespace IndexOfStringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ein String ist eigentlich eine Liste aus mehreren Charactern
            // String -> Char Array
            // Das ist auch der Grund, warum ein String eine .Length Eigenschaft hat, da es intern wie ein Array
            // behandelt wird
            string helloString = "Hello World!";

            // .ToCharArray() wandelt einen String in ein Char Array um
            char[] helloStringAsArray = helloString.ToCharArray();
            
            // Das Char Array kann jetzt ganz normal durchlaufen werden
            for (int i = 0; i < helloStringAsArray.Length; i++)
            {
                Console.Write(helloStringAsArray[i]);
                Console.Write(helloString[i]); // kommt aufs Gleiche raus, da String = char[]
            }
            
            // Man kann sich den String auch wieder aus dem Char Array zusammenbauen
            string helloStringFromCharArray = "";

            foreach (var currentChar in helloStringAsArray)
            {
                helloStringFromCharArray += currentChar;
            }
            
            Console.WriteLine(); // Leerzeile

            // Alle 3 Ausgaben sind das Gleiche
            Console.WriteLine(helloString);
            Console.WriteLine(helloStringAsArray);
            Console.WriteLine(helloStringFromCharArray);
            
            Console.WriteLine(); // Leerzeile
            
            // Um herauszufinden, an welcher Stelle sich ein char in einem String befindet benutzt man die Methode
            // .IndexOf();

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            // Ich will nun wissen, an welcher Stelle sich das d im Alphabet befindet
            int indexOfCharD = alphabet.IndexOf('d') + 1; // +1 nötig, da bei 0 angefangen wird zu zählen

            Console.WriteLine($"Index of D: {indexOfCharD}");
        }
    }
}