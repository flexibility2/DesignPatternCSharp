namespace P08_Observer.Step4;

public class BaseEvent
{
    public Guid EventId { get; private set; } = Guid.NewGuid();
    public DateTime TimeStamp { get; private set; } = DateTime.UtcNow;
}