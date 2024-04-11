namespace P08_Observer.Step4;

public class UserAddressChangedEvent : BaseEvent
{
    public long UserId { get; set; }
    public string Old { get; set; }
    public string New { get; set; }
}