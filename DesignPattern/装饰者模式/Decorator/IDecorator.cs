using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    /// <summary>
    /// 装饰者
    /// </summary>
    public interface IDecorator
    {
        /// <summary>
        /// 封装的组件
        /// </summary>
        IComponent Component { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        void Operation();

        /// <summary>
        /// 新操作
        /// </summary>
        void NewBehavior();
    }
}
