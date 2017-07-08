using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 桥接
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.Impl = new ConcreteImplementorA();
            abstraction.Operation();
        }
    }
}
