namespace P07_Interpreter.Step2;

public class ProductRepository
{
    private readonly List<Product> _products;

    public ProductRepository(List<Product> products) {
        _products = products;
    }

    public List<Product> SelectBySpecs(List<ISpec> specs) {
        List<Product> selectedProducts = new List<Product>();

        foreach (var product in _products)
        {
            bool isSatisfiedAllSpecs = true;

            foreach (var spec in specs)
            {
                isSatisfiedAllSpecs &= spec.IsSatisfiedBy(product);
            }

            if (isSatisfiedAllSpecs)
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }
}