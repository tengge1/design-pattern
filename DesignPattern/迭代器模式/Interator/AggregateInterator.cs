using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// 具体迭代器
    /// </summary>
    public class AggregateInterator : Interator
    {
        /// <summary>
        /// 数组
        /// </summary>
        private ArrayList arrayList;

        /// <summary>
        /// 当前位置
        /// </summary>
        private int index = 0;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="arrayList"></param>
        public AggregateInterator(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }

        /// <summary>
        /// 当前元素
        /// </summary>
        /// <returns></returns>
        public object Current()
        {
            return arrayList[index];
        }

        /// <summary>
        /// 第一个元素
        /// </summary>
        /// <returns></returns>
        public object First()
        {
            return arrayList[0];
        }

        /// <summary>
        /// 是否有下一个元素
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            if (index == arrayList.Count)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取下一个元素
        /// </summary>
        /// <returns></returns>
        public object Next()
        {
            object obj = arrayList[index];
            index++;
            return obj;
        }
    }
}
