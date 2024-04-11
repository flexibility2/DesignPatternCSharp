namespace P08_Observer.Step4;

public class PromotionService : Observer<UserRegisterdEvent>
{
    public void IssueNewUserExperienceCash(long userId)
    {
        Console.WriteLine($"Experience cash of user(Id: {userId}) issued.");
    }

    public override void HandleEvent(UserRegisterdEvent @event)
    {
        IssueNewUserExperienceCash(@event.UserId);
    }
}