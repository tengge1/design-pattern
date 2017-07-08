using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client
    {
        public void Run()
        {
            Context context = new Context();
            IExpression expression = new Expression();
            expression.Interpret(context);
        }
    }
}
