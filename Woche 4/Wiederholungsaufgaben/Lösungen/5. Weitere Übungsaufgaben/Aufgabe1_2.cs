using System;

namespace Weitere_Uebungsaufgaben
{
    class Aufgabe1_2
    {
        static void Main(string[] args)
        {
            var sentenceToEncrypt = "The quick brown fox jumps over the lazy dog";
            var encryptedSentence = EncryptSentence(sentenceToEncrypt);
            
            Console.WriteLine($"Dein verschlüsseltes Satz lautet: {encryptedSentence}");
        }

        static string EncryptSentence(string sentenceToEncrypt)
        {
            var wordsToEncrypt = sentenceToEncrypt.Split(" ");

            var encryptedSentence = "";
            foreach (var word in wordsToEncrypt)
            {
                encryptedSentence += $"{EncryptWord(word)} ";
            }

            return encryptedSentence;
        }
        

        /// <summary>
        /// Diese Funktion stammt aus Aufgabe 1.1
        /// </summary>
        static string EncryptWord(string wordToEncrypt)
        {
            var encryptedWord = "";
            foreach (var character in wordToEncrypt.ToUpper())
            {
                var asciiRepresentation = (int) character;
                var shiftedAscii = asciiRepresentation + 3;

                // Verhindern eines Overflows. Siehe ASCII table
                if (shiftedAscii > 90)
                    shiftedAscii -= 26;

                var shiftedCharacter = (char) shiftedAscii;
                encryptedWord += shiftedCharacter;
            }

            return encryptedWord;
        }
    }
}
