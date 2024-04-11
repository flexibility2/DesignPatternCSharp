namespace P07_Interpreter.Step3;

public class NotSpec : ISpec
{
    private readonly ISpec _innerSpec;

    public NotSpec(ISpec innerSpec)
    {
        _innerSpec = innerSpec;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return !_innerSpec.IsSatisfiedBy(product);
    }
}