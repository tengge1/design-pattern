using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 抽象原型
    /// </summary>
    public interface IPrototype
    {
        /// <summary>
        /// 复制原型
        /// </summary>
        /// <returns></returns>
        IPrototype Clone();
    }
}
