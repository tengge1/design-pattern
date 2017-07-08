using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    /// <summary>
    /// 代理
    /// </summary>
    public class Proxy : ISubject
    {
        /// <summary>
        /// 内置对象
        /// </summary>
        private ISubject subject;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Proxy()
        {
            subject = new Subject();
        }

        /// <summary>
        /// 前置处理
        /// </summary>
        public void PreRequest()
        {

        }

        /// <summary>
        /// 处理
        /// </summary>
        public void Request()
        {
            subject.Request();
        }

        /// <summary>
        /// 发送请求
        /// </summary>
        public void PostRequest()
        {

        }
    }
}
