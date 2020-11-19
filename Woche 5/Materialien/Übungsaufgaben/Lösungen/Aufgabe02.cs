using System;

namespace Arrays
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 1, 1, 1, 0, 1 };
            int[] secondArray = { 1, 0, 1, 0, 0, 1 };

            var result = AddBinaryNums(firstArray, secondArray, true);
            PrintArray(result);
        }


        static int[] AddBinaryNums(int[] a, int[] b, bool output = false)
        {
            var result = new int[a.Length];

            var carry = 0;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                var currentResult = a[i] + b[i] + carry;

                switch (currentResult)
                {
                    case 2:
                        currentResult = 0;
                        carry = 1;
                        break;
                    case 3:
                        currentResult = 1;
                        carry = 1;
                        break;
                    default:
                        carry = 0;
                        break;
                }

                result[i] = currentResult;
            }
            
            if (output)
                PrintArray(result);
            
            return result;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("{ ");
            foreach (var element in array)
                Console.Write($"{element} ");
            
            Console.WriteLine(" }");
        }
    }
}
