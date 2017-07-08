using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        public void Run()
        {
            Invoker invoker = new Invoker();
            invoker.Invoke();
        }
    }
}
