using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    /// <summary>
    /// 中介者接口
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// 获取某个同事
        /// </summary>
        /// <returns></returns>
        IColleague Get();
    }
}
