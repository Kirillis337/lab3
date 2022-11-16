using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Whale: Mammals
    {
        public Whale(string name):base(name)
        {

        }
        public override void GetName()
        {
            Console.WriteLine($"Я не корова, Я – кит {name}.");
        }
    }
}
    