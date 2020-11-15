using System;

namespace Conditional_Statements
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            Console.Write("Was alt bist du?: ");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Du bist volljährig");
            }
            else
            {
                Console.WriteLine("Du bist minderjährig");
            }

            /*
             * oder auch als Ternary:
             * Console.WriteLine(age >= 18 ? "Du bist volljährig" : "Du bist minderjährig");
             */
        }
    }
}
