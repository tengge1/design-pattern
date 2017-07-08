using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 组件
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// 操作
        /// </summary>
        void Operation();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="c"></param>
        void Add(IComponent c);

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="c"></param>
        void Remove(IComponent c);

        /// <summary>
        /// 获取节点
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        IComponent GetChild(int i);
    }
}
