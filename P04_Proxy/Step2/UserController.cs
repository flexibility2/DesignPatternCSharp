namespace P04_Proxy.Step2;

public class UserController : IUserController
{
    public UserController()
    {
    }

    public UserDto Login(string telephone, string password)
    {
        // ... 模拟login逻辑...
        Thread.Sleep(100);

        //...返回UserDto数据...
        return new UserDto(); // 假设这里返回一个 UserDto 对象
    }

    public UserDto Register(string telephone, string password)
    {
        // ... 模拟register逻辑...
        Thread.Sleep(120);

        //...返回UserDto数据...
        return new UserDto(); // 假设这里返回一个 UserDto 对象
    }
}