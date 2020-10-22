using System;

namespace Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageOfUser = Convert.ToDouble(Console.ReadLine()); // Konvertierung in double als var

            if (ageOfUser >= 18) 
            {
                Console.WriteLine("Du bist volljährig");
            }
            else if (ageOfUser > 0 && ageOfUser <= 17) // && ageOfUser <= 17 ist nicht nötig, da durch den ersten Fall ageOfUser >= 18 hier schon abgedeckt.
            {
                Console.WriteLine("Du bist leider nicht volljährig");
            }
            else 
            {
                Console.WriteLine("Du bist niemals so alt!");
            }
        }
    }
}
