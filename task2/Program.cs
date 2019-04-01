using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Type> flying = new List<Type>();
            List<Type> swimming = new List<Type>();


            List<Type> allTypes = new List<Type>()
            {
                new Chicken("Chicken"),
                new Duck("Duck"),
                new Eagle("Eagle"),
                new EngineBoat("Engine Boat"),
                new Plain("Plain"),
                new Rabbit("Rabbit")
            };

            foreach (Type item in allTypes)
            {
                if (item is IFly)
                {
                    flying.Add(item);
                }
                if (item is ISwim)
                {
                    swimming.Add(item);
                }

                item.AboutMe();
            }

            Console.WriteLine("-------------Flying objects-------------");

            flying.ForEach(a => a.AboutMe());

            Console.WriteLine("------------Swimming objects------------");

            swimming.ForEach(a => a.AboutMe());

        }
    }
}
