using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class Goat : Animal
    {
        public Goat(int milk = 0, AnimalType type = AnimalType.Goat, bool isHungry = false) : base(milk, type, isHungry) { }


        public override void giveMilk()
        {
           
            int randomMilk = Animal.random.Next(0, 11);
            this.milk += randomMilk;
        }

        public override Animal sinhCon()
        {
            return new Goat();
        }

        public override void souding()
        {
            Console.WriteLine("Goat is making sound");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
