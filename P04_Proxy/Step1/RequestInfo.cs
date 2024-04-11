namespace P04_Proxy.Step1;

public class RequestInfo
{
    public string RequestType { get; private set; }
    public long ResponseTime { get; private set; }
    public long StartTimestamp { get; private set; }

    public RequestInfo(string requestType, long responseTime, long startTimestamp)
    {
        RequestType = requestType;
        ResponseTime = responseTime;
        StartTimestamp = startTimestamp;
    }

    public override string ToString()
    {
        return $"RequestType: {RequestType}, ResponseTime: {ResponseTime} ms, StartTimestamp: {StartTimestamp}";
    }
}