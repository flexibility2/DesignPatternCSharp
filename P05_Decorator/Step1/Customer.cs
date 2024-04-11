namespace P05_Decorator.Step1;

public class Customer
{
    public bool IsVip { get; private set; }

    public Customer(bool isVip)
    {
        IsVip = isVip;
    }
}