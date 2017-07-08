using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    /// <summary>
    /// 上下文环境
    /// </summary>
    public class Context
    {
        /// <summary>
        /// 状态
        /// </summary>
        private IState state = new StateA();

        /// <summary>
        /// 执行该状态下的操作
        /// </summary>
        public void Request()
        {
            state.Handle();
        }

        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(IState state)
        {
            this.state = state;
        }
    }
}
