using P04_Proxy.Step1;

namespace P04_ProxyTests;

public class Step1Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateUserController()
    {
        var userController = new UserController();

        userController.Register("John", "asdf1234");
        userController.Login("John", "asdf1234");
    }
}