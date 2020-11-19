using System;

namespace Arrays
{
    class Aufgabe7_A
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,7];

            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++) 
                    Console.Write($"{array[i, j]} ");
                
                Console.WriteLine();
            }
        }
    }
}
