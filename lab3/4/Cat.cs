using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
            this.name = name;
        }
        public override void Voice()
        {
            Console.WriteLine("мяу");
        }
        public override dynamic GetChild(string x)
        {
            return new Cat(x); 
        }
    }
}
