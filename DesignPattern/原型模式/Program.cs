using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 复制原型
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            IPrototype prototype = client.Copy();
            Console.WriteLine(prototype);
        }
    }
}
