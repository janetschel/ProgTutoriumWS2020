using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anlegen eines Integer-Arrays der Länge 10 mit dem Namen numbers
            // Wichtig: in diesem Array dürfen auch nur Integer stehen!
            int[] numbers = new int[10];
            
            // Zuweisen der Werte an den Stellen 1, 2 und 3 (Index 0, 1 und 2, da Arrays in C# 0-indexed sind)
            numbers[0] = 5;
            numbers[1] = 67;
            numbers[2] = 1;

            // Ausgabe des Arrays an der Stelle 7 (Index 6)
            Console.WriteLine(numbers[6]);
            
            /*
             * Anmerkung:
             * numbers[6] wurde von uns NICHT definiert, das Console.WriteLine() gibt aber trotzdem 0 aus.
             * Grund: alle stellen eines Arrays werden mit dem jeweiligen Null-Wert (nicht null) des jeweiligen
             *        Datentypes vorbelegt. Bei Integer ist dieser Wert 0, bei Strings bspw. "" (empty String)
             */
            
            // Anlegen eines Arrays, leichter:
            // Dieser Ansatz ist nur logisch, wenn wir wissen, wie viele Elemente das Array besitzen soll
            int[] numbers2 = {1, 5, 54, 4, 5};
            
            
            // foreach-Schleife
            // Die Schleife geht alle Elemente der Schleife durch, wir müssen nicht mehr selber zählen
            foreach (int element in numbers2)
            {
                Console.WriteLine(element);
            }
            
            // Als normale for-Schleife
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            
            // --------------------------------------------------------------
            // Aufgabe: Berechne den Durchschnitt der Noten

            int[] grades = { 1, 2, 5, 6, 4, 3, 1, 1, 3, 4 };
            int sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            double avg = (double) sum / grades.Length;
            Console.WriteLine($"Der Durchschnitt der Noten ist {avg:0.00}"); // schöne Formatierung
        }
    }
}