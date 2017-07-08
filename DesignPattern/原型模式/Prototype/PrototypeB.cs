using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 原型B
    /// </summary>
    public class PrototypeB : IPrototype
    {
        /// <summary>
        /// 复制原型B
        /// </summary>
        /// <returns></returns>
        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }
    }
}
