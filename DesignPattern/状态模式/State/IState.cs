using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    /// <summary>
    /// 状态接口
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 某种状态下的处理方法
        /// </summary>
        void Handle();
    }
}
