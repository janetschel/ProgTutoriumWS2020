using System;

namespace Schleifen
{
    class Aufgabe7
    {
        static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3, 2};

            Console.WriteLine(HasDuplicates(array1));
        }

        static bool HasDuplicates(int[] number)
        {
            for (var i = 0; i < number.Length; i++)
                for (var j = i + 1; j < number.Length; j++)
                    if (number[i] == number[j])
                        return true;

            return false;
        }
    }
}
