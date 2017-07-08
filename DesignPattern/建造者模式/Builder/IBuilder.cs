using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 建造者接口
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// 建造A部分
        /// </summary>
        void BuildPartA();

        /// <summary>
        /// 建造B部分
        /// </summary>
        void BuildPartB();

        /// <summary>
        /// 建造C部分
        /// </summary>
        void BuildPartC();

        /// <summary>
        /// 获取产品
        /// </summary>
        /// <returns></returns>
        Product GetResult();
    }
}
