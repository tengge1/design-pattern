using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            IComponent component = client.GetComposite();

            Console.WriteLine(component);
        }
    }
}
