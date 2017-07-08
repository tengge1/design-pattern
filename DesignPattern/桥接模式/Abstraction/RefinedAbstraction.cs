using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 扩充抽象类
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        /// <summary>
        /// 接口
        /// </summary>
        public Implementor Impl { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        public void Operation()
        {

        }
    }
}
