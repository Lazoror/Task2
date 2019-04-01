using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class EngineBoat : Type, ISwim, IEngine
    {
        public EngineBoat(string name) : base(name) { }

        public override void AboutMe()
        {
            Console.WriteLine($"I'm {Name} and I {Engine()} {Swim()}");
        }

        public string Engine()
        {
            return "have engine like a boat";
        }

        public string Swim()
        {
            return "swim like an engine boat";
        }

    }
}
