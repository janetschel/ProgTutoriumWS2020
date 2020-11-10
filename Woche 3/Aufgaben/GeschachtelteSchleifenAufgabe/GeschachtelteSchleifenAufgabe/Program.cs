using System;

namespace GeschachtelteSchleifenAufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lass dir folgendes Muster auf der Konsole ausgeben:
             * 1 x 1 = 1
             * 1 x 2 = 2
             * 1 x 3 = 3
             * ...
             * 1 x 9 = 9
             * 1 x 10 = 10
             * 2 x 1 = 2
             * 2 x 2 = 4
             * ...
             * 10 x 9 = 90
             * 10 x 10 = 100
             * 
             */

            // Möglichkeit 1:
            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            
            // Möglichkeit 2:
            for (var i = 0; i <= 10; i++)
                for (var j = 1; j <= 10;)
                    Console.WriteLine($"{i} x {j} = {i * j++}");      
            
            /*
             * Anmerkung:
             * Geschachtelte Schleifen sind mit allen Schleifentypen realisierbar.
             * Die häufigste Variante ist allerdings die for-Schleife.
             */
        }
    }
}