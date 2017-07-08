using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// 创建产品A
        /// </summary>
        /// <returns></returns>
        IProduct CreateProductA();

        /// <summary>
        /// 创建产品B
        /// </summary>
        /// <returns></returns>
        IProduct CreateProductB();
    }
}
