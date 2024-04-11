namespace P01_Singleton.Step3;

// Example usage of the Logger class:
public class UserController
{
    private readonly Logger _logger = new Logger();

    public void Login(string username, string password)
    {
        // ...省略业务逻辑代码...
        _logger.Log($"{username} logged in!");
    }
}