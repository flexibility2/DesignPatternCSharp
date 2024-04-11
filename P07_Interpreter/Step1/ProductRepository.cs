namespace P07_Interpreter.Step1;

public class ProductRepository
{
    private readonly List<Product> _products;

    public ProductRepository(List<Product> products) {
        _products = products;
    }

    public List<Product> SelectByColor(string color)
    {
        List<Product> selectedProducts = new List<Product>();

        foreach (var product in _products)
        {
            if (product.Color.ToLower() == color.ToLower())
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }

    public List<Product> SelectBySize(string size)
    {
        List<Product> selectedProducts = new List<Product>();
        
        foreach (var product in _products)
        {
            if (product.Size.ToLower() == size.ToLower())
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }

    public List<Product> SelectByBelowPrice(decimal price)
    {
        List<Product> selectedProducts = new List<Product>();
        
        foreach (var product in _products)
        {
            if (product.Price < price)
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }

    public List<Product> SelectByColorSizeAndBelowPrice(string color, string size, decimal price)
    {
        List<Product> selectedProducts = new List<Product>();

        foreach (var product in _products)
        {
            if (product.Size.ToLower() == size.ToLower() &&
                product.Color.ToLower() == color.ToLower() &&
                product.Price < price)
            {
                selectedProducts.Add(product);
            }
        }

        return selectedProducts;
    }
}