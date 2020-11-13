using System;

namespace Loesungen
{
    public class Aufgabe3
    {
        public static void Execute()
        {
            int[] moduleMasses = {95423, 142796, 88137, 105610, 79299, 110633,
                136792, 112578, 75168, 115615, 147584, 72145, 108822, 57753, 96827,
                69117, 131220, 111193, 120295, 56240, 111190, 80740, 137267, 113183,
                126821, 58966, 63556, 110977, 100328, 75367, 57371, 88235, 134475,
                109071, 92653, 73347, 135186, 64534, 81198, 55423, 100060, 149555,
                110905, 102826, 129023, 112618, 146542, 102579, 67193};

            double result = CalculateFuelNeeded(moduleMasses);

            Console.WriteLine($"Die Rakete benötigt eine Treibstroffmenge von {result}");
        }

        static int CalculateFuelNeeded(int[] moduleMasses)
        {
            var fuelNeeded = 0;

            foreach (var moduleMass in moduleMasses)
            {
                // Division zu einem Integer -> automatisches Abrunden
                fuelNeeded += moduleMass / 3 - 2;
            }
            
            return fuelNeeded;
        }
    }
}