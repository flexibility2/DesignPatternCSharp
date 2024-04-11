namespace P01_Singleton.Step4;

public class Logger
{
    private readonly StreamWriter _writer;
    private static readonly Logger Instance = new Logger();

    private Logger()
    {
        const string filePath = "Logs/log.txt";
        _writer = new StreamWriter(filePath, true); // true表示追加写入
    }

    public static Logger GetInstance()
    {
        return Instance;
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