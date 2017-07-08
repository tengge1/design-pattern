using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 建造产品
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Product product = director.builder();
            Console.WriteLine(product);
        }
    }
}
