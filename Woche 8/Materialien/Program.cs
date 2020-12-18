using System;
using System.IO;
using System.Reflection.Emit;

namespace Wdh
{
    class Auto
    {
        private string modell;
        private string farbe;
        
        private int ps;
        

        public int Ps
        {
            get
            {
                return ps;
            }

            set
            {
                if (value > 2) // bmw.Ps = {1, 3, 4};
                {
                    ps = value;
                }
            }
        }

        public Auto(int ps, string modell, string farbe)
        {
            Console.WriteLine("Ich erstelle gerade ein Objekt...");
            this.ps = ps;
            this.modell = modell;
            this.farbe = farbe;
        }

        public Auto(int ps = 0)
        {
            new Auto(ps, "0", "0");
        }

        public void Fahren()
        {
            Console.WriteLine("Wir fahren mit " + ps + " PS.");
            Console.WriteLine("Fahren...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto(159, "x3", "rot");
            Auto audi = new Auto();
            bmw.Ps = -1000;
            bmw.Ps = 1000;
            bmw.Fahren();

            Console.WriteLine(bmw.Ps);

            
        }
    }
}
