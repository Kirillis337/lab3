using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Pet
    {
        public string name;
        public Pet(string name)
        {
            this.name = name;
        }
        public void info()
        {
            Console.WriteLine($"Меня зовут - {name}, я {GetType().Name}");
        }
        abstract public dynamic GetChild(string x);

        abstract public void Voice();
    }
}
