using System;

namespace Conditional_Statements
{
    class Aufgabe6
    {
        static void Main(string[] args)
        {
            Console.Write("Rot?: ");
            var red = Convert.ToBoolean(Console.ReadLine());
            
            Console.Write("Gelb?: ");
            var yellow = Convert.ToBoolean(Console.ReadLine());
            
            Console.Write("Blau?: ");
            var blue = Convert.ToBoolean(Console.ReadLine());

            string resultingColor;
            
            if (red && yellow && blue)
                resultingColor = "schwarz";
            else if (red && yellow)
                resultingColor = "orange";
            else if (red && blue)
                resultingColor = "violet";
            else if (blue && yellow)
                resultingColor = "grün";
            else if (red)
                resultingColor = "rot";
            else if (blue)
                resultingColor = "blau";
            else if (yellow)
                resultingColor = "gelb";
            else
                resultingColor = "weiß";

            Console.WriteLine($"Deine Farbe ist {resultingColor}");
        }
    }
}
