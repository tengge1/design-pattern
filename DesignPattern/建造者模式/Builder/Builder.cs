using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 具体建造者
    /// </summary>
    public class Builder : IBuilder
    {
        /// <summary>
        /// 建造A部分
        /// </summary>
        public void BuildPartA()
        {

        }

        /// <summary>
        /// 建造B部分
        /// </summary>
        public void BuildPartB()
        {

        }

        /// <summary>
        /// 建造C部分
        /// </summary>
        public void BuildPartC()
        {

        }

        /// <summary>
        /// 获取产品
        /// </summary>
        /// <returns></returns>
        public Product GetResult()
        {
            return new Product();
        }
    }
}
