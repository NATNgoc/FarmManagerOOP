using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai04.Controller;
using Bai04.Model;
namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farm farm = Farm.GetInstance();
            FarmController farmController = new FarmController();   
            AnimalController animalController = new AnimalController();
            int totalAnimals, totalCows, totalGoats, totalSheeps;
            Console.WriteLine("-----------------INITIAL INFOR----------------------");
            do
            {
                Console.WriteLine("INPUT YOUR TOTAL ANIMAL IN YOUR FARM: ");
                totalAnimals = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INPUT TOTAL COW: ");
                totalCows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INPUT TOTAL GOAT: ");
                totalGoats = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INPUT TOTAL SHEEP: ");
                totalSheeps = Convert.ToInt32(Console.ReadLine());
            } while (totalAnimals != totalCows + totalGoats + totalSheeps);
            farmController.initializeAnimalsInFarm(totalCows, totalGoats, totalSheeps);
            while(true)
            {
                Console.WriteLine("-----------------FARM MANAGER PROGRAM----------------------");
                Console.WriteLine("1. Make animal in farm to be hungry");
                Console.WriteLine("2. Feed animal in your farm");
                Console.WriteLine("3. The farmer is away, animal will be hungry all over");
                Console.WriteLine("4. Generate statistics for the farm");
                Console.WriteLine("5. Product milk for farm");
                Console.WriteLine("0. End program");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Chosse your option: ");
                int option= Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            animalController.makeAnimalHungry();
                            break;
                        }
                    case 2:
                        {
                            farmController.feed();
                            Console.WriteLine("");
                            break;
                        }
                    case 3:
                        {
                            farmController.beAbsent();
                            Console.WriteLine("ALL ANIMALS BE HUNGRY RIGHT NOW SUCCESSFULLY!");
                            break;
                        }
                    case 4:
                        {
                            farmController.getTotalMilkPerAnimal();
                    
                            break;
                        }

                    case 5:
                        {
                            animalController.productMilkForFarm();
                            Console.WriteLine("PRODUCT SUCCESSFULLY!");
                            break;
                        }

                }
            }

        }

        
    }



}
