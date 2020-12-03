using System;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jan = new Student();
            
            jan.Vorname = "Jan";
            jan.Nachname = "Etschel";
            
            try
            {
                jan.Manr = -1;   
            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler beim Setzen von Manr: " + e.Message);
                return;
            }
            
            jan.SayHello();
        }
    }

    class Student
    {
        private string vorname;
        private string nachname;
        private int manr;

        public string Vorname
        {
            get { return vorname;  }
            set { vorname = value; }
        }
        
        public string Nachname
        {
            get { return vorname;  }
            set { vorname = value; }
        }

        public int Manr
        {
            get { return manr; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Manr nur positiv bitte!");
                }

                manr = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hallo, ich bin {vorname}");
            Console.WriteLine($"Meine Manr ist {Manr}");
        }
    }
}
