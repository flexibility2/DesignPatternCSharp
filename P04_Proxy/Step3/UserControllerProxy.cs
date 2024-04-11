namespace P04_Proxy.Step3;

public class UserControllerProxy : UserController
{
    private MetricsCollector _metricsCollector;
    
    public UserControllerProxy()
    {
        _metricsCollector = new MetricsCollector();
    }

    public override UserDto Login(string telephone, string password)
    {
        long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        var userDto = base.Login(telephone, password);

        long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long responseTime = endTimeStamp - startTimestamp;
        RequestInfo requestInfo = new RequestInfo("login", responseTime, startTimestamp);
        _metricsCollector.RecordRequest(requestInfo);

        //...返回UserDto数据...
        return userDto;
    }

    public override UserDto Register(string telephone, string password)
    {
        long startTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        var userDto = base.Register(telephone, password);

        long endTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long responseTime = endTimeStamp - startTimestamp;
        RequestInfo requestInfo = new RequestInfo("register", responseTime, startTimestamp);
        _metricsCollector.RecordRequest(requestInfo);

        //...返回UserDto数据...
        return userDto;
    }
}