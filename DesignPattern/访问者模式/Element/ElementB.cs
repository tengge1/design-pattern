using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    /// <summary>
    /// 元素B
    /// </summary>
    public class ElementB : IElement
    {
        /// <summary>
        /// 接收观察者
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {

        }

        /// <summary>
        /// 操作B
        /// </summary>
        public void OperationB()
        {

        }
    }
}
