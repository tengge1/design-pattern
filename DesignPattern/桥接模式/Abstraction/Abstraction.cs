using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 对接口进行抽象
    /// </summary>
    public interface Abstraction
    {
        /// <summary>
        /// 接口A
        /// </summary>
        Implementor Impl { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        void Operation();
    }
}
