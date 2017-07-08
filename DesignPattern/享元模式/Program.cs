using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
            IFlyweight flyweight = factory.GetFlyweight("fly1");
            Console.WriteLine(flyweight);
        }
    }
}
