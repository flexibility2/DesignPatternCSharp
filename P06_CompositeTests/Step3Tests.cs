using P06_Composite.Step3_Practice;

namespace P06_CompositeTests;

public class Step3Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_GetContents()
    {
        List<Order> orders = GenerateOrders();
        OrderWriter writer = new OrderWriter(orders);
        String xml = writer.GetContents();

        String result =
            "<orders>" +
            "<order id='321' totalPrice='238.95'>" +
            "<product id='f1234' color='red' size='medium'>" +
            "<price currency='USD'>8.95</price>" +
            "Fire Truck" +
            "</product>" +
            "<product id='p1112' color='red' size='medium'>" +
            "<price currency='USD'>230</price>" +
            "Toy Porsche" +
            "</product>" +
            "</order>" +
            "<order id='537' totalPrice='5.98'>" +
            "<product id='b3421' color='white' size='small'>" +
            "<price currency='USD'>2.99</price>" +
            "Base Ball" +
            "</product>" +
            "</order>" +
            "</orders>";

        Assert.That(xml, Is.EqualTo(result));
    }
    
    private List<Order> GenerateOrders() {
        List<Order> orders = new List<Order>();

        // Fire Truck
        Product product1 = new Product();
        product1.Id = "f1234";
        product1.Name = "Fire Truck";
        product1.Color = "red";
        product1.Size = "medium";
        product1.Currency = "USD";
        product1.Price = (decimal)8.95;
        product1.Quantity = 1;

        // Toy Porsche
        Product product2 = new Product();
        product2.Id = "p1112";
        product2.Name = "Toy Porsche";
        product2.Color = "red";
        product2.Size = "medium";
        product2.Currency = "USD";
        product2.Price = (decimal)230.0;
        product2.Quantity = 1;

        // Order1
        Order order1 = new Order();
        order1.Id = "321";
        order1.TotalPrice = (decimal)238.95;
        order1.Products.Add(product1);
        order1.Products.Add(product2);
        orders.Add(order1);

        // Toy Porsche
        Product product3 = new Product();
        product3.Id = "b3421";
        product3.Name = "Base Ball";
        product3.Color = "white";
        product3.Size = "small";
        product3.Currency = "USD";
        product3.Price = (decimal)2.99;
        product3.Quantity = 2;

        // Order2
        Order order2 = new Order();
        order2.Id = "537";
        order2.TotalPrice = (decimal)5.98;
        order2.Products.Add(product3);
        orders.Add(order2);

        return orders;
    }
}