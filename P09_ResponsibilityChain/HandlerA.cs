namespace P09_ResponsibilityChain;

public class HandlerA : IHandler
{
    public bool Handle()
    {
        bool handled = false;
        
        // 处理逻辑...
        Console.WriteLine($"A Node processing... Done");
        Console.WriteLine($"Need following step...");
        
        return handled;
    }
}