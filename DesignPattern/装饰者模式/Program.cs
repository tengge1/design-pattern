using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            IDecorator decorator = new Decorator();
            decorator.Component = new Component();
            decorator.Operation();
            decorator.NewBehavior();
        }
    }
}
