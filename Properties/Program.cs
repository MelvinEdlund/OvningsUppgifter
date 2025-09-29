
using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1-3
            Person p = new Person();
            p.FirstName = "Sebbe";
            p.LastName = "Breuker";


            Console.WriteLine("Förnamn: " + p.FirstName);
            Console.WriteLine("Efternamn: " + p.LastName);
            Console.WriteLine("Fullständigt namn: " + p.FullName);


            // Uppgift 4
            StegRäknare räknare = new StegRäknare();
            for (int i = 0; i <1000; i++)
            {
                räknare.Step();
            }
            Console.WriteLine("Antal steg: " + räknare.Steps);

            räknare.Reset();
            Console.WriteLine("Efter reset: " + räknare.Steps);

            // Uppgift 5

        }

        class Person
        {
            private string _firstName = "Uknown";

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName { get; set; }


            public string FullName
            {
                get { return FirstName + " " + LastName; }
            }
        }

        class StegRäknare
        {
            private int _steps;

            public int Steps
            {
                get { return _steps; }
            }

            public void Step()
            {
                _steps++;
            }

            public void Reset()
            {
            _steps = 0;
            }

        }

        class Bil
        {
            private string _modell;
            public string Modell
            {
                get { return _modell; }
                set { _modell = value; }
            }

            private int _pris;
            public int Pris
            {
                get { return _pris; }
                set { _pris = value; }
            }

            private string _färg;

            public string Färg
            {
                get { return _färg; }
                set { _färg = value; }
            }


        }

    }
}
