namespace P01_Singleton.Step1;

public class OrderController
{
    private readonly Logger _logger = new Logger();

    public void Create(string orderId)
    {
        // ...省略业务逻辑代码...
        _logger.Log($"Created an order: {orderId}");
    }
}