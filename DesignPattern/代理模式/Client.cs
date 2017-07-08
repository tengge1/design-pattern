using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
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
            Proxy proxy = new Proxy();
            proxy.PreRequest();
            proxy.Request();
            proxy.PostRequest();
        }
    }
}
