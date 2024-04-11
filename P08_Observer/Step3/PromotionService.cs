namespace P08_Observer.Step3;

public class PromotionService : IObserver<long>
{
    public void IssueNewUserExperienceCash(long userId)
    {
        Console.WriteLine($"Experience cash of user(Id: {userId}) issued.");
    }
    
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(long value)
    {
        IssueNewUserExperienceCash(value);
    }
}