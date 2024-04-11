using P05_Decorator.Step1;

namespace P05_Decorator.Step2_Strategy;

public class FullDiscountVipSedanRental : VipSedanRental
{
    public FullDiscountVipSedanRental(int rentalPeriod, Customer customer) 
        : base(rentalPeriod, customer)
    {
    }

    public override decimal CalculateRent()
    {
        decimal rent = base.CalculateRent();
        int discountTime = (int) Math.Floor(rent / 500);
        return rent - discountTime * 30;
    }
}