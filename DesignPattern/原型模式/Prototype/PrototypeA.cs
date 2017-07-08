using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 原型A类
    /// </summary>
    public class PrototypeA : IPrototype
    {
        /// <summary>
        /// 复制原型A
        /// </summary>
        /// <returns></returns>
        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }
    }
}
