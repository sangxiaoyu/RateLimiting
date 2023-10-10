namespace RateLimiting.Interface;

public interface IRateLimiting
{

    //限流唯一键
    string Key { get; }
    // 访问
    void Visit();
    //检查
    bool Check();
}
