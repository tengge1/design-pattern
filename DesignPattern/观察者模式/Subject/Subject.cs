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
    public class Subject : ISubject
    {
        /// <summary>
        /// 观察者列表
        /// </summary>
        private IList<IObserver> obs = new List<IObserver>();

        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="ob"></param>
        public void Attach(IObserver ob)
        {
            obs.Add(ob);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="ob"></param>
        public void Detach(IObserver ob)
        {
            obs.Remove(ob);
        }

        /// <summary>
        /// 发送通知
        /// </summary>
        public void Notify()
        {
            foreach (var ob in obs)
            {
                ob.Update();
            }
        }
    }
}
