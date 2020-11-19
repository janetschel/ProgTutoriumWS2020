using System;

namespace Arrays
{
    class Aufgabe7_B
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,7];

            Console.Write("Index in erste Dimension: ");
            var firstDim = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Index in zweite Dimension: ");
            var secondDim = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Zahl zum Speichern (1 bis 50): ");
            var numberToSave = Convert.ToInt32(Console.ReadLine());
            
            // [...] der Benutzer [verhält] sich richtig [...] (keine Fehlererkennung nötig).
            // Deshalb haben wir auch keine Schleifen hier

            Console.WriteLine("Array vor dem Speichern:");
            PrintArray(array);
            
            array[firstDim, secondDim] = numberToSave;
            
            Console.WriteLine("\nArray nach dem Speichern:");
            PrintArray(array);
        }

        /// <summary>
        /// Diese Funktion stammt aus Aufgaben 7a) 
        /// </summary>
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
