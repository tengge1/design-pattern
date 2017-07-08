using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    /// <summary>
    /// 享元模式工厂
    /// </summary>
    public class FlyweightFactory
    {
        /// <summary>
        /// 共享享元对象
        /// </summary>
        private Dictionary<string, IFlyweight> flyweights;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FlyweightFactory()
        {
            flyweights = new Dictionary<string, IFlyweight>();
        }

        /// <summary>
        /// 获取享元
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IFlyweight GetFlyweight(string key)
        {
            if (!flyweights.Keys.Contains(key))
            {
                IFlyweight flyweight = new Flyweight();
                flyweights.Add(key, flyweight);
            }
            return flyweights[key];
        }
    }
}
