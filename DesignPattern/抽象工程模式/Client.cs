using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 建造产品A
        /// </summary>
        public IProduct CreateProductA()
        {
            var factory = new Factory();
            return factory.CreateProductA();
        }
    }
}
