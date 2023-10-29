using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public enum AnimalType
    {
        Cow,
        Sheep,
        Goat
    }

    public static class AnimalTypeExtensions
    {
        public static string GetName(this AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cow:
                    return "Cow";
                case AnimalType.Sheep:
                    return "Sheep";
                case AnimalType.Goat:
                    return "Goat";
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalType), "Invalid animal type");
            }
        }
    }
}
