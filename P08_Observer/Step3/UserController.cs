namespace P08_Observer.Step3;

public class UserController : IObservable<long>
{
    private readonly UserService _userService;
    private readonly List<IObserver<long>> _regObservers = new List<IObserver<long>>();
    
    public UserController(UserService userService)
    {
        _userService = userService;
    }

    #region Observable
    public IDisposable Subscribe(IObserver<long> observer)
    {
        if (!_regObservers.Contains(observer))
        {
            _regObservers.Add(observer);
        }
        return new Unsubscriber(_regObservers, observer);
    }

    public void Unsubscribe(IObserver<long> observer)
    {
        _regObservers.Remove(observer);
    }

    public void Notify(long userId)
    {
        foreach (var observer in _regObservers)
        {
            observer.OnNext(userId);
        }
    }

    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<long>> _observers;
        private readonly IObserver<long> _observer;

        public Unsubscriber(List<IObserver<long>> observers, IObserver<long> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
    #endregion
    
    public long Register(string telephone, string password)
    {
        // 省略输入参数的校验代码
        // 省略异常的 try-catch 代码
        long userId = _userService.Register(telephone, password);

        // 通知所有观察者
        Notify(userId);

        return userId;
    }
}