
using System;
using System.ComponentModel.DataAnnotations;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1-3
            Console.WriteLine("Uppgift 1-3");
            Person p = new Person();
            p.FirstName = "Sebbe";
            p.LastName = "Breuker";


            Console.WriteLine("Förnamn: " + p.FirstName);
            Console.WriteLine("Efternamn: " + p.LastName);
            Console.WriteLine("Fullständigt namn: " + p.FullName);


            // Uppgift 4
            Console.WriteLine("\nUppgift 4");
            StegRäknare räknare = new StegRäknare();
            for (int i = 0; i < 1000; i++)
            {
                räknare.Step();
            }
            Console.WriteLine("Antal steg: " + räknare.Steps);

            räknare.Reset();
            Console.WriteLine("Efter reset: " + räknare.Steps);

            // Uppgift 5
            Console.WriteLine("\nUppgift 5");
            Bil bil1 = new Bil();
            bil1.Modell = "Saab";
            bil1.Pris = 100000;
            bil1.Färg = "Blå";

            Bil bil2 = new("Volvo", 200000, "Röd");

            Console.WriteLine(bil2.Pris);
            bil2.HalfPrice();
            Console.WriteLine(bil2.Pris);

            // Uppgift 6
            Console.WriteLine("\nUppgift 6");
            Vattenglas glas = new();
            glas.Töm();
            glas.Fyll();
            glas.Fyll();
            glas.Kasta();
            glas.Töm();
            glas.Fyll();

            // Uppgift 7
            Console.WriteLine("\nUppgift 7");
            Färger färg = new();
            färg.Blue = 8.5;
            Console.WriteLine($"färg.Blue = 8.5, färg.Red -> {färg.Red}");
            färg.Red = 25;
            Console.WriteLine($"färg.Red = 25, färg.Blue -> {färg.Blue}");

            // Uppgift 8
            Console.WriteLine("\nUppgift 8");
            Temperature t = new() { Celcius = 0 };

            Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
            Console.WriteLine($"Celcius:  {t.Celcius,10:f2}");
            Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");

            // Uppgift 9
            Console.WriteLine("\nUppgift 9");
            Random rnd = new();

            Car[] cars = new Car[1000];

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car(rnd);
            }
            Console.WriteLine($"Totallängd gröna bilar: {SumGreenCars(cars)} m");

            // Uppgift 10
            Console.WriteLine("\nUppgift 10");
            Car[] greenCars = Car.SameColorCars(cars[1]);

            foreach (var car in greenCars)
            {
                Console.WriteLine($"Färg: {car.Color}, Längd: {car.Length} m, Hastighet: {car.KmH} km/h");
            }

            // Uppgift 11
            Console.WriteLine("\nUppgift 11");
            Car[] raceCars = new Car[10];
            for (int i = 0; i < raceCars.Length; i++)
            {
                raceCars[i] = new Car(rnd);
            }

            double totalDistance = 10000; 
            bool raceOver = false;
            Car winner = null;
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine();
            }
            while (!raceOver)
            {
                Console.Clear();

                for (int i = 0; i < raceCars.Length; i++)
                {
                    var car = raceCars[i];
                    if (!raceOver) car.DriveForOneHour();

                    string graph = car.GetGraph(totalDistance);

                    Console.Write($"Bil {i + 1}: |");
                    for (int j = 0; j < graph.Length; j++)
                    {
                        if (graph[j] == 'x')
                        {
                            Console.ForegroundColor = car.Color;
                            Console.Write('x');
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(graph[j]);
                        }
                    }
                    Console.WriteLine($"| {Math.Round(car.Distance)} km ");

                    if (car.Distance >= totalDistance && !raceOver)
                    {
                        winner = car;
                        raceOver = true;
                    }
                }
                Thread.Sleep(500); 
            }

            Console.WriteLine("\n=== VINNARE ===");
            Console.ForegroundColor = winner.Color;
            Console.WriteLine($"Bilen i färgen {winner.Color} vann loppet!");
            Console.ResetColor();
        }

        // Uppgift 1-3
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

        // Uppgift 4
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

        // Uppgift 5
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

            public Bil()
            {

            }

            public Bil(string modell, int pris, string färg)
            {
                Modell = modell;
                Pris = pris;
                Färg = färg;
            }

            public void HalfPrice()
            {
                Pris = Pris / 2;
            }
        }

        // Uppgift 6
        class Vattenglas
        {
            private bool _fullt = false;
            private bool _trasigt = false;

            public void Fyll()
            {
                if (_fullt && !_trasigt) Console.WriteLine("Glaset är redan fullt");
                else if (!_trasigt) { Console.WriteLine("Fyller glaset"); _fullt = true; }
                else Console.WriteLine("Glaset kan inte fyllas, eftersom det är trasigt.");

            }

            public void Töm()
            {
                if (!_fullt && !_trasigt) Console.WriteLine("Glaset är redan tomt");
                else if (!_trasigt) { Console.WriteLine("Tömmer glaset"); _fullt = false; }
                else Console.WriteLine("Glaset är trasigt, finns inget att tömma :(");

            }

            public void Kasta()
            {
                if (_fullt && !_trasigt) Console.WriteLine("Glaset gör sönder och vattnet rinner ut på golvet");
                else if (!_trasigt) Console.WriteLine("Glaset går sönder");
                else Console.WriteLine("Glaset är redan trasigt!");
                _trasigt = true;
            }
        }

        // Uppgift 7
        class Färger
        {

            private double _blue;
            public double Blue
            {
                get { return _blue; }
                set
                {
                    if (value < 0.0 || value > 100)
                        throw new ArgumentOutOfRangeException(nameof(Blue), "Värdet måste vara mellan 0.0 och 100.");
                    _blue = value;
                }
            }

            public double Red
            {
                get { return 100.0 - _blue; }
                set
                {
                    if (value < 0.0 || value > 100)
                        throw new ArgumentOutOfRangeException(nameof(Red), "Värdet måste vara mellan 0.0 och 100.");
                    _blue = 100.0 - value;
                }
            }
        }

        // Uppgift 8
        class Temperature
        {
            private double _kelvin;
            public double Kelvin
            {
                get => _kelvin;
                set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException(nameof(Kelvin), "Kelvin kan inte vara negativt.");
                    _kelvin = value;
                }
            }

            public double Celcius
            {
                get => _kelvin -273.15;
                set => _kelvin = value + 273.15;
            }

            public double Farenheit
            {
                get => (_kelvin - 273.15) * 9 / 5 + 32;
                set => _kelvin = (value - 32) * 5 / 9 + 273.15;
            }
        }

        // Uppgift 9
        static double SumGreenCars(Car[] cars)
        {
            double total = 0;
            foreach (var car in cars)
            {
                if (car.Color == ConsoleColor.Green)
                {
                    total += car.Length;
                }
            }
            return Math.Round(total, 2);

        }
        class Car
        {
            private ConsoleColor _color;
            public ConsoleColor Color
            {
                get { return _color; }

            }

            private double _length;
            public double Length { get { return _length; } }

            private double _kmh;
            public double KmH { get { return _kmh; } }

            private double _distance = 0;
            public double Distance { get { return _distance; } }
            public Car (Random rnd)
            {
                Array colors = Enum.GetValues(typeof(ConsoleColor));
                _color = (ConsoleColor)colors.GetValue(rnd.Next(colors.Length));
                _length = 3 + rnd.NextDouble() * 2;
                _kmh = rnd.Next(60, 241);
            }
            public Car(ConsoleColor color, double length, double kmH)
            {
                _color = color;
                _length = Math.Round(length, 2);
                _kmh = kmH;
            }

            // Uppgift 10
            public static Car[] SameColorCars(Car car)
            {
                Random rnd = new();
                Car[] sameColorCars = new Car[10];

                for (int i = 0; i < sameColorCars.Length; i++)
                {
                    double kmH = rnd.Next(60, 241);
                    double length = 3 + rnd.NextDouble() * 2;
                    sameColorCars[i] = new Car(car.Color, length, kmH);
                }

                return sameColorCars;
            }

            // Uppgift 11
            public void DriveForOneHour()
            {
                _distance += _kmh;
            }

            public string GetGraph(double totalDistance)
            {
                double progress = _distance / totalDistance;
                int index = (int)(progress * 19);
                if (index > 19) index = 19;

                char[] track = new char[20];
                for (int i = 0; i < 20; i++) track[i] = '-';
                track[index] = 'x';

                return new string(track);
            }
        }
       
        


    }
}
