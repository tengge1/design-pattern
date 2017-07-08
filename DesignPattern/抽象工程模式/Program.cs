using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    /// <summary>
    /// 建造产品A1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            IProduct product = client.CreateProductA();
            Console.WriteLine(product);
        }
    }
}
