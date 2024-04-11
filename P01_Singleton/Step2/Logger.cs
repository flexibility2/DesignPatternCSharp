namespace P01_Singleton.Step2;

public class Logger
{
    private readonly StreamWriter _writer;

    public Logger()
    {
        const string filePath = "Logs/log.txt";
        _writer = new StreamWriter(filePath, true); // true indicates append mode
    }

    public void Log(string message)
    {
        lock (this)
        {
            _writer.WriteLine(message);
            _writer.Flush();
        }
    }
}