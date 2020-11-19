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
                    
                    /*
                    Kommentar zur Lösung (switch-case Teil): 
                    Wenn Zeile 36 durch ein return ausgetauscht wird, muss resultt nicht mit 0 vorbelegt werden.
                    Das ist nur der Fall bei einem break, da nach dem switch-case noch das Console.WriteLine() ausgeführt wird, was sonst
                    keinen Wert für result hätte, da es im default-case nicht gesetzt wird.
                    Zu argumentieren ist, dass ein return hier sowieso mehr Sinn macht, da bei einer ungültigen Operation es verwirrend sein kann,
                    dass Ergebnis mit 0 auszugeben, da es auch andere Rechenterme gibt, welche dieses Ergebnis produzieren.
                    */
            }
            
            Console.WriteLine($"Dein Ergebnis ist {result}");
        }
    }
}
