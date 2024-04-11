using P03_Builder.Step3;

namespace P03_Builder;

public class Step3Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateResourcePoolConfig()
    {
        var poolConfig = new ResourcePoolConfig.Builder()
            .SetName("dbconnectionpool")
            .SetMaxTotal(10)
            .SetMaxIdle(5)
            .SetMinIdle(0)
            .Build();
        
        Assert.That(poolConfig.Name, Is.EqualTo("dbconnectionpool"));
        Assert.That(poolConfig.MaxTotal, Is.EqualTo(10));
        Assert.That(poolConfig.MaxIdle, Is.EqualTo(5));
        Assert.That(poolConfig.MinIdle, Is.EqualTo(0));
    }
    
    [Test]
    public void Test_CreateResourcePoolConfig_WithoutName()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var poolConfig = new ResourcePoolConfig.Builder()
                .SetMaxTotal(10)
                .SetMaxIdle(5)
                .SetMinIdle(0)
                .Build();
        });
    }
    
    [Test]
    public void Test_CreateResourcePoolConfig_MaxIdleGTMaxTotal()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var poolConfig = new ResourcePoolConfig.Builder()
                .SetName("dbconnectionpool")
                .SetMaxTotal(10)
                .SetMaxIdle(20)
                .SetMinIdle(0)
                .Build();
        });
    }
    
    [Test]
    public void Test_CreateResourcePoolConfig_MinIdleGTMaxIdle()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var poolConfig = new ResourcePoolConfig.Builder()
                .SetName("dbconnectionpool")
                .SetMaxTotal(10)
                .SetMaxIdle(5)
                .SetMinIdle(8)
                .Build();
        });
    }
}