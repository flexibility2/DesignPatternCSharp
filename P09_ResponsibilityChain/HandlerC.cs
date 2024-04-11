namespace P09_ResponsibilityChain;

public class HandlerC : IHandler
{
    public bool Handle()
    {
        bool handled = true;
        
        // 处理逻辑...
        Console.WriteLine($"C Node processing... Done");
        Console.WriteLine($"Finished.");
        
        return handled;
    }
}