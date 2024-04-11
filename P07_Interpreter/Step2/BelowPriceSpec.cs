namespace P07_Interpreter.Step2;

public class BelowPriceSpec : ISpec
{
    private readonly decimal _price;

    public BelowPriceSpec(decimal price)
    {
        _price = price;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return product.Price < _price;
    }
}