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
            ISubSystem system = new SubSystemA();
            Facade facade = new Facade();
            facade.Handle(system, "执行一些操作");
        }
    }
}
