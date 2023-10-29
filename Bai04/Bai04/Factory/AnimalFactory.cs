using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai04.Model;
namespace Bai04.Factory
{

    public class AnimalFactory
    {
        public static Animal createAnimal(AnimalType type)
        {
          
            switch (type)
            {
                case AnimalType.Cow:
                    {
                        return new Cow();
                        break;
                    }
                case AnimalType.Goat:
                    {
                        return new Goat();
                        break;
                    }
                case AnimalType.Sheep:
                    {
                        return new Sheep();
                        break;
                    }
                default:
                    {
                        return null;
                    }
             
            }
            return null; 
        }
    }
}
