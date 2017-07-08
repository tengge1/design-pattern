using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    /// <summary>
    /// 观察者A
    /// </summary>
    public class VisitorA : IVisitor
    {
        /// <summary>
        /// 观察元素A
        /// </summary>
        /// <param name="element"></param>
        public void VisitElementA(ElementA element)
        {

        }

        /// <summary>
        /// 观察元素B
        /// </summary>
        /// <param name="element"></param>
        public void VisitElementB(ElementB element)
        {

        }
    }
}
