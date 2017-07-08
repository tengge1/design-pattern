using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class Adapter
    {
        /// <summary>
        /// 方法转换
        /// </summary>
        public void Request()
        {
            Adaptee adaptee = new Adaptee();
            adaptee.specificRequest();
        }
    }
}
