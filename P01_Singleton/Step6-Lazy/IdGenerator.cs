namespace P01_Singleton.Step6_Lazy;

public class IdGenerator
{
    private long _id = 0;
    private static IdGenerator _instance;
    private static readonly object LockObject = new object(); // Object for synchronization

    private IdGenerator() { }

    public static IdGenerator GetInstance()
    {
        lock (LockObject)
        {
            if (_instance == null)
            {
                _instance = new IdGenerator();
            }
        }
        
        return _instance;
    }

    public long GetId()
    {
        return Interlocked.Increment(ref _id);
    }
}