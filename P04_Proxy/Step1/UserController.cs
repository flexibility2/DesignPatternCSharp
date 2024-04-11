namespace P04_Proxy.Step1;

public class UserController
{
    private readonly MetricsCollector _metricsCollector;

    public UserController()
    {
        _metricsCollector = new MetricsCollector();
    }

    public UserDto Login(string telephone, string password)
    {
        long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        // ... 模拟login逻辑...
        Thread.Sleep(100);

        long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long responseTime = endTimeStamp - startTimestamp;
        RequestInfo requestInfo = new RequestInfo("login", responseTime, startTimestamp);
        _metricsCollector.RecordRequest(requestInfo);

        //...返回UserDto数据...
        return new UserDto(); // 假设这里返回一个 UserDto 对象
    }

    public UserDto Register(string telephone, string password)
    {
        long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        // ... 模拟register逻辑...
        Thread.Sleep(120);

        long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long responseTime = endTimeStamp - startTimestamp;
        RequestInfo requestInfo = new RequestInfo("register", responseTime, startTimestamp);
        _metricsCollector.RecordRequest(requestInfo);

        //...返回UserDto数据...
        return new UserDto(); // 假设这里返回一个 UserDto 对象
    }
}