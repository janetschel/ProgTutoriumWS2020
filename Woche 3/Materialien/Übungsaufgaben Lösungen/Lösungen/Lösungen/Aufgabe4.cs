using System;

namespace Lösungen
{
    public class Aufgabe4
    {
        public static void Execute()
        {
            Console.WriteLine("Wie groß soll dein Weihnachtsbaum sein?");
            int heightOfTree = Convert.ToInt32(Console.ReadLine());

            if (heightOfTree == 0)
                PrintTree(5);
            else
                PrintTree(heightOfTree);
            
            // oder (mit Ternary-Statement):
            // PrintTree(heightOfTree == 0 ? 5 : heightOfTree);
            
            // mehr zu Ternary:
            // https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/conditional-operator
        }

        static void PrintTree(int height)
        {
            for (var i = 1; i <= height; i++)
            {
                var numberOfSpaces = height - i;
                    
                for (var k = 0; k <= numberOfSpaces; k++)
                    Console.Write(" ");
                
                for (var j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}