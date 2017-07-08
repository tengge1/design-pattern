using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();

            // 添加观察者
            IObserver ob = new Observer();
            subject.Attach(ob);

            // 发送通知
            subject.Notify();
        }
    }
}
