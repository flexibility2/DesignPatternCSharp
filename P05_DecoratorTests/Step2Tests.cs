using P05_Decorator.Step2_Strategy;

namespace P05_DecoratorTests;

public class Step2Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CalculateRent()
    {
        var sedanRental = new FullDiscountVipSedanRental(3, new Customer(true));
        decimal rent1 = sedanRental.CalculateRent();
        Assert.That(rent1, Is.EqualTo(450.0));

        var mpvRental = new VipMpvRental(7, new Customer(true));
        decimal rent2 = mpvRental.CalculateRent();
        Assert.That(rent2, Is.EqualTo(1440.0));
    }
}