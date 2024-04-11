namespace P05_Decorator.Step3_Decorator;

public class MpvRental : IRental
{
    private int _rentalPeriod;

    public MpvRental(int rentalPeriod)
    {
        _rentalPeriod = rentalPeriod;
    }

    public virtual decimal CalculateRent()
    {
        decimal rent = 600 + 200 * (_rentalPeriod - 2);
        return rent;
    }
}