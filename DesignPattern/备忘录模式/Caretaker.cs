using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    /// <summary>
    /// 负责人
    /// </summary>
    public class Caretaker
    {
        /// <summary>
        /// 保存的备忘录
        /// </summary>
        public IList<Memento> Mementos
        {
            get
            {
                return mementos;
            }
            set
            {
                mementos = value;
            }
        }
        private IList<Memento> mementos = new List<Memento>();
    }
}
