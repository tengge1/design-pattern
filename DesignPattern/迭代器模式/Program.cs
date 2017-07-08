using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggregate = new Aggregate();
            aggregate.arrayList = new System.Collections.ArrayList();
            aggregate.arrayList.Add(1);
            aggregate.arrayList.Add(10);

            Interator interator = aggregate.CreateInterator();
            while (interator.HasNext())
            {
                Console.WriteLine(interator.Next());
            }
        }
    }
}
