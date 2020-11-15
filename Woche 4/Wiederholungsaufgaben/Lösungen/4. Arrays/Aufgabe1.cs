using System;

namespace Arrays
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet dein Satz?: ");
            var sentence = Console.ReadLine();

            var numberOfChars = 0;
            foreach (var charachter in sentence)
            {
                if (charachter != ' ')
                {
                    numberOfChars++;
                }
            }
            
            Console.WriteLine($"Dein Satz hat {numberOfChars} Zeichen");
        }
    }
}
