namespace P08_Observer.Step4;

public class UserService : IObservable<UserRegisterdEvent>, IObservable<UserAddressChangedEvent>
{
    private readonly Observable<UserRegisterdEvent> _userRegisteredSubject;
    private readonly Observable<UserAddressChangedEvent> _userAddressChangedSubject;

    public UserService()
    {
        _userRegisteredSubject = new Observable<UserRegisterdEvent>();
        _userAddressChangedSubject = new Observable<UserAddressChangedEvent>();
    }

    public long Register(string telephone, string password)
    {
        Console.WriteLine($"User with telephone: {telephone} registered.");
        return 100;
    }

    public void UpdateAddress(long userId, string newAddress)
    {
        Console.WriteLine($"User(id:{userId})'s address has been changed to {newAddress}.");
    }

    public IDisposable Subscribe(IObserver<UserRegisterdEvent> observer)
    {
        return _userRegisteredSubject.Subscribe(observer);
    }

    public void Notify(UserRegisterdEvent @event)
    {
        _userRegisteredSubject.Notify(@event);
    }

    public IDisposable Subscribe(IObserver<UserAddressChangedEvent> observer)
    {
        return _userAddressChangedSubject.Subscribe(observer);
    }
    
    public void Notify(UserAddressChangedEvent @event)
    {
        _userAddressChangedSubject.Notify(@event);
    }
}