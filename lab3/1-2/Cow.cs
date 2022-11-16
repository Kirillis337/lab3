using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Cow : Mammals
    {
        public Cow(string name) : base(name)
        {

        }
        public override void GetName()
        {
            Console.WriteLine($"Я корова {name}.");
        }
    }
}
