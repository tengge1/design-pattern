using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 更新状态
        /// </summary>
        void Update();
    }
}
