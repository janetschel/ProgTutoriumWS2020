using System;

namespace Arrays
{
    class Aufgabe5_A
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 2, 4, 4, 5, 7 };
            var found = FindSumInArray(sortedArray, 7);
            Console.WriteLine(found);
        }

        static bool FindSumInArray(int[] array, int sum)
        {
            for (var i = 0; i < array.Length; i++)
                for (var j = i + 1; j < array.Length; j++)
                    if (array[i] + array[j] == sum)
                        return true;

            return false;
        }
    }
}
