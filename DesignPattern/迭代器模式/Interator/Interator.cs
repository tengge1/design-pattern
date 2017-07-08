using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    public interface Interator
    {
        /// <summary>
        /// 第一个
        /// </summary>
        /// <returns></returns>
        object First();

        /// <summary>
        /// 下一个
        /// </summary>
        /// <returns></returns>
        object Next();

        /// <summary>
        /// 是否还有
        /// </summary>
        /// <returns></returns>
        bool HasNext();

        /// <summary>
        /// 当前对象
        /// </summary>
        /// <returns></returns>
        object Current();
    }
}
