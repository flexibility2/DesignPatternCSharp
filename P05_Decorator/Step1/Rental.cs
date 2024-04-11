namespace P05_Decorator.Step1;

public class Rental
{
    private CarType _carType;
    private Customer _customer;
    private int _rentalPeriod;
    private bool _is500Minus30;

    public Rental(Customer customer, CarType carType, int rentalPeriod, bool is500Minus30)
    {
        _customer = customer;
        _carType = carType;
        _rentalPeriod = rentalPeriod;
        _is500Minus30 = is500Minus30;
    }

    public decimal CalculateRent()
    {
        decimal rent = 0;

        switch (_carType) {
            case CarType.Sedan:
                rent = 200 + 150 * (_rentalPeriod - 1);
                break;
            case CarType.Suv:
                rent = 300 * _rentalPeriod;
                break;
            case CarType.Mpv:
                if (_rentalPeriod < 3) {
                    rent = 600;
                } else {
                    rent = 600 + 200 * (_rentalPeriod - 2);
                }
                break;
        }

        if (_customer.IsVip) {
            rent *= (decimal)0.9;
        }

        if (_is500Minus30) {
            int discountTime = (int) Math.Floor(rent / 500);
            rent -= discountTime * 30;
        }

        return rent;
    }
}