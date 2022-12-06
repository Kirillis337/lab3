using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Dog : Pet
    {
        public Dog(string name):base (name)
        {
            this.name = name;
        }
        public override void Voice()
        {
            Console.WriteLine("гав");
        }

        public override dynamic GetChild(string x)
        {
            return new Dog(x); 
        }
    }
}
