using System;

namespace Arrays
{
    class Aufgabe4
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 14, 3, 0};

            Console.WriteLine(SearchElementInArray(array, 3));
            Console.WriteLine(SearchElementInArray(array, 5));
        }

        static bool SearchElementInArray(int[] array, int searchedElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (searchedElement == array[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
