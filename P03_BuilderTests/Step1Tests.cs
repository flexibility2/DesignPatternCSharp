using P03_Builder.Step1;

namespace P03_Builder;

public class Step1Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateResourcePoolConfig()
    {
        var poolConfig = new ResourcePoolConfig("dbconnectionpool", 10, 5, 0);
        
        Assert.That(poolConfig.Name, Is.EqualTo("dbconnectionpool"));
        Assert.That(poolConfig.MaxTotal, Is.EqualTo(10));
        Assert.That(poolConfig.MaxIdle, Is.EqualTo(5));
        Assert.That(poolConfig.MinIdle, Is.EqualTo(0));
        
        // 参数太多，导致可读性差、参数可能传递错误
        // ResourcePoolConfig config = new ResourcePoolConfig("dbconnectionpool", 16, null, 8, null, false , true, 10, 20, false, true);
    }
}