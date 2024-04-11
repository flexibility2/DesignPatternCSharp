using P04_Proxy.Step2;

namespace P04_ProxyTests;

public class Step2Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateUserController()
    {
        var userController = new UserControllerProxy(new UserController());

        userController.Register("John", "asdf1234");
        userController.Login("John", "asdf1234");
    }
}