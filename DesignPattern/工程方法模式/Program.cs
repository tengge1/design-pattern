using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    /// <summary>
    /// 建造产品
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory();
            IProduct product = factory.FactoryMethod();

            Console.WriteLine(product);
        }
    }
}
