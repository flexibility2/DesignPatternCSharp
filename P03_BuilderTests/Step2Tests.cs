using P03_Builder.Step2;

namespace P03_Builder;

public class Step2Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CreateResourcePoolConfig()
    {
        var poolConfig = new ResourcePoolConfig("dbconnectionpool");
        poolConfig.SetMaxTotal(10);
        poolConfig.SetMaxIdle(5);
        poolConfig.SetMinIdle(0);
        
        Assert.That(poolConfig.Name, Is.EqualTo("dbconnectionpool"));
        Assert.That(poolConfig.MaxTotal, Is.EqualTo(10));
        Assert.That(poolConfig.MaxIdle, Is.EqualTo(5));
        Assert.That(poolConfig.MinIdle, Is.EqualTo(0));
        
        // 假设配置项之间有一定的依赖关系，比如，如果用户设置了 maxTotal、maxIdle、minIdle 其中一个，
        // 就必须显式地设置另外两个；或者配置项之间有一定的约束条件，比如，maxIdle 和 minIdle 要小于等于 maxTotal。
        // 如果我们继续使用现在的设计思路，那这些配置项之间的依赖关系或者约束条件的校验逻辑就无处安放了。
    }
}