namespace LuckyThree.Infrastructure.Config;

public class ApiPolicyConfig
{
    public HttpCircuitBreaker HttpCircuitBreaker { get; set; }
    public HttpRetry HttpRetry { get; set; }
}