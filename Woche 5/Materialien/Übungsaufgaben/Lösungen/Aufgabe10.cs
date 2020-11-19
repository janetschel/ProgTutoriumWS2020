using System;

namespace Arrays
{
    class Aufgabe10
    {
        static void Main(string[] args)
        {
            int[,] a = {{1, 0, 2}, {4, 2, 8}, {5, 0, 2}};   // new int[3,3];
            int[,] b = {{4, 2, 2}, {0, 0, 3}, {7, 0, 99}};
            
            // Aufruf der Funktion
            var result = Add2DArrays(a, b);
            
            // Anstatt Console.WriteLine(result) benutzen wir eine Custom Print Funktion
            Print2DArray(result);
        }

        static int[,] Add2DArrays(int[,] a, int[,] b)
        {
            // Da die Länge immer 3 ist
            var length = a.GetLength(0);
            
            int[,] result = new int[length, length];

            for (var i = 0; i < length; i++)
                for (var j = 0; j < length; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        static void Print2DArray(int[,] array)
        {
            var length = array.GetLength(0);

            Console.WriteLine("{");
            
            for (var i = 0; i < length; i++)
            {
                Console.Write("  { ");
                
                for (var j = 0; j < length; j++)
                    Console.Write($"{array[i, j]} ");
                
                Console.WriteLine("}");
            }
            
            Console.WriteLine("}");
        }
    }
}
