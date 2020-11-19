using System;

namespace Arrays
{
    class Aufgabe9
    {
        static void Main(string[] args)
        {
            string[,] array = new string[3,3];

            // Insgesamt sind nur 9 Moves möglich
            for (var i = 0; i < 9; i++)
            {
                Console.Write("Index in erste Dimension: ");
                var firstDim = Convert.ToInt32(Console.ReadLine());
            
                Console.Write("Index in zweite Dimension: ");
                var secondDim = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Tic Tac Toe Feld vor dem Zug");
                PrintArray(array);

                if (array[firstDim, secondDim] == null)
                {
                    if (i % 2 == 0)
                        array[firstDim, secondDim] = "O";
                    else
                        array[firstDim, secondDim] = "X";
                }
                else
                {
                    Console.WriteLine("Zug an der Stelle nicht möglich");
                    i--; // Zurücksetzen von i, da Zug nicht valide war
                    continue;
                }
                
                Console.WriteLine("\nTic Tac Toe Feld nach dem Zug");
                PrintArray(array);
            }
        }

        /// <summary>
        /// Diese Funktion stammt aus Aufgaben 7a)
        /// Nur einige Änderungen für string Arrays
        /// </summary>
        static void PrintArray(string[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++) 
                    if (array[i, j] == null)
                        Console.Write($"- ");
                    else
                        Console.Write($"{array[i, j]} ");
                
                Console.WriteLine();
            }
        }
    }
}
