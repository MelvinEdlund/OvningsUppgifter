using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace Basic_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human[] humans = new Human[]
            {
                new Human {firstName="Sebbe", lastName="Breuker"},
                new Human {firstName="Melle", lastName="Edlund"}

            };
            humans[0].Mamma = new Human { firstName = "Katarina", lastName = "Breuker" };
            humans[0].Pappa = new Human { firstName = "Bert", lastName = "Breuker" };
            humans[1].Mamma = new Human { firstName = "Linda", lastName = "Edlund" };
            humans[1].Pappa = new Human {lastName = "Edlund" };

            foreach (var human in humans)
            {
                Console.WriteLine($"{human.GetFullname()}");
            }
            foreach (var human in humans)
            {
                Console.WriteLine($"{human.GetFullnameReversed()}");
            }

            Console.WriteLine($"{humans[0].firstName}s pappa heter {humans[0].Pappa.GetFullname("DR")}");

            foreach (var human in humans)
            {
                Console.WriteLine($"Vilken titel har du {human.firstName}? ");
                Console.WriteLine($"{human.GetFullname("Mr")}"); //Console.ReadLine()
            }

            Console.WriteLine( humans[0].GetSelfAndParents());
            Console.WriteLine(humans[1].GetSelfAndParents());

            humans[0].SetLength(1.88);
            humans[1].SetLength(1.89);
            Console.WriteLine($"{humans[0].firstName} är { humans[0].GetLength()}m");
            Console.WriteLine($"{humans[1].firstName} är {humans[1].GetLength()}m");

            humans[0].SetWeight(82);
            humans[1].SetWeight(80);

            Console.WriteLine($"{humans[0].firstName}s BMI är {humans[0].GetBMI()}");
            Console.WriteLine($"{humans[1].firstName}s BMI är {humans[1].GetBMI()}");


        }


    }

    class Human
    {
        public Human Mamma;
        public Human Pappa;

        public string firstName = null;
        public string lastName = null;
        private double length;
        private double weight;

        public string GetFullname ()
        {
            string fullname = firstName + " " + lastName;
            return fullname;
        }


        public string GetFullnameReversed()
        {
            return new string(GetFullname().Reverse().ToArray());
        }

        public string GetFullname(string titel)
        {
            string fullname = titel + firstName + " " + lastName; ;
            return fullname;
        }

        public string GetSelfAndParents()
        {
            string mammaNamn = Mamma?.GetFullname() ?? "okänd";
            string pappaNamn = Pappa?.GetFullname() ?? "okänd";

            return $"{GetFullname()} - Mamma: {mammaNamn} - Pappa: {pappaNamn}";
        }

        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetLength()
        {

            return length;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public double GetWeight()
        {

            return weight;
        }

        public double GetBMI()
        {
            double BMI = weight / (length * length);
            
            return Math.Round(BMI, 2); ;
        }

    }
}
