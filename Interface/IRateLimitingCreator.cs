using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting
{
    public interface IRateLimitingCreator
    {
        /// <summary>
        /// 创建限流对象
        /// </summary>
        /// <param name="context">请求信息</param>
        /// <param name="max">最大次数</param>
        IRateLimitingInfo Create(HttpContext context, int max);
    }
}
