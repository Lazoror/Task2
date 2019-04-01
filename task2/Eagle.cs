using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Eagle : Type, IRun, IFly
    {
        public Eagle(string name) : base(name) { }

        public override void AboutMe()
        {
            Console.WriteLine($"I'm {Name} and I {Run()} {Fly()}");
        }

        public string Fly()
        {
            return "fly like an eagle";
        }

        public string Run()
        {
            return "run like an eagle";
        }


    }
}
