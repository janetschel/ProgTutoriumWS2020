using System;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 50;
            
            // Aufgabe: Schreibe eine Funktion, welche diese beiden Nummern miteinander addiert
            //          und das Ergebnis zurückgibt

            // Funktionsaufruf: Name der Funktion und (Paramater der Funktion, getrennt durch Komma)
            int resultOfAddition = AddNumbers(number1, number2);

            Console.WriteLine(resultOfAddition);
            Console.WriteLine($"Die Funktion gibt den Wert ${resultOfAddition} zurück");
            Console.WriteLine($"Und es soll {number1 + number2} sein");
            
            // Überprüfung, ob die Funktion richtig funktioniert
            Console.WriteLine($"{number1 + number2 == resultOfAddition}"); 
        }

        /* Funktionen sind immer gleich aufgebaut:
         * static <Rückgabetyp> <NameDerFunktion>(<Parameter>)
         *
         * Rückgabetyp: Datentyp oder void (void falls die Funktion nichts zurückgibt)
         * NameDerFunktion: beliebiger Name der Funktion
         * Parameter: Parameter sind wie Variablen, welche für nur diese eine Funktion definiert sind
         *            Parameter = <Datentyp> NameDesParameters
         *
         * Parameter können nur innerhalb dieser Funktion benutzt werden und müssen NICHT so heißen,
         * wie die Variablen, welche sie benutzen
         */
        static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
            
            // oder
            // return number1 + number2;
        }
        
        // Funktionen sollten keine "Nebenwirkungen" haben. Sie sollen also immer nur das machen
        // was sie auch nach außen preisgeben. Deshalb ist eine sinnvolle Bezeichnung der Variablen
        // sehr wichtig!
        static void AddNumbersAndPrintResult(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        // Default-Werte von Parametern werden mit einem = <Wert> definiert.
        // Falls die Funktion mit nur dem Parameter number1 aufgerufen wird, wird für number2 automatisch
        // der Wert 10 genommen
        static int AddIntegerNumbers(int number1, int number2 = 10)
        {
            return number1 + number2;
        }
        
        /* Anmerkung zu Paramtern:
         * Bei einem Funktionsaufruf müssen die übergebenen Variablen eigentlich IMMER der Anzahl der
         * definierten Paramter in der Funktion entsprechen (Ausnahme: Default-Werte bei Funktionen)
         * Falls das nicht der Fall ist, gibt es einen Fehler.
         */
    }
}