using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    /// <summary>
    /// 子系统接口
    /// </summary>
    public interface ISubSystem
    {
        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="message"></param>
        void Handle(string message);
    }
}
