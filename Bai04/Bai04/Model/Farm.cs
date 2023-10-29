using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04.Model
{
    //SINGLE TON PATTERN
    public class Farm
    {
        private List<Animal> listOfAnimal;
        private static Farm instance;

        private Farm()
        {
            listOfAnimal = new List<Animal>();
        }

        public static Farm GetInstance()
        {
            if (instance == null)
            {
                instance = new Farm();
            }
            return instance;
        }

        public List<Animal> getListAnimal()
        {
            return this.listOfAnimal;
        }

        public void setListAnimal(List<Animal> listOfAnimal)
        {
             this.listOfAnimal = listOfAnimal;
        }



    }
}
