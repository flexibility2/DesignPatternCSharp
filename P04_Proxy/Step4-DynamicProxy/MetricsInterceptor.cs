using Castle.DynamicProxy;

namespace P04_Proxy.Step4_DynamicProxy;

public class MetricsInterceptor : IInterceptor
{
    private MetricsCollector _metricsCollector;

    public MetricsInterceptor()
    {
        _metricsCollector = new MetricsCollector();
    }

    public void Intercept(IInvocation invocation)
    {
        long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        invocation.Proceed();

        long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long responseTime = endTimeStamp - startTimestamp;
        RequestInfo requestInfo = new RequestInfo(invocation.Method.Name, responseTime, startTimestamp);
        _metricsCollector.RecordRequest(requestInfo);
    }
}