using System;

namespace Arrays
{
    class Aufgabe5_D
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 2, 4, 4, 5, 7 };
            var indices = FindSumInArray(sortedArray, 8);
            
            Console.WriteLine($"Erste Index: {indices[0]}");
            Console.WriteLine($"Erste Index: {indices[1]}");
        }

        static int[] FindSumInArray(int[] array, int sum)
        {
            int[] indices = {-1, -1}; // falls kein Paar bekannt ist, geben wir als Fehlerzustand den Index -1 zurück

            for (var i = 0; i < array.Length; i++)
                for (var j = i + 1; j < array.Length; j++)
                    if (array[i] + array[j] == sum)
                        return new[] {i, j};
            
            return indices;
        }
    }
}
