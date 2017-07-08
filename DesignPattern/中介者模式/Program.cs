using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator();
            Console.WriteLine(mediator.Get());
        }
    }
}
