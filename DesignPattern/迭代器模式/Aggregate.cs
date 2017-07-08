using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{

    public class Aggregate
    {
        /// <summary>
        /// 数组
        /// </summary>
        public ArrayList arrayList = new ArrayList();

        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public Interator CreateInterator()
        {
            return new AggregateInterator(arrayList);
        }
    }
}
