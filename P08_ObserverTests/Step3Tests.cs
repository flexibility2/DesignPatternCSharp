using P08_Observer.Step3;

namespace P08_ObserverTests;

public class Step3Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Register()
    {
        var userService = new UserService();
        var notificationService = new NotificationService();
        var promotionService = new PromotionService();

        var userController = new UserController(userService);
        var notifyUnsubscribe = userController.Subscribe(notificationService);
        var promotionUnsubscribe = userController.Subscribe(promotionService);

        userController.Register("13912911111", "asdf1234");
    }
}