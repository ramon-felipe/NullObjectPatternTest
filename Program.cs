using System;
using TestNullObjectPattern.Animals;
using TestNullObjectPattern.Animals.Factory;

namespace TestNullObjectPattern
{
    class Program
    {
        static void Main()
        {
            var myAnimal = AnimalFactory.Create(AnimalType.Dog, "gatchinho", 4);
            var myNullAnimal = AnimalFactory.Create(AnimalType.Whale, "baleinha", 0);

            Console.WriteLine(myAnimal.MakeSound());
            Console.WriteLine(myNullAnimal.MakeSound());

            Console.ReadKey();
        }
    }
}
