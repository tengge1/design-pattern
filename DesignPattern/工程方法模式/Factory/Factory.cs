using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    /// <summary>
    /// 具体工厂
    /// </summary>
    public class Factory : IFactory
    {
        /// <summary>
        /// 建造产品
        /// </summary>
        /// <returns></returns>
        public IProduct FactoryMethod()
        {
            return new Product();
        }
    }
}
