using System;

namespace Schleifenaufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1
            // Gebe jede gerade Zahl zwischen 1 und 100 (inklusive) aus
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            // jede gerade Zahl -> jede zweite Zahl
            for (int j = 0; j < 101; j += 2) // wenn wir so zählen wird sowieso nur jede zweite Zahl genommen
            {
                Console.WriteLine(j);
            }
            
            
            // Aufgabe 2: Berechne die Fakultät einer Zahl
            int number = 6;
            int result = 1;

            while (number > 0)
            {
                result *= number--; // -- nach einer Variable -> erst Berechnung ausführen, dann runterzählen
                // number--; // oder: number = number - 1; oder number -= 1;
            }

            Console.WriteLine(number);

            
            // Aufgabe 3:
            // Ausgeben von allen Zahlen zwischen 0 und 100 (inklusive) mit FizzBuzz
            // Falls die Zahl durch 3 teilbar ist, gebe Fizz aus
            //          ---         5      ---          Buzz
            //          ---        15      ---          FizzBuzz
            // sonst die Zahl an sich

            for (int count = 0; count <= 100; count++)
            {
                if (count % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (count % 5 == 0) // else if sehr wichtig hier, da sonst alle ifs ausgeführt werden
                {
                    Console.WriteLine("Buzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(count);
                }
            }
            
            
            // Aufgabe 4:
            // Berechne die Summe aller Zahlen von 0 bis n (inklusive)
            // Das wäre die Fakultät, nur anstatt zu multiplizieren mit addieren

            int numberToAdd = 100;
            int sum = 0;
            do
            {
                sum += numberToAdd--;
            } while (numberToAdd > 0);

            Console.WriteLine(numberToAdd);

            
            // Frage: wie elegant ist folgende Lösung?:
            int numberToAdd2 = 100;
            for (; numberToAdd2 > 0; numberToAdd2 += --numberToAdd2)
            {
                // wir brauchen hier keinen Body
            }
            
            Console.WriteLine(numberToAdd2);
            
            // Aufgabe für die Fleißigen: kann ich die Summe einer Zahlvon 0 bis n OHNE eine Schleife
            // berechnen? Falls ja, wie?
        }
    }
}