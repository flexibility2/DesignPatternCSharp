namespace P05_Decorator.Step2_Strategy;

public class SuvRental : IRental
{
    private int _rentalPeriod;

    public SuvRental(int rentalPeriod)
    {
        _rentalPeriod = rentalPeriod;
    }

    public virtual decimal CalculateRent()
    {
        decimal rent = 300 * _rentalPeriod;
        return rent;
    }
}