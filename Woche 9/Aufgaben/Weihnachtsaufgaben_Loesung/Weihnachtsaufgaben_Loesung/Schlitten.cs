using System;
using System.IO;

namespace Weihnachtsaufgaben_Loesung
{
    public class Schlitten
    {
        private Rentier[] rentiere = new Rentier[9];
        
        // Aufgabe 2
        /* // Variante 1:
         * public Rentier[] Rentiere => rentiere;
         *
         * // Variante 2:
         * public Rentier[] Rentiere
         * {
         *   get => rentiere;
         * }
         */

        // Aufgabe 3 und 4
        public string Rentiere
        {
            get
            {
                string rentiereString = "";
                foreach (Rentier rentier in rentiere)
                {
                    // Aufgabe 3
                    // rentiereString += $"{rentier.Name} ist {rentier.Alter} und hat {(rentier.RoteNase ? "eine" : "keine")} rote Nase\n";
                    
                    // Aufgabe 4
                    rentiereString += rentier.SchoeneAusgabe;
                }

                return rentiereString;
            }
        }

        public Schlitten(Rentier[] rentiere)
        {
            this.rentiere = rentiere;
        }
        
        public Schlitten(Rentier[] rentiere, int anzahl)
        {
            this.rentiere = new Rentier[anzahl];
            this.rentiere = rentiere;
        }

        public static Schlitten InputLesen(string dateiPfad)
        {
            StreamReader streamReader = new StreamReader(dateiPfad);
            string allLines = streamReader.ReadToEnd();
            string[] everyLine = allLines.Split("\n");
            
            Rentier[] rentiereVonDatei = new Rentier[everyLine.Length - 1];
            for (int i = 0; i < everyLine.Length - 1; i++)
            {
                string[] partsOfLine = everyLine[i].Split(",");
                
                string name = partsOfLine[0];
                int alter = Convert.ToInt32(partsOfLine[1]);
                bool roteNase = partsOfLine[2] == "ja";

                rentiereVonDatei[i] = new Rentier(name, alter, roteNase);
            }

            return new Schlitten(rentiereVonDatei, rentiereVonDatei.Length);
        }
    }
}