using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public class Client
    {
        public void Run()
        {
            IHandler handler = new HandlerA();
            handler.Successor = new HandlerB();

            while (handler.Successor != null)
            {
                handler.HandleRequest();
                handler = handler.Successor;
            }
        }
    }
}
