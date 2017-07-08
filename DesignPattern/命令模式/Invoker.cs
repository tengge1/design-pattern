using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 调用者
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// 调用命令
        /// </summary>
        public void Invoke()
        {
            ICommand command = new Command();
            command.Execute();
        }
    }
}
