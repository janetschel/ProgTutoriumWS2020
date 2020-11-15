using System;

namespace Weitere_Uebungsaufgaben
{
    class Aufgabe1_3
    {
        static void Main(string[] args)
        {
            var result1 = CalculateSecretKey("banane", "EDQDQH");
            var result2 = CalculateSecretKey("banane", "VUHUHY");
            
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static int CalculateSecretKey(string plaintext, string encryptedWord)
        {
            for (var i = 2; i < 27; i++)
            {
                var encryptedWordWithKey = EncryptWord(plaintext, i);
                
                if (encryptedWordWithKey == encryptedWord)
                {
                    return i;
                }
            }
            
            // Kein passender Key gefunden
            return 0;
        }
        
        /// <summary>
        /// Diese Funktion stammt aus Aufgabe 1.1.
        /// Einzige Änderung ist, dass nicht mehr immer mit 3 verschlüsselt wird, sondern mit einem variablen Key
        /// </summary>
        static string EncryptWord(string wordToEncrypt, int key)
        {
            var encryptedWord = "";
            foreach (var character in wordToEncrypt.ToUpper())
            {
                var asciiRepresentation = (int) character;
                var shiftedAscii = asciiRepresentation + key;

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
