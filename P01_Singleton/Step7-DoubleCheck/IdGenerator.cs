namespace P01_Singleton.Step7_DoubleCheck;

public class IdGenerator
{
    private long _id = 0;
    private static volatile IdGenerator _instance;
    private static readonly object LockObject = new object(); // Object for synchronization

    private IdGenerator() { }

    public static IdGenerator GetInstance()
    {
        // Double-check locking for thread safety
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new IdGenerator();
                }
            }
        }
        return _instance;
    }

    public long GetId()
    {
        return Interlocked.Increment(ref _id);
    }
}