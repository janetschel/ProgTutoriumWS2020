using System;

namespace Arrays
{
    class Aufgabe4
    {
        static void Main(string[] args)
        {
            int[] mult = { 1, 0, 5, -9, 54, 2, 68, -17, 46, 3};
            MultNeighborsInArray(mult);
        }

        static void MultNeighborsInArray(int[] mult)
        {
            Console.WriteLine("Multiplikation dieses Arrays:");
            
            // Die for-Schleife ist zum Indexing hier zu bevorzugen. for-each funktioniert hier nicht
            // da wir bei dieser nie Zugriff auf das nächste Element hat
            for (var i = 0; i < mult.Length - 1; i++)
            {
                Console.WriteLine($"{mult[i]} x {mult[i + 1]} = {mult[i] * mult[i + 1]}");
            }
            
            // Die Anzahl der Rechenschritte ist ableitbar von der Länge des Arrays
            //           -"-                 ist immer 1 weniger als die Länge des Arrays
            Console.WriteLine($"\nAnzahl Rechenschritte: {mult.Length - 1}");
        }
    }
}
