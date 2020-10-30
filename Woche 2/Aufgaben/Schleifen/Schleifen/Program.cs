using System;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            // For-Schleife, zählt selbst
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            // while-Schleife
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            
            // do-While Schleife
            // Unterschied zur while-Schleife: läuft erst und überprüft dann die Bedingung -> auch wenn die Bedingung
            // falsch ist, wird die Schleife ausgeführt

            int k = 0;
            do
            {
                Console.WriteLine(k);
                
                // k++;
            } while (k++ < 10);


            // "Problem" bei while- und do-while-Schleifen: es muss selber gezählt werden, was schnell vergessen wird
        }
    }
}