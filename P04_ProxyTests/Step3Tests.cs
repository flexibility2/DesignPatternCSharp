using P04_Proxy.Step3;

namespace P04_ProxyTests;

public class Step3Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateUserController()
    {
        var userController = new UserControllerProxy();

        userController.Register("John", "asdf1234");
        userController.Login("John", "asdf1234");
    }
}