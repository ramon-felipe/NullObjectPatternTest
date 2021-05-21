using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullObjectPattern.Animals
{
    public class NullAnimal : Animal
    {
        private static NullAnimal _instance;
        private NullAnimal(string name, int legs)
            :base(name, legs) { }

        public static NullAnimal GetInstance()
        {
            if(null == _instance)
                _instance = new NullAnimal("", 0);

            return _instance;
        }

        public override string MakeSound()
        {
            return null;
        }
    }
}
