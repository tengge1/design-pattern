using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    /// <summary>
    /// 单例类
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 单例
        /// </summary>
        private static Singleton instance;

        /// <summary>
        /// 避免被实例化
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// 获取当前实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
