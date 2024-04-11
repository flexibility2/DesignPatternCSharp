namespace P05_Decorator.Step3_Decorator;

public class SedanRental : IRental
{
    private int _rentalPeriod;

    public SedanRental(int rentalPeriod)
    {
        _rentalPeriod = rentalPeriod;
    }

    public virtual decimal CalculateRent()
    {
        decimal rent = 200 + 150 * (_rentalPeriod - 1);
        return rent;
    }
}