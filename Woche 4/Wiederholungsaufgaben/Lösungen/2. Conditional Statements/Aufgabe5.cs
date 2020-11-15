using System;

namespace Conditional_Statements
{
    class Aufgabe5
    {
        static void Main(string[] args)
        {
            Console.Write("Wie lautet deine erste Zahl?: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Wie lautet dein Operator?: ");
            var operatorOfCalculation = Console.ReadLine();
            
            Console.Write("Wie lautet deine zweite Zahl?: ");
            var number2 = Convert.ToInt32(Console.ReadLine());


            int result = 0;
            switch (operatorOfCalculation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine($"Unglültiger Operator");
                    break;
            }
            
            Console.WriteLine($"Dein Ergebnis ist {result}");
        }
    }
}
