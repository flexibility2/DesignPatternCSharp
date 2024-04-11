namespace P08_Observer.Step4;

public class NotificationService : Observer<UserRegisterdEvent>
{
    public void SendInboxMessage(long userId, string welcome)
    {
        Console.WriteLine($"Welcome message '{welcome}' has been sent to user (id:{userId}).");
    }

    public override void HandleEvent(UserRegisterdEvent @event)
    {
        SendInboxMessage(@event.UserId, "Hi");
    }
}