using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    /// <summary>
    /// 主体
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="ob"></param>
        void Attach(IObserver ob);

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="ob"></param>
        void Detach(IObserver ob);

        /// <summary>
        /// 通知观察者更新状态
        /// </summary>
        void Notify();
    }
}
