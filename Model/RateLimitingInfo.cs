using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RateLimiting
{
    public abstract class RateLimitingInfo : IRateLimitingInfo
    {
        /// <summary>
        /// 当前请求次数
        /// </summary>
        private int _current_times;
        /// <summary>
        /// 当前值
        /// </summary>
        private int _current_value;
        /// <summary>
        /// 上次检测结果
        /// </summary>
        private int _last_times;

        /// <summary>
        /// 上一次请求时间
        /// </summary>
        private DateTime _lasttime = DateTime.Now;

        /// <summary>
        /// 访问量上限
        /// </summary>
        private int _limit;

        /// <summary>
        /// 当前key
        /// </summary>
        private string _key;

        /// <summary>
        /// 当前key
        /// </summary>
        public string Key => _key;

        public RateLimitingInfo(string key, int limit = 1200)
        {
            _limit = limit;
            _key = key;
        }

        /// <summary>
        /// 判断是否需要限流
        /// </summary>
        /// <returns>true：限流，false：不限流</returns>
        public bool Check()
        {
            if (_last_times <= _limit)
            {
                return _current_times <= _limit;
            }
            return false;
        }

        /// <summary>
        /// 当前访问次数+1
        /// </summary>
        public void Visit()
        {
            int currentValue = GetCurrentValue();
            if (_current_value != currentValue)
            {
                _last_times = _current_times;
                _current_value = currentValue;
                _current_times = 1;
            }
            else
            {
                Interlocked.Increment(ref _current_times);
            }
        }
        /// <summary>
        /// 获取当前时间范围值
        /// </summary>
        public abstract int GetCurrentValue();
    }
}
