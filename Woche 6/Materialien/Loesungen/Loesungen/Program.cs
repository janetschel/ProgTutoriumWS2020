using System;

namespace Loesungen
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvxyz";
            char searchedChar = 'z';
            
            int withLoop = GetPositionInStringWithLoop(alphabet, searchedChar);
            int withoutLoop = GetPositionInStringWithoutLoop(alphabet, searchedChar);
         
            Console.WriteLine(withLoop);
            Console.WriteLine(withoutLoop);
            
            // Überprüfung, ob das Gleiche Ergebnis rauskommt
            Console.WriteLine(withLoop == withoutLoop);
        }

        static int GetPositionInStringWithLoop(string word, char character)
        {
            string lowerCaseWord = word.ToLower();
            char lowerCaseChar = Char.ToLower(character);

            for (int i = 0; i < lowerCaseWord.Length; i++)
                if (lowerCaseWord[i] == lowerCaseChar)
                    return i + 1;
            
            // Not found
            return -1;
        }

        static int GetPositionInStringWithoutLoop(string word, char character)
        {
            string lowerCaseWord = word.ToLower();
            char lowerCaseChar = Char.ToLower(character);

            return lowerCaseWord.IndexOf(lowerCaseChar) + 1;
        }
    }
}
