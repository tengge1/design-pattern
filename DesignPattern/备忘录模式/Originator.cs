using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    /// <summary>
    /// 原生器
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// 状态
        /// </summary>
        private int state = 0;

        /// <summary>
        /// 恢复备忘录
        /// </summary>
        /// <param name="m"></param>
        public void RestoreMemento(Memento m)
        {
            state = m.State;
        }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            Memento memento = new Memento();
            memento.State = state;
            return memento;
        }
    }
}
