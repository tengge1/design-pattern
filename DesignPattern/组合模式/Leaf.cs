using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 叶子节点
    /// </summary>
    public class Leaf : IComponent
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="c"></param>
        public void Add(IComponent c)
        {

        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public IComponent GetChild(int i)
        {
            return new Leaf();
        }

        /// <summary>
        /// 操作
        /// </summary>
        public void Operation()
        {

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="c"></param>
        public void Remove(IComponent c)
        {

        }
    }
}
