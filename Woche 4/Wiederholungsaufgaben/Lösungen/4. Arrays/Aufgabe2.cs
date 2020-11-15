using System;

namespace Arrays
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 14, 3, 0};

            var largestElement = GetLargestElement(array);
            
            Console.WriteLine(largestElement);
        }

        static int GetLargestElement(int[] array)
        {
            var largestElement = int.MinValue;

            foreach (var elemet in array)
                if (elemet > largestElement)
                    largestElement = elemet;

            return largestElement;
        }
    }
}
