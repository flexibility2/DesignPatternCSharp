namespace P07_Interpreter.Step3;

public class AndSpec : ISpec
{
    private readonly ISpec _leftSpec;
    private readonly ISpec _rightSpec;

    public AndSpec(ISpec leftSpec, ISpec rightSpec)
    {
        _leftSpec = leftSpec;
        _rightSpec = rightSpec;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return _leftSpec.IsSatisfiedBy(product) && _rightSpec.IsSatisfiedBy(product);
    }
}