using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// 建造产品
        /// </summary>
        /// <returns></returns>
        IProduct FactoryMethod();
    }
}
