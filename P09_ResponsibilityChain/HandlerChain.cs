namespace P09_ResponsibilityChain;

public class HandlerChain
{
    private readonly List<IHandler> _handlers = new List<IHandler>();

    public void AddHandler(IHandler handler)
    {
        _handlers.Add(handler);
    }

    public void Handle()
    {
        foreach (var handler in _handlers)
        {
            bool handled = handler.Handle();
            if (handled)
            {
                break;
            }
        }
    }
}