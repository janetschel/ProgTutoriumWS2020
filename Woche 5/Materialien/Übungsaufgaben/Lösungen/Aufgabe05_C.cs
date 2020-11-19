using System;
using System.Linq;

namespace Arrays
{
    class Aufgabe5_C
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 5, 3, 4, 1, 9, 7 };
            var found = FindSumInArray(unsortedArray, 8);
            Console.WriteLine(found);
            
            // Big O Notation von O(n logn), welches auch gleichzeitig die beste, optimierteste Laufzeit
            // für so ein Programm ist
        }

        static bool FindSumInArray(int[] array, int sum)
        {
            /* Die Idee hier ist nun etwas komplizierter.
             * Wir gehen das Array normal durch und speichern uns die Differenz zur Summe in einem anderen Array.
             * Beispiel:
             * Jetzige Zahl: 5, Summe: 8, Differenz: 3
             *
             * Sobald wir dann diese 3 in dem Array finden, wissen wir, dass es ein Paar gibt (wo auch immer dieses Paar
             * steht) welche zusammen die gewünschte Summe bilden.
             * Dann können wir true zurückgeben.
             *
             * Falls wir auch hier durch das Array durchgelaufen sind, allerdings noch keinen Treffer haben, wissen wir
             * auch hier, dass es keine möglichen Paare gibt.
             */

            // es wird niemals mehr Differenzen geben, also originale Elemente im Array enthalten sind
            var knownDifferencesToSum = new int[array.Length];

            // j als Index in knownDifferencesToSum
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];

                if (knownDifferencesToSum.Contains(currentNumber))
                    return true; // currentNumber ist eine Differenz zur Summe mit einer anderen Zahl bildet
                
                var difference = sum - array[i];
                
                if (!knownDifferencesToSum.Contains(difference))
                    knownDifferencesToSum[j++] = difference; // Inkrementieren von j nur wenn wir ein Element hinzufügen
            }

            // Bisher keine Paare gefunden
            return false;
        }
    }
}
