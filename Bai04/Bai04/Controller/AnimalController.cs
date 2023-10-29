using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai04.Model;
namespace Bai04.Controller
{
    public class AnimalController
    {
        private List<Animal> listOfAnimal = Farm.GetInstance().getListAnimal();

        public AnimalController() { }
      
        /*
         - Make animal hungry
         - Random 0 or 1 if it is 1, this animal will be set to be hungry
         */
        public void makeAnimalHungry()
        {
            Random random = new Random();
            foreach (Animal animal in listOfAnimal)
            {
                int numRand = random.Next(0, 2);
                if (numRand==1)
                {
                    animal.SetIsHungry(true);
                    animal.souding();
                }
            }
        }
        /*
        - Product Milk For Farm
        */
        public void productMilkForFarm()
        {
            foreach (Animal animal in listOfAnimal)
            {
                animal.giveMilk();
            }
        }

        


    }
}
