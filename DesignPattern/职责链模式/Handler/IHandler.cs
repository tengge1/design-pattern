using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    /// <summary>
    /// 职责接口
    /// </summary>
    public interface IHandler
    {
        /// <summary>
        /// 后继职责
        /// </summary>
        IHandler Successor { get; set; }

        /// <summary>
        /// 处理职责
        /// </summary>
        void HandleRequest();
    }
}
