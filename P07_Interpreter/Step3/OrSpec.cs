namespace P07_Interpreter.Step3;

public class OrSpec : ISpec
{
    private readonly ISpec _leftSpec;
    private readonly ISpec _rightSpec;

    public OrSpec(ISpec leftSpec, ISpec rightSpec)
    {
        _leftSpec = leftSpec;
        _rightSpec = rightSpec;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return _leftSpec.IsSatisfiedBy(product) || _rightSpec.IsSatisfiedBy(product);
    }
}