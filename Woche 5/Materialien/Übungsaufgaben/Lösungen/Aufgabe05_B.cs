using System;

namespace Arrays
{
    class Aufgabe5_B
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 2, 4, 4, 5, 7 };
            var found = FindSumInArray(sortedArray, 7);
            Console.WriteLine(found);
        }

        static bool FindSumInArray(int[] array, int sum)
        {
            /* Idee ist es nun, zwei Pointer in das Array zu haben.
             * Pointer Nummer 1 startet am Anfang des Arrays, Pointer 2 am Ende.
             * Die Werte, auf welche die Pointer zeigen, werden zusammen addiert und ausgewertet.
             * Da das Array sortiert ist, wissen wir:
             *     - wenn die Summe kleiner ist, als die gesuchte Summe, müssen wir den Start-Pointer um ein Feld
             *       nach rechts verschieben (Summe MUSS größer werden)
             *     - wenn die Summe größer ist, als die gesuchte Summe, muss der End-Pointer eins nach links verschoben
             *       werden. So wird in jedem Fall die Summe kleiner
             *
             * Dies wird solange wiederholt, bis die Pointer sich überschneiden.
             * Wenn bis dahin kein Paar gefunden wird, wird auch weiterhin kein Paar gefunden, da es ja die gleiche
             * Operation ist, nur die Pointer sind einmal "vertauscht" wurden.
             */

            var startPointer = 0;
            var endPointer = array.Length - 1;

            while (startPointer < endPointer)
            {
                var currentSum = array[startPointer] + array[endPointer];

                if (currentSum == sum)
                    return true;
                
                if (currentSum < sum)
                    startPointer++;
                else // currentSum > sum
                    endPointer--;
            }

            return false;
        }
    }
}
