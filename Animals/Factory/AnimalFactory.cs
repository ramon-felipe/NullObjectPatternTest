using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullObjectPattern.Animals.Factory
{
    public class AnimalFactory
    {
        public static Animal Create(AnimalType animalType, string name, int legs)
        {
            return animalType switch
            {
                AnimalType.Cat => new Cat(name, legs),
                AnimalType.Dog => new Dog(name, legs),
                AnimalType.Wolf => new Wolf(name, legs),
                _ => NullAnimal.GetInstance()
            };
        }
    }
}
