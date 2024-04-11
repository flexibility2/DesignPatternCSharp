namespace P07_Interpreter.Step2;

public class ColorSpec : ISpec
{
    private readonly string _color;
    
    public ColorSpec(string color)
    {
        _color = color.ToLower();
    }

    public bool IsSatisfiedBy(Product product)
    {
        return _color == product.Color.ToLower();
    }
}