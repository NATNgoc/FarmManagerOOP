using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai04.Model;
using Bai04.Factory;
namespace Bai04.Controller
{
    class FarmController
    {
        private List<Animal> listOfAnimal = Farm.GetInstance().getListAnimal();



       public FarmController(){ }

        public void feed()
        {
            foreach(var animal in listOfAnimal)
            {
                if (animal.getIsHungry())
                {
                    animal.SetIsHungry(false);
                }
            }
        }  


        public void beAbsent()
        {
            foreach (Animal animal in listOfAnimal)
            {    
                    animal.SetIsHungry(true);
            }
        }

        public void getTotalMilkPerAnimal()
        {
            //Total animals
            int totalCow = 0;
            int totalGoat = 0;
            int totalSheep = 0;
            //Total Milk
            int totalMilkOfCow = 0;
            int totalMilkOfGoat = 0;
            int totalMilkOfSheep = 0;

            foreach (Animal animal in listOfAnimal)
            {
                switch (animal.GetAnimalType())
                {
                    case AnimalType.Cow:
                        totalCow += 1;
                        totalMilkOfCow += animal.getMilk();
                        break;
                    case AnimalType.Goat:
                        totalGoat += 1;
                        totalMilkOfGoat += animal.getMilk();
                        break;
                    case AnimalType.Sheep:
                        totalSheep += 1;
                        totalMilkOfSheep += animal.getMilk();
                        break;
                        // Thêm các trường hợp cho các loại động vật khác (nếu có)
                }
            }

            Console.WriteLine("-------------STATISTICS------------------");
            Console.WriteLine("COW: "+totalCow+" with Total Milk: " + totalMilkOfCow);
            Console.WriteLine("GOAT: "+ totalGoat + " with Total Milk: " + totalMilkOfGoat);
            Console.WriteLine("SHEEP: "+ totalSheep + " with Total Milk: " + totalMilkOfSheep);

        }


        public void initializeAnimalsInFarm(int totalCows, int totalGoats, int totalSheeps)
        {
            initalizeAnimalForPerTypes(AnimalType.Cow, totalCows);
            initalizeAnimalForPerTypes(AnimalType.Goat, totalGoats);
            initalizeAnimalForPerTypes(AnimalType.Sheep, totalSheeps);
        }
        
        private void initalizeAnimalForPerTypes(AnimalType type, int total)
        {
            Animal animal;
            animal = AnimalFactory.createAnimal(type);
            while (total>0)
            {
                listOfAnimal.Add(animal);
                total--;
            }
            Console.WriteLine("INITIALIZED ", type.ToString());
        }
    }

}
