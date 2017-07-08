using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    /// <summary>
    /// 环境类
    /// </summary>
    public class Context
    {
        /// <summary>
        /// 策略
        /// </summary>
        private IStrategy strategy = new StrategyA();

        /// <summary>
        /// 策略
        /// </summary>
        public void Algorithm()
        {
            strategy.Algorithm();
        }
    }
}
