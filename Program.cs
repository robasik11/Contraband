using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            ContrabandCar CB = new ContrabandCar();
            Car Car = new Car();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hur många bilar ska skapas?");

                Car.ParseInt();

                Console.ReadKey();

                Console.WriteLine("Vilken bil vill du titta på?");

                Car.Cars();
                Car.Amount();
                Car.Carselector();

                Console.ReadKey();
            }





        }
    }
}
