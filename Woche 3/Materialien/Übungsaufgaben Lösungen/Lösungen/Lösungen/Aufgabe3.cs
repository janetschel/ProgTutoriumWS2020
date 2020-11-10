using System;

namespace Lösungen
{
    public class Aufgabe3
    {
        public static void Execute()
        {
            Console.WriteLine("Gib einen Satz ein:");
            string sentence = Console.ReadLine();
            
            int numberOfVowelsInSentence = CountVowels(sentence);
            
            Console.WriteLine($"Dein Satz hat {numberOfVowelsInSentence} Vokale");
        }

        static int CountVowels(string sentence)
        {
            var numberOfVowels = 0;
            
            foreach (var character in sentence)
            {
                var upperChar = character.ToString().ToUpper();
                if (upperChar == "A" || upperChar == "E" || upperChar == "I" || upperChar == "O" || upperChar == "U")
                {
                    numberOfVowels++;
                }
            }
            
            return numberOfVowels;
        }
    }
}