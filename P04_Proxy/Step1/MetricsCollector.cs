namespace P04_Proxy.Step1;

public class MetricsCollector
{
    public void RecordRequest(RequestInfo requestInfo)
    {
        // 记录请求信息的逻辑，可以根据具体需求实现
        Console.WriteLine($"Recorded request: {requestInfo}");
    }
}