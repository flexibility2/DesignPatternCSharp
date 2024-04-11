using System.Collections.Concurrent;
using P01_Singleton.Step5_IdGenerator;

namespace P01_SingletonTests;

public class Step5Tests
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
    public void Test_GetId_TwoThreads()
    {
        int loop = 50;

        var bag = new ConcurrentBag<long>();

        var task1 = Task.Run(() =>
        {
            for (int i = 0; i < loop; i++)
            {
                var idGenerator = IdGenerator.GetInstance();
                var id = idGenerator.GetId();
                bag.Add(id);
            }
        });

        var task2 = Task.Run(() =>
        {
            for (int i = 0; i < loop; i++)
            {
                var idGenerator = IdGenerator.GetInstance();
                var id = idGenerator.GetId();
                bag.Add(id);
            }
        });

        Task.WaitAll(task1, task2);
        
        Assert.That(bag.Count, Is.EqualTo(2 * loop));
        Assert.That(bag.Min(), Is.EqualTo(1));
        Assert.That(bag.Max(), Is.EqualTo(2 * loop));

        var sum = bag.Sum(item => item);
        var expected = 2 * loop * (1 + 2 * loop) / 2;
        
        Assert.That(sum, Is.EqualTo(expected));
    }
}