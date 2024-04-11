using P09_ResponsibilityChain;

namespace P09_ResponsibilityChainTests;

public class ChainTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_ChainHandler()
    {
        HandlerChain chain = new HandlerChain();
        chain.AddHandler(new HandlerA());
        chain.AddHandler(new HandlerB());
        chain.AddHandler(new HandlerC());
        chain.Handle();
    }
}