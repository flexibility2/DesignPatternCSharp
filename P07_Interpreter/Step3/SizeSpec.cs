namespace P07_Interpreter.Step3;

public class SizeSpec : ISpec
{
    private readonly string _size;

    public SizeSpec(string size)
    {
        _size = size.ToLower();
    }

    public bool IsSatisfiedBy(Product product)
    {
        return _size == product.Size.ToLower();
    }
}