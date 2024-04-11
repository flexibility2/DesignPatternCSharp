using P04_Proxy.Step4_DynamicProxy;

namespace P04_ProxyTests;

public class Step4Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateUserController()
    {
        // non-target interception
        UserController proxy1 = MetricCollectorProxy.CreateProxy<UserController>(new MetricsInterceptor());
        proxy1.Register("John", "asdf1234");
        proxy1.Login("John", "asdf1234");

        Console.WriteLine("==========");

        // target interception
        var controller = new UserController();
        var proxy2 = MetricCollectorProxy.CreateProxyWithTarget<UserController>(controller, new MetricsInterceptor());
        proxy2.Register("Jack", "qwer1234");
        proxy2.Login("Jack", "qwer1234");
    }
}