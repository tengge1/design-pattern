using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    /// <summary>
    /// 需要适配的类
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// 特殊函数
        /// </summary>
        public void specificRequest()
        {
            Console.WriteLine("这是特殊方法！");
        }
    }
}
