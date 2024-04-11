namespace P01_Singleton.Step8_Nested;

public class IdGenerator
{
    private long _id = 0;

    private IdGenerator() { }

    private class SingletonHolder
    {
        internal static readonly IdGenerator Instance = new IdGenerator();
    }

    public static IdGenerator GetInstance()
    {
        return SingletonHolder.Instance;
    }

    public long GetId()
    {
        return Interlocked.Increment(ref _id);
    }
}