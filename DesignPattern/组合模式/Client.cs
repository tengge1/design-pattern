using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        /// <summary>
        /// 获取组合
        /// </summary>
        /// <returns></returns>
        public IComponent GetComposite()
        {
            Leaf leaf = new Leaf();

            IComponent composite = new Composite();
            composite.Add(leaf);

            IComponent composite2 = new Composite();
            composite2.Add(leaf);
            composite2.Add(composite);

            return composite2;
        }
    }
}
