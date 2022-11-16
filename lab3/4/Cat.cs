using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Cat
    {
        protected string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public void GetChild()
        {
            Console.WriteLine($"{name}: Произошло порождение кота(микрокiт)");
        }
    }
}
