using Castle.DynamicProxy;

namespace P04_Proxy.Step4_DynamicProxy;

public static class MetricCollectorProxy
{
    public static T CreateProxy<T>(IInterceptor interceptor) where T : class
    {
        var proxyGenerator = new ProxyGenerator();
        var classProxy = proxyGenerator.CreateClassProxy<T>(interceptor);

        return classProxy;
    }

    public static T CreateProxyWithTarget<T>(T taget, IInterceptor interceptor) where T : class
    {
        var proxyGenerator = new ProxyGenerator();
        var classProxyWithTarget = proxyGenerator.CreateClassProxyWithTarget(taget, interceptor);

        return classProxyWithTarget;
    }
}