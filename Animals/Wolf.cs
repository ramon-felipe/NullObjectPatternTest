using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullObjectPattern.Animals
{
    public class Wolf : Animal
    {
        public Wolf(string name, int legs)
            : base(name, legs) { }
        public override string MakeSound()
        {
            return "Auuuuuu";
        }
    }
}
