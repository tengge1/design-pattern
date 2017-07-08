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
    public class Decorator : IDecorator
    {
        /// <summary>
        /// 组件
        /// </summary>
        public IComponent Component { get; set; }

        /// <summary>
        /// 新操作
        /// </summary>
        public void NewBehavior()
        {

        }

        /// <summary>
        /// 操作
        /// </summary>
        public void Operation()
        {
            Component.Operation();
        }
    }
}
