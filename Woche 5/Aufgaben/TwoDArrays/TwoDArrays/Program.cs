using System;

namespace TwoDArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D
            int[,] a =
            {
                {1, 2, 3, 4},
                {10, 20, 30, 40},
                {65, 93, 7, 8}
            };

            int counter = 1;
            foreach (var element in a)
            {
                Console.Write($"{element} ");
                counter++;
                if (counter == a.GetLength(1))
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int column = 0; column < a.GetLength(1); column++)
                {
                    Console.Write(a[row,column] + " ");
                }
                
                Console.WriteLine();
            }
            
            // ausgefranstes 2D
            int[][] b = 
            {
                new []{1, 2, 3},
                new []{1, 2, 3, 60, 50},
                new []{1}
            };

            foreach (var array in b)
            {
                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }
                
                Console.WriteLine();
            }

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}