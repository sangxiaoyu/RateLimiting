using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting
{
    public class MinuteRateLimitingInfo : RateLimitingInfo
    {
        public MinuteRateLimitingInfo(string key, int limit = 500)
            : base(key, limit)
        {
        }
        /// <summary>
        /// 当前分钟
        /// </summary>
        public override int GetCurrentValue()
        {
            return DateTime.Now.Minute;
        }
    }
}
