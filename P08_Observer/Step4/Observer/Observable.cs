namespace P08_Observer.Step4;

public class Observable<T> : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = new ();
    
    public IDisposable Subscribe(IObserver<T> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        return new Unsubscriber(_observers, observer);
    }

    public void Unsubscribe(IObserver<T> observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(T @event)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(@event);
        }
    }

    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<T>> _observers;
        private readonly IObserver<T> _observer;

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}