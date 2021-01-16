using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var b = new Bruch();
        }
    }

    class Bruch
    {
        private int nenner;

        public int Nenner
        {
            get => nenner;
            set => nenner = value;
        }

        public Bruch(int n)
        {
            Nenner = n;
            nenner = n;
        }
    }
}