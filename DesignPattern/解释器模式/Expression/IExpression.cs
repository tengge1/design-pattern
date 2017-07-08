using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// 解释语言
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// 解释
        /// </summary>
        /// <param name="context"></param>
        void Interpret(Context context);
    }
}
