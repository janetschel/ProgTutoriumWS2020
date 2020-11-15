using System;

namespace Weitere_Uebungsaufgaben
{
    class Aufgabe1_1
    {
        static void Main(string[] args)
        {
            var wordToEncrypt = "Zahnarzt";
            var encryptedWord = EncryptWord(wordToEncrypt);
            
            Console.WriteLine($"Dein verschlüsseltes Wort lautet: {encryptedWord}");
        }

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
