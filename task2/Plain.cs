using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Plain : Type, IFly, IEngine
    {

        public Plain(string name) : base(name) { }

        public override void AboutMe()
        {
            Console.WriteLine($"I'm {Name} and I {Fly()} {Engine()}");
        }

        public string Fly()
        {
            return "fly like a plain";
        }

        public string Engine()
        {
            return "have engine like a plain";
        }
    }
}
