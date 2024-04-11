using P08_Observer.Step4;

namespace P08_ObserverTests;

public class Step4Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Register()
    {
        var notificationService = new NotificationService();
        var promotionService = new PromotionService();
        var shippingService = new ShippingService();
        var userService = new UserService();
        userService.Subscribe(notificationService);
        userService.Subscribe(promotionService);
        userService.Subscribe(shippingService);

        var userController = new UserController(userService);

        userController.Register("13912911111", "asdf1234");
        userController.UpdateAddress(100, "new address");
    }
}