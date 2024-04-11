using P07_Interpreter.Step2;

namespace P07_InterpreterTests;

public class Step2Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_SelectByColor()
    {
        ProductRepository productRepo = new ProductRepository(GenerateProducts());

        ColorSpec colorSpec = new ColorSpec("red");
        List<Product> products = productRepo.SelectBySpecs(new List<ISpec> { colorSpec });

        Assert.That(products.Count, Is.EqualTo(2));
        Assert.That(products[0].Name, Is.EqualTo("Fire Truck"));
        Assert.That(products[1].Name, Is.EqualTo("Toy Porsche"));
    }

    [Test]
    public void Test_SelectBySize()
    {
        ProductRepository productRepo = new ProductRepository(GenerateProducts());

        SizeSpec sizeSpec = new SizeSpec("large");
        List<Product> products = productRepo.SelectBySpecs(new List<ISpec> { sizeSpec });

        Assert.That(products.Count, Is.EqualTo(1));
        Assert.That(products[0].Name, Is.EqualTo("Frisbee"));
    }
    
    [Test]
    public void TestSelectByBelowPrice() {
        ProductRepository productRepo = new ProductRepository(GenerateProducts());

        BelowPriceSpec belowPriceSpec = new BelowPriceSpec((decimal)10.0);
        List<Product> products = productRepo.SelectBySpecs(new List<ISpec> { belowPriceSpec });

        Assert.That(products.Count, Is.EqualTo(3));
        Assert.That(products[0].Name, Is.EqualTo("Fire Truck"));
        Assert.That(products[1].Name, Is.EqualTo("Base Ball"));
        Assert.That(products[2].Name, Is.EqualTo("Frisbee"));
    }
    
    [Test]
    public void TestSelectByColorSizeAndBelowPrice() {
        ProductRepository productRepo = new ProductRepository(GenerateProducts());

        ColorSpec colorSpec = new ColorSpec("red");
        SizeSpec sizeSpec = new SizeSpec("small");
        BelowPriceSpec belowPriceSpec = new BelowPriceSpec((decimal)10.0);
        List<Product> products = productRepo.SelectBySpecs(
            new List<ISpec> { colorSpec, sizeSpec, belowPriceSpec });

        Assert.That(products.Count, Is.EqualTo(1));
        Assert.That(products[0].Name, Is.EqualTo("Fire Truck"));
    }

    private List<Product> GenerateProducts() {
        List<Product> products = new List<Product>();

        // Fire Truck
        Product product1 = new Product();
        product1.Id = "f1234";
        product1.Name = "Fire Truck";
        product1.Color = "red";
        product1.Size = "small";
        product1.Currency = "USD";
        product1.Price = (decimal)8.95;
        product1.Quantity = 1;
        products.Add(product1);

        // Toy Porsche
        Product product2 = new Product();
        product2.Id = "p1112";
        product2.Name = "Toy Porsche";
        product2.Color = "red";
        product2.Size = "NOT_APPLICABLE";
        product2.Currency = "USD";
        product2.Price = (decimal)230.0;
        product2.Quantity = 1;
        products.Add(product2);

        // Base Ball
        Product product3 = new Product();
        product3.Id = "b3421";
        product3.Name = "Base Ball";
        product3.Color = "white";
        product3.Size = "NOT_APPLICABLE";
        product3.Currency = "USD";
        product3.Price = (decimal)8.95;
        product3.Quantity = 1;
        products.Add(product3);

        // Frisbee
        Product product4 = new Product();
        product4.Id = "f4321";
        product4.Name = "Frisbee";
        product4.Color = "pink";
        product4.Size = "large";
        product4.Currency = "USD";
        product4.Price = (decimal)9.99;
        product4.Quantity = 1;
        products.Add(product4);

        // Barbie Classic
        Product product5 = new Product();
        product5.Id = "b7654";
        product5.Name = "Barbie Classic";
        product5.Color = "yellow";
        product5.Size = "small";
        product5.Currency = "USD";
        product5.Price = (decimal)15.95;
        product5.Quantity = 1;
        products.Add(product5);

        return products;
    }
}