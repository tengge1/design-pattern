using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    /// <summary>
    /// 访问者接口
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// 观察元素A
        /// </summary>
        /// <param name="element"></param>
        void VisitElementA(ElementA element);

        /// <summary>
        /// 观察元素B
        /// </summary>
        /// <param name="element"></param>
        void VisitElementB(ElementB element);
    }
}
