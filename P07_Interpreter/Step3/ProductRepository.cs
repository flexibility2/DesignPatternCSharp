namespace P07_Interpreter.Step3;

public class ProductRepository
{
    private readonly List<Product> _products;

    public ProductRepository(List<Product> products) {
        _products = products;
    }

    public List<Product> SelectBySpecs(ISpec spec) {
        List<Product> selectedProducts = new List<Product>();

        foreach (var product in _products)
        {
            if (spec.IsSatisfiedBy(product))
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }
}