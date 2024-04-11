namespace P08_Observer.Step4;

public class Observer<T> : IObserver<T>
{
    public void OnCompleted()
    {
        HandleCompleted();
    }

    public void OnError(Exception error)
    {
        HandleError(error);
    }

    public void OnNext(T value)
    {
        HandleEvent(value);
    }

    public virtual void HandleCompleted()
    {
        
    }

    public virtual void HandleError(Exception error)
    {
        
    }

    public virtual void HandleEvent(T @event)
    {
        
    }
}