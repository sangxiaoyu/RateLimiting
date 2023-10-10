namespace RateLimiting;

public class MinuteRateLimiting : RateLimitingInfo
    {
        public MinuteRateLimiting(string key, int limit = 500)
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