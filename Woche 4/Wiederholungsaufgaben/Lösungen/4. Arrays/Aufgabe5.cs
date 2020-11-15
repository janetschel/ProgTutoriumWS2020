using System;

namespace Arrays
{
    class Aufgabe5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("otto"));
            Console.WriteLine(IsPalindrome("Otto"));
            Console.WriteLine(IsPalindrome("Peter"));
        }

        static bool IsPalindrome(string word)
        {
            var lowercasedWord = word.ToLower();

            var reversedString = "";
            for (var i = word.Length - 1; i >= 0; i--)
                reversedString += lowercasedWord[i];

            return reversedString == lowercasedWord;
        }
    }
}
