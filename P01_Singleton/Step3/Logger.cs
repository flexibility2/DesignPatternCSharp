namespace P01_Singleton.Step3;

public class Logger
{
    private static readonly StreamWriter Writer;
    private static readonly object LockObject = new object(); // Object for synchronization

    static Logger()
    {
        const string filePath = "Logs/log.txt";
        Writer = new StreamWriter(filePath, true); // true indicates append mode
    }

    public void Log(string message)
    {
        lock (LockObject) // Class-level lock
        {
            Writer.WriteLine(message);
            Writer.Flush(); // Ensure data is written immediately
        }
    }
}