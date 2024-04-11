using P01_Singleton.Step3;

namespace P01_SingletonTests;

public class Step3Tests
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
        var orderController = new OrderController();
        var userController = new UserController();

        int loop = 50;

        var task1 = Task.Run(() =>
        {
            for (int i = 0; i < loop; i++)
            {
                orderController.Create(i.ToString());
            }
        });

        var task2 = Task.Run(() =>
        {
            for (int i = 0; i < loop; i++)
            {
                userController.Login($"user{i.ToString()}", string.Empty);
            }
        });

        Task.WaitAll(task1, task2);

        var allLines = File.ReadAllLines("Logs/log.txt");
        Assert.That(allLines.Length, Is.EqualTo(loop * 2));
    }
}