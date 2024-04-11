namespace P05_Decorator.Step3_Decorator;

public class Customer
{
    public bool IsVip { get; private set; }

    public Customer(bool isVip)
    {
        IsVip = isVip;
    }
}