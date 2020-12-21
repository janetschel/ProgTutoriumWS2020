using System;

namespace Weihnachtsaufgaben_Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1: damit diese Lösung funktioniert, muss die Klasse Rentier angepasst werden (öffentliche Felder)
            /*
             * Rentier dasher = new Rentier();
             * dasher.name = "Dasher";
             * dasher.alter = 17;
             * dasher.roteNase = false;
             *
             * Rentier rudolph = new Rentier();
             * rudolph.name = "Rudolph";
             * rudolph.alter = 18;
             * rudolph.roteNase = true;
             *
             * Console.WriteLine($"--- {dasher.name} ---");
             * Console.WriteLine($"{dasher.name} ist {dasher.alter} Jahre alt und hat ${(dasher.roteNase ? "eine" : "keine")} rote Nase.");
             * if (!dasher.roteNase)
             * {
             *      Console.WriteLine("Nicht so schlimm.");
             * }
             *
             * Console.WriteLine($"--- {rudolph.name} ---");
             * Console.WriteLine($"{rudolph.name} ist {rudolph.alter} Jahre alt und hat ${(rudolph.roteNase ? "eine" : "keine")} rote Nase.");
             * if (!rudolph.roteNase)
             * {
             *      Console.WriteLine("Nicht so schlimm.");
             * }
             */
            
            // Aufgabe 2, 3 und 4
            Schlitten meinSchlitten = new Schlitten(
                new Rentier[] {
                    new Rentier("Dasher", 17, false),
                    new Rentier("Dancer", 17, false),
                    new Rentier("Prancer", 15, false),
                    new Rentier("Vixon", 16, false),
                    new Rentier("Comet", 16, false),
                    new Rentier("Cupid", 18, false),
                    new Rentier("Donner", 16, false),
                    new Rentier("Blitzen", 17, false),
                    new Rentier("Rudolph", 18, true)
                }
            );
    
            Console.WriteLine(meinSchlitten.Rentiere);
            
            // Aufgabe 5
            Schlitten schlittenVonDatei = Schlitten.InputLesen("meine.rentiere");
            Console.WriteLine(schlittenVonDatei.Rentiere);
        }
    }
}