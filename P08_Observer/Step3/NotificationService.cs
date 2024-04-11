namespace P08_Observer.Step3;

public class NotificationService : IObserver<long>
{
    public void SendInboxMessage(long userId, string welcome)
    {
        Console.WriteLine($"Welcome message '{welcome}' has been sent to user (id:{userId}).");
    }
    
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(long value)
    {
        SendInboxMessage(value, "Hi");
    }
}