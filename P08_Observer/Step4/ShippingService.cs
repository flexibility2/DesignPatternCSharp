namespace P08_Observer.Step4;

public class ShippingService : Observer<UserAddressChangedEvent>
{
    public void RecordChangedAddress(long userId, string newAddress)
    {
        Console.WriteLine($"User(id:{userId})'s new address has been saved.");
    }
    
    public override void HandleEvent(UserAddressChangedEvent @event)
    {
        RecordChangedAddress(@event.UserId, @event.New);
    }
}