using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    /// <summary>
    /// 元素接口
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// 接收
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IVisitor visitor);
    }
}
