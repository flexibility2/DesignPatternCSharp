namespace P07_Interpreter.Step1;

public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public int Quantity { get; set; }
    
    public const string NotApplicable = "NOT_APPLICABLE";
}