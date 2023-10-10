namespace RateLimiting.Interface;

public interface IRateLimitingExecute
{
    public interface IRateLimiting
    {
        /// <summary>
        /// 更新限流信息并返回是否需要限流
        /// </summary>
        bool UpdateAndCheck(IRateLimitingInfo info);
    }
}
