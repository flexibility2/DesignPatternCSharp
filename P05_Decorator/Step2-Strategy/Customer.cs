namespace P05_Decorator.Step2_Strategy;

public class Customer
{
    public bool IsVip { get; private set; }

    public Customer(bool isVip)
    {
        IsVip = isVip;
    }
}