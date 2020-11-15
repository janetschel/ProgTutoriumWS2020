using System;

namespace Arrays
{
    class Aufgabe3
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 14, 3, 0};

            PrintArrayReversed(array);
        }

        static void PrintArrayReversed(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write($"{array[i]} ");
        }
    }
}
