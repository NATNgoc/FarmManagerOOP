using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class Sheep : Animal
    {
        public Sheep(int milk = 0, AnimalType type = AnimalType.Sheep, bool isHungry = false) : base(milk, type, isHungry) { }


        public override void giveMilk()
        {
            int randomMilk = Animal.random.Next(0, 6);
            this.milk += randomMilk;
        }

        public override Animal sinhCon()
        {
            return new Sheep();
        }

        public override void souding()
        {
            Console.WriteLine("Sheep is making sound");
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
