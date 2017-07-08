using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    /// <summary>
    /// 目标类
    /// </summary>
    public class Target
    {
        /// <summary>
        /// 一般方法
        /// </summary>
        public void Request()
        {
            Adapter adapter = new Adapter();
            adapter.Request();
        }
    }
}
