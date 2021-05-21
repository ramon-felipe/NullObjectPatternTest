using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullObjectPattern.Animals
{
    public abstract class Animal
    {
        public int Qty_legs { get; set; }
        public string Name { get; set; }

        public Animal(string name, int qty_legs)
        {
            Name = name;
            Qty_legs = qty_legs;
        }

        public abstract string MakeSound();
    }
}
