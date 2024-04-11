namespace P01_Singleton.Step5_IdGenerator;

public class IdGenerator
{
    private long _id = 0;
    private static IdGenerator _instance = new IdGenerator();

    // TODO
    private IdGenerator()
    {
    }

    public static IdGenerator GetInstance()
    {
        return _instance;
    }

    public long GetId()
    {
        return Interlocked.Increment(ref _id);
    }
}