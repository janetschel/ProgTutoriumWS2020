using System;

namespace Lösungen
{
    public class Aufgabe1
    {
        // Lösung der ersten Aufgabe in Execute()
        public static void Execute()
        {
            int age;
            do
            {
                Console.WriteLine("Gib dein Alter ein:");
                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 0 && age < 16) // Hat gar keine Berechtigung
                {
                    Console.WriteLine("Du bist nicht berechtigt");
                    return;
                }
                
                if (age >= 0 && age < 18)
                    Console.WriteLine("Zu jung, bitte noch ein Versuch.");
                
            } while (age < 18 || age > 110);
            
            // Summe nach gauß'scher Summenformel
            // siehe: https://de.wikipedia.org/wiki/Gau%C3%9Fsche_Summenformel

            int sum = age * (age + 1) / 2;
            Console.WriteLine($"Die Sume deiner Zahl ist: {sum}");

            /*
            // Alternativ auch lösbar mit einer Schleife
            int sumWithLoop = 0;
            for (int i = 1; i <= age; i++)
                sumWithLoop += i;
            
            Console.WriteLine($"Die Sume deiner Zahl ist: {sumWithLoop}");

            // Überprüfung
            Console.WriteLine(sum == sumWithLoop);
            */
        }
    }
}