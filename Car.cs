using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {

        public int passangers;
        public int ContrabandAmount;
        Random generator = new Random();

        public void Carselector()
        {
            CleanCar CC = new CleanCar();
            ContrabandCar CBC = new ContrabandCar();
            if (passangers == 4)
            {
                CBC.Contrabandcar();

            }
            else
            {

                CC.Cleancar();

            }

        }

        public void ParseInt()
        {
            int result;


            while (true)
            {
                string answer = Console.ReadLine().Trim();

                if (Int32.TryParse(answer, out result))
                    break;

                Console.WriteLine("Du måste skriva in ett heltal!");
            }
        }





    }
}
