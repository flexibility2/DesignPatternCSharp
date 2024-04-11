namespace P01_Singleton.Step4;

// Example usage of the Logger class:
public class UserController
{
    private readonly Logger _logger = Logger.GetInstance();

    public void Login(string username, string password)
    {
        // ...省略业务逻辑代码...
        _logger.Log($"{username} logged in!");
    }
}