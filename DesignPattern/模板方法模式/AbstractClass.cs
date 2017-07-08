using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 模板方法
        /// </summary>
        public virtual void templateMethod()
        {
            Operation1();
            Operation2();
            Operation3();
        }

        /// <summary>
        /// 操作一
        /// </summary>
        public virtual void Operation1()
        {

        }

        /// <summary>
        /// 操作二
        /// </summary>
        public virtual void Operation2()
        {

        }

        /// <summary>
        /// 操作三
        /// </summary>
        public virtual void Operation3()
        {

        }
    }
}
