using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 复制原型A
        /// </summary>
        /// <returns></returns>
        public IPrototype Copy()
        {
            IPrototype prototype = new PrototypeA();
            return prototype.Clone();
        }
    }
}
