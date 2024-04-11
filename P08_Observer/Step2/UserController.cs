namespace P08_Observer.Step2;

public class UserController
{
    private readonly UserService _userService;
    private readonly List<IRegObserver> _regObservers = new List<IRegObserver>();

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    // 设置观察者列表
    public void SetRegObservers(List<IRegObserver> observers)
    {
        _regObservers.AddRange(observers);
    }

    public long Register(string telephone, string password)
    {
        // 省略输入参数的校验代码
        // 省略异常的 try-catch 代码
        long userId = _userService.Register(telephone, password);

        // 通知所有观察者
        foreach (var observer in _regObservers)
        {
            observer.HandleRegSuccess(userId);
        }

        return userId;
    }
}