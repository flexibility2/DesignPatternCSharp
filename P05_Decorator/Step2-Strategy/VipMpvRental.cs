using P05_Decorator.Step1;

namespace P05_Decorator.Step2_Strategy;

public class VipMpvRental : MpvRental
{
    private readonly Customer _customer;

    public VipMpvRental(int rentalPeriod, Customer customer) 
        : base(rentalPeriod)
    {
        _customer = customer;
    }

    public override decimal CalculateRent()
    {
        decimal rent = base.CalculateRent();
        if (_customer.IsVip)
        {
            rent *= (decimal)0.9;
        }

        return rent;
    }
}