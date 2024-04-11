namespace P08_Observer.Step4;

public class UserController
{
    private readonly UserService _userService;
    
    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    public long Register(string telephone, string password)
    {
        // 省略输入参数的校验代码
        // 省略异常的 try-catch 代码
        long userId = _userService.Register(telephone, password);

        // 通知所有观察者
        var @event = new UserRegisterdEvent()
        {
            UserId = userId,
            Telephone = telephone,
            Address = "Temp address"
        };

        _userService.Notify(@event);

        return userId;
    }

    public void UpdateAddress(long userId, string newAddress)
    {
        _userService.UpdateAddress(userId, newAddress);

        var @event = new UserAddressChangedEvent()
        {
            UserId = userId,
            Old = "Temp address",
            New = newAddress
        };
        
        _userService.Notify(@event);
    }
}