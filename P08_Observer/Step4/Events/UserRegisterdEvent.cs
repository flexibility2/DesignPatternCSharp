namespace P08_Observer.Step4;

public class UserRegisterdEvent : BaseEvent
{
    public long UserId { get; set; }
    public string Telephone { get; set; }
    public string Address { get; set; }
}