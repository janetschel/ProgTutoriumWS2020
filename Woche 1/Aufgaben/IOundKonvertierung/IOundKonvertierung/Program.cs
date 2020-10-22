using System;

namespace IOundKonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt"); // Schreibt Inhalt der runden Klammern auf die Konsole
            Console.WriteLine(6); // Hierbei ist der Datentyp egal

            Console.ReadLine(); // Liest die Eingabe des Benutzers als STRING Datentyp von der Console

            string input = Console.ReadLine();
            double inputAsDouble = Convert.ToDouble(input); // Konvertierung gleich zu allen Datentypen
        }
    }
}
