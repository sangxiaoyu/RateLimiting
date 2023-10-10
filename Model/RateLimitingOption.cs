namespace RateLimiting.Model;

public class RateLimitingOption
    {
        /// <summary>
        /// 对应间隔最大的访问次数
        /// </summary>
        public int Times { get; set; } = 500;
    }
