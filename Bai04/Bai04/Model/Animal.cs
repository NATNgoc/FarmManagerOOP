using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
   public abstract class Animal
    {
        public static Random random = new Random();
        protected int milk;
        protected AnimalType type;
        protected bool isHungry;
        abstract public Animal sinhCon();
        abstract public void giveMilk();
      
        abstract public void souding();
        protected Animal(int milk, AnimalType type, bool isHungry)
        {
            this.milk = milk;
            this.type = type;   
            this.isHungry = isHungry;
        }

        public int getMilk()
        {
            return this.milk;
        }

        public void setMilk(int milk)
        {
            this.milk = milk;
        }

        public bool getIsHungry()
        {
            return this.isHungry;    
        }

        public AnimalType getAnimalType()
        {
            return this.type;
        }
        public void SetIsHungry(bool value)
        {
            isHungry = value;
        }

        public AnimalType GetAnimalType()
        {
            return type;
        }

        public void SetAnimalType(AnimalType value)
        {
            type = value;
        }

        
          
    }
}
