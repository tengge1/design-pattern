using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator org = new Originator();

            // 保存
            Memento memento = org.CreateMemento();
            Caretaker caret = new Caretaker();
            caret.Mementos.Add(memento);

            // 恢复
            Memento memento1 = caret.Mementos[0];
            org.RestoreMemento(memento1);
        }
    }
}
