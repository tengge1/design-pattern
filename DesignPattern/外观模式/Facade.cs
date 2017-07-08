using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="system"></param>
        /// <param name="message"></param>
        public void Handle(ISubSystem system, string message)
        {
            system.Handle(message);
        }
    }
}
