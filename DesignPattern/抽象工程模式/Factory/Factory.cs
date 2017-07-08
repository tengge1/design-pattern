using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class Factory : IFactory
    {
        /// <summary>
        /// 创建产品A
        /// </summary>
        /// <returns></returns>
        public IProduct CreateProductA()
        {
            return new ProductA();
        }

        /// <summary>
        /// 创建产品B
        /// </summary>
        /// <returns></returns>
        public IProduct CreateProductB()
        {
            return new ProductB();
        }
    }
}
