using System;

namespace Praktikumsaufgabe3
{
    class PascalscheDreieck
    {
        public static int[] PascalDreieck(int[] f)
        {
            if (f == null || f.Length == 0)
                return new[] {1};

            var resultArray = new int[f.Length + 1];
            
            // das erste und letzte Element ist immer 1
            resultArray[0] = 1;
            resultArray[^1] = 1;
            
            // j als Index ins resultArray
            for (var i = 0; i < f.Length - 1; i++)
                resultArray[i + 1] = f[i] + f[i + 1];

            return resultArray;
        }

        public static void Ausgabe(int[] f)
        {
            foreach (var element in f)
                Console.Write($"{element} ");
            
            Console.WriteLine();
        }
    }
}