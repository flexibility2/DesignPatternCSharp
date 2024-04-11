namespace P09_ResponsibilityChain;

public class HandlerB : IHandler
{
    public bool Handle()
    {
        bool handled = true;
        
        // 处理逻辑...
        Console.WriteLine($"B Node processing... Done");
        Console.WriteLine($"Finished.");
        
        return handled;
    }
}