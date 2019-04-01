using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Duck : Type, IFly, IRun, ISwim
    {
        public Duck(string name) : base(name) { }

        public override void AboutMe()
        {
            Console.WriteLine($"I'm {Name} and I {Run()} {Fly()} {Swim()}");
        }

        public string Swim()
        {
            return "swim like a duck";
        }

        public string Fly()
        {
            return "fly like a duck";
        }

        public string Run()
        {
            return "run like a duck";
        }
    }
}
