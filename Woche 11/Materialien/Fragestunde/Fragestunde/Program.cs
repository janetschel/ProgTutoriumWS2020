using System;
using System.IO;

namespace Fragestunde
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StreamReader
            StreamReader sr = new StreamReader("test.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                if (line == "Hi")
                {
                    Console.WriteLine("Hi Welt");
                }

                Console.WriteLine(line);

                // Am Ende: Neue Zeile lesen:
                line = sr.ReadLine();
            }
            sr.Close();
            #endregion

            #region StreamWriter
            StreamWriter sw = new StreamWriter("test2.txt");
            
            sw.WriteLine("Hallo");
            sw.WriteLine("Welt");
            sw.WriteLine("!");
            
            sw.Flush();
            sw.Close();
            #endregion
        }

        #region Rekursion
        static int FakultaetRekursiv(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FakultaetRekursiv(n - 1);
            }
        }

        static int Fakultaet(int n)
        {
            int summe = 1;

            // Iterativ
            for (int i = 1; i <= n; i++)
            {
                summe *= i;
            }

            return summe;
        }
        #endregion
    }
}