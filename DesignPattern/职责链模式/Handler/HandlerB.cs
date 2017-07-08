using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    /// <summary>
    /// 职责B
    /// </summary>
    public class HandlerB : IHandler
    {
        public IHandler Successor { get; set; }

        public void HandleRequest()
        {

        }
    }
}
