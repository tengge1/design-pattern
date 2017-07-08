using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    /// <summary>
    /// 中介者
    /// </summary>
    public class Mediator : IMediator
    {
        /// <summary>
        /// 获取某个同事
        /// </summary>
        /// <returns></returns>
        public IColleague Get()
        {
            return new ColleagueA();
        }
    }
}
