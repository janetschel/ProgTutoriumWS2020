using System;

namespace Arrays
{
    class Aufgabe3
    {
        static void Main(string[] args)
        {
            int[] inputFromUser = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.Write("\nZahl: ");
                
                var input = Console.ReadKey().KeyChar.ToString();
                inputFromUser[i] = Convert.ToInt32(input);
            }
            
            // Sortieren des Arrays zum berechnen des Medians
            Array.Sort(inputFromUser);

            var result = 0.0;
            foreach (var element in inputFromUser)
                result += element;

            double middle = result / inputFromUser.Length;
            int midIndex = inputFromUser.Length / 2;
            
            Console.WriteLine($"\nDein Mittelwert ist: {middle}");
            Console.WriteLine($"Dein Median ist: {inputFromUser[midIndex]}");
        }
    }
}
