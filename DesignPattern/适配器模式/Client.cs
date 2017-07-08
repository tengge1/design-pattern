using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 运行
        /// </summary>
        public void run()
        {
            Target target = new Target();
            target.Request();
        }
    }
}
