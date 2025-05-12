namespace LuckyThree.Infrastructure.Config;

public class HttpRetry
{
    public int BackoffPower { get; set;}
    public int Count { get; set; }
}