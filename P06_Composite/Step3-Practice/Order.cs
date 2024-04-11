namespace P06_Composite.Step3_Practice;

public class Order
{
    public string Id { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }
}