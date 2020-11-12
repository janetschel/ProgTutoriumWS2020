using System;

namespace ErweitereFunktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 9;
            
            Console.WriteLine($"Before update {number}");
            
            // Mit einer ref (oder out-)-Übergabe können Variablen von einer Funktion verändert werden, auch ohne return
            // Bei der Übergabe muss das Keyword mit spezifiziert werden
            IncrementValue(ref number);
            
            Console.WriteLine($"After update {number}");
        }

        /*
         * ref verändert das Verhalten eines Paramters
         * Normalerweise sind Paramter immer call-by-value, heißt: der Wert einer Variable wird kopiert und die Kopie
         * wird der Funktion übergeben. Diesse Kopie hat keine Einwirkungen auf die originale Variable.
         * Dies hat zur Folge, dass die originale Variable nicht verändert wird.
         *
         * Mit dem ref-Keyword wird die Variable mit call-by-reference übergebn, also einfach gesprochen: die
         * eigentliche Variable wird übergeben. Somit kann diese Variable von innerhalb der Funktion auch nach außen hin
         * gesetzt werden.
         *
         * Bei out muss der Wert gesetzt werden, bei ref ist das setzten eines Wertes freiwillig.
         *
         * Vorteil: eine Funktion soll mehrere Variablen ändern und zurückgeben -> mit return nicht möglich
         *
         * Definieren eines out bzw. ref Parameters:
         * <ref | out> <Datentyp> <Name>
         */
        static void IncrementValue(ref int number)
        {
            number++;
        }
    }
}