using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    /// <summary>
    /// 导演
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 创建产品
        /// </summary>
        /// <returns></returns>
        public Product builder()
        {
            IBuilder builder = new Builder();
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            return builder.GetResult();
        }
    }
}
