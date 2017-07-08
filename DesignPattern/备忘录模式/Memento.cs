using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// 状态
        /// </summary>
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        private int state = 0;
    }
}
