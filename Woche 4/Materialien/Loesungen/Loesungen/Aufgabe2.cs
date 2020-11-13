using System;

namespace Loesungen
{
    public class Aufgabe2
    {
        public static void Execute()
        {
            const string input = "(()()())())))()()()()()()()()))))))((())))(()()()())))()((((()))()())))))((()()()())))))()(()()((()())))))))))))))((()()()()()()((((()()())))(((()()((()()(((()))()))()()()()()())))))))((()())(()(((())))))))))(((((((()()(((((()))())()())()())()()()()()()()))()((((())()())())(()))))()()()(()))())))))))))))))))))))))))))))))))))))))))))((((()()((((((()(((()()()())))(((((((((((((((()()()()((((((()()()()())(((((((((()()))()()(((((((()())((";

            int result;
            CountParentheses(input, out result);
            
            Console.WriteLine($"Ergebnis: {result}");
        }

        static void CountParentheses(string input, out int result)
        {
            result = 0;

            foreach (var currentChar in input)
                result += currentChar == '(' ? 1 : -1;
            
            // Auch ganz einfach als if-else Statement umsetzbar
        }
    }
}