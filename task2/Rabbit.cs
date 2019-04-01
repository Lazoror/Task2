using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Rabbit : Type, IRun
    {
        public Rabbit(string name) : base(name) { }

        public override void AboutMe()
        {
            Console.WriteLine($"I'm {Name} and I {Run()}");
        }

        public string Run()
        {
            return "run like a rabbit";
        }
    }
}
