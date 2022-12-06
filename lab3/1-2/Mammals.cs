using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Mammals
    {
        protected string name;

        public Mammals(string name)
        {
            this.name = name;
        }
        public virtual void GetName()
        {
            Console.WriteLine("Абстрактный крик");
        }
    }
}
