using P01_Singleton.Step0;

namespace P01_SingletonTests;

public class Step0Tests
{
    private const string FilePath = "Logs/log.txt";
    
    [SetUp]
    public void Setup()
    {
        if (File.Exists(FilePath))
        {
            File.Delete(FilePath);
            File.CreateText(FilePath);
        }
    }

    [Test]
    public void Test_Log_TwoController()
    {
        var userController = new UserController();

        int loop = 50;

        for (int i = 0; i < loop; i++)
        {
            userController.Login($"user{i.ToString()}", string.Empty);
        }

        var allLines = File.ReadAllLines("Logs/log.txt");
        Assert.That(allLines.Length, Is.EqualTo(loop));
    }
}