using System;

namespace Schleifen
{
    class Aufgabe8
    {
        static void Main(string[] args)
        {
            var sentence1 = "The quick brown fox jumps over the lazy dog";
            var sentence2 = "Eine Banane ist nicht immer krumm";

            var length1 = GetLongestWordInSentence(sentence1);
            var length2 = GetLongestWordInSentence(sentence2);
            
            Console.WriteLine($"Das längste Wort im ersten Satz hat die Länge {length1}");
            Console.WriteLine($"Das längste Wort im zweiten Satz hat die Länge {length2}");
        }

        static int GetLongestWordInSentence(string sentence)
        {
            string[] words = sentence.Split(" ");

            var longestWordLength = -1;
            foreach (var word in words)
            {
                var currentLength = word.Length;

                if (currentLength > longestWordLength)
                {
                    longestWordLength = currentLength;
                }
            }

            return longestWordLength;
        }
    }
}
