using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    /// <summary>
    /// 享元接口
    /// </summary>
    public interface IFlyweight
    {
        /// <summary>
        /// 操作
        /// </summary>
        /// <param name="extrisicState"></param>
        void Operation(int extrisicState);
    }
}
