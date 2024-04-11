namespace P01_Singleton.Step1;

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
        _writer.WriteLine(message);
        _writer.Flush();
    }
}