using System;

namespace Arrays
{
    class Aufgabe8
    {
        static void Main(string[] args)
        {
            // Beispiel Array zum Testen
            int[][] array =
            {
                new[] {1, 5, 7, 9, 2},
                new[] {6, 34, 2, 4, 9, 34, 2, 4, 9},
                new[] {87, 34, 90, 3, 345, 3, 3},
                new[] {77, 54, 5, 1, 8, 7, 7, 7, 7, 7, 7, 7, 100},
            };
            
            PrintRowOf2DArray(array, 2);
        }

        static void PrintRowOf2DArray(int[][] arrayToPrint, int row)
        {
            int[] rowToPrint = arrayToPrint[row];

            Console.Write("{ ");
            foreach (var element in rowToPrint)
                Console.Write($"{element} ");
            
            Console.WriteLine("}");
        }
    }
}
