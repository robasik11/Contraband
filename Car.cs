using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        //Jag börjar med att skapa dem givna int i klassdiagrammet
        public int passangers;
        public int ContrabandAmount;
        Random generator = new Random();
        int result;

        //jag skapar en metod som ska kolla om passagerkarna i bilen är 4 eller mindre
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

        //denna metoden parse gör så att användaren endast kan skriva in en siffra, den använder jag sen för att skriva ut antal bilar.
        public void ParseInt()
        {



            while (true)
            {
                string answer = Console.ReadLine().Trim();

                if (Int32.TryParse(answer, out result))
                    break;

                Console.WriteLine("Du måste skriva in ett heltal!");
            }
        }


        public void Amount()
        {
            //försöker göra att datorn slumpar något tal mellan de valda antal bilar
            result = generator.Next();




        }


        //Här försöker jag leka med generiska klasser, i detta fallet använde jag mig av en Stack för att jag ansåg att det passade bäst

        public void Cars()
        {
            Stack<int> cars = new Stack<int>();

            cars.Push(result);
            int h = cars.Pop();

        }






    }
}
