using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6; // Integer = Ganzzahl, keine Kommazahlen
            int number2 = 6.2; // funktioniert NICHT, Gleitkommazahl keine Ganzzahl
            int number3 = Convert.ToDouble(6); // auch wenn 6 nicht aussieht wie ein double -> Convert.ToDouble() konvertiert die 6 in 6.0 -> Error

            double number4 = 6.2; // Gleitkommazahl
            double number5 = 6; // geht genauso. Für C# -> 6.0

            char character = 'A'; // Einzelne Zeichen
            char character2 = 'AB'; // Funktioniert nicht, mehr als ein Zeichen

            string word = "String is a word"; // Zeichenketten
            string word2 = "A"; // Einzelnes Zeichen als String funktioniert genauso

            var someType = 6; // Inferiert den Datentyp vom rechten Teil der Expression
            someType = 7; // Überschreiben mit GLEICHEM DATENTYP möglich
            someType = "8"; // Überschreiben mit ANDEREM DATENTYP nicht möglich

            const double vat = 0.19; // Variablen mit const können nicht mehr überschreiben werden
            vat = 0.16; // Fehler

            const var errorType = 0; // var Variablen können NICHT const sein

            // Bool (booleans) sind die einfachsten Datentypen. Entweder sind sie true (wahr) oder false (falsch)
            bool boolTrue = true;
            bool boolFalse = false;

            bool concat = boolTrue && boolFalse; // Booleans können zusammengefügt werden (nicht nur in ifs, sondern auch in anderen Variablen)

            // && ist ein und -> beide booleans müssen wahr sein, damit alles wahr ist
            // || ist ein oder (kein entweder oder) -> einer von beiden, oder beide (mindestens einer), von beiden booleans müssen wahr sein, damit alles wahr ist
            // Bei einer Überprüfung wird solange überprüft, bis die Möglichkeit besteht, dass die Expression noch true sein könnte
            // a && b, falls a = false, dann wird b nicht überprüft - a || b, falls a = false, dann wird b überprüft (könnte ja noch true sein)
        }
    }
}
