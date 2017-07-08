using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    /// <summary>
    /// 创建单例
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton);
        }
    }
}
