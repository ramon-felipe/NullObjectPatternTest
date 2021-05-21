using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullObjectPattern.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int legs)
            : base(name, legs) { }
        public override string MakeSound()
        {
            return "Au au!";
        }
    }
}
