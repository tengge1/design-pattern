using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    /// <summary>
    /// 具体命令
    /// </summary>
    public class Command : ICommand
    {
        public void Execute()
        {
            Receiver receiver = new Receiver();
            receiver.Action();
        }
    }
}
