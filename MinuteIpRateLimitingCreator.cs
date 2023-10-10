using Microsoft.AspNetCore.Http;
using RateLimiting.Interface;

namespace RateLimiting;

public class MinuteIpRateLimitingCreator : IRateLimitingCreator
    {
        public IRateLimitingInfo Create(HttpContext context, int max)
        {
            if (max <= 0)
            {
                max = int.MaxValue;
            }
            return new MinuteRateLimitingInfo(context.GetRemoteIp(), max);
        }
    }
