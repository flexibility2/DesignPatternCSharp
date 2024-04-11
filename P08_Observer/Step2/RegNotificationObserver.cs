namespace P08_Observer.Step2;

public class RegNotificationObserver : IRegObserver
{
    private readonly NotificationService _notificationService;

    public RegNotificationObserver(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void HandleRegSuccess(long userId)
    {
        _notificationService.SendInboxMessage(userId, "Welcome...");
    }
}