using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 执行
        /// </summary>
        public void Run()
        {
            // 创建元素
            ElementA elementA = new ElementA();
            ElementB elementB = new ElementB();

            // 添加观察者
            IVisitor visitorA = new VisitorA();
            elementA.Accept(visitorA);
            elementB.Accept(visitorA);

            // 获取同一个观察者对不同元素的观察
            visitorA.VisitElementA(elementA);
            visitorA.VisitElementB(elementB);
        }
    }
}
