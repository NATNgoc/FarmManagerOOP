using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class Cow : Animal
    {
        public Cow(int milk=0, AnimalType type = AnimalType.Cow, bool isHungry = false) : base(milk, type, isHungry) { }
      
        public override void giveMilk()
        {
            int randomMilk = Animal.random.Next(0, 21);
            this.milk += randomMilk;
        }

        public override Animal sinhCon()
        {
            return new Cow();
        }

        public override void souding()
        {
            Console.WriteLine("Cow is making sound");
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
