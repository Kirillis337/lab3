using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Dog : Cat
    {
        public Dog(string name):base (name)
        {
            this.name = name;
        }
        public new void GetChild()
        {
            Console.WriteLine($"{name}: Произошло порождение собакена(Hotdog)");
        }
    }
}
